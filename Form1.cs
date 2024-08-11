using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Diagnostics
{
	public partial class Form1 : Form
	{
		// Declare logFilePath as a class-level variable
		private string logFilePath;
		public Form1()
		{
			InitializeComponent();
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			// Check if the IP addresses TextBox is empty
			if (string.IsNullOrWhiteSpace(txtIpAddresses.Text))
			{
				MessageBox.Show("IP addresses cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				lblProgress.Text = "Status: Starting...";
				lblTimeTaken.Text = "Time Taken: 0 ms"; // Reset time taken label
				Application.DoEvents();  // Force the UI to update

				string[] ipAddresses = txtIpAddresses.Text.Split(new[] { ',', ';', '\n' }, StringSplitOptions.RemoveEmptyEntries);
				string command = rdoTracert.Checked ? "tracert" : "ping";

				// Record the start time
				var startTime = DateTime.Now;

				// Perform diagnostics and save logs
				logFilePath = await PerformNetworkDiagnosticsAsync(ipAddresses, command);

				// Record the end time and calculate the duration
				var endTime = DateTime.Now;
				var timeTaken = endTime - startTime;

				// Update progress and time taken
				lblProgress.Text = "Status: Completed";
				lblTimeTaken.Text = $"Time Taken: {timeTaken.TotalMilliseconds:F2} ms";
				txtLogs.Text = File.ReadAllText(logFilePath);

				// Notify file was saved successfully
				MessageBox.Show("Diagnostics completed and log file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				lblProgress.Text = "Status: Failed";
				lblTimeTaken.Text = "Time Taken: 0 ms"; // Reset time taken on failure
				MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async Task<string> PerformNetworkDiagnosticsAsync(string[] ipAddresses, string command)
		{
			// Generate a unique filename with a timestamp
			string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
			string logFileName = $"NetworkDiagnosticsLog_{timestamp}.txt";
			logFilePath = Path.Combine(Directory.GetCurrentDirectory(), logFileName);

			try
			{
				using (StreamWriter writer = new StreamWriter(logFilePath, false))  // 'false' ensures we're not appending
				{
					int totalCount = ipAddresses.Length;
					int currentCount = 0;

					foreach (var ip in ipAddresses)
					{
						lblProgress.Text = $"Status: Processing {++currentCount}/{totalCount}";
						Application.DoEvents();  // Forces the UI to update

						await writer.WriteLineAsync($"IP: {ip}, Command: {command}");

						try
						{
							string output = await ExecuteCommandAsync(ip, command);
							await writer.WriteLineAsync(output);
						}
						catch (Exception ex)
						{
							await writer.WriteLineAsync($"Error executing {command} on {ip}: {ex.Message}");
						}

						await writer.WriteLineAsync("------------------------------------------------------");
					}
				}

				lblProgress.Text = "Status: Completed";
			}
			catch (IOException ex)
			{
				lblProgress.Text = "Status: File Error";
				MessageBox.Show($"File error: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				lblProgress.Text = "Status: Unexpected Error";
				MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return logFilePath;
		}

		private Task<string> ExecuteCommandAsync(string ip, string command)
		{
			return Task.Run(() =>
			{
				try
				{
					string cmd = command.ToLower() == "tracert" ? "tracert" : "ping";
					ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c {cmd} {ip}")
					{
						RedirectStandardOutput = true,
						UseShellExecute = false,
						CreateNoWindow = true
					};

					using (Process process = Process.Start(psi))
					{
						using (StreamReader reader = process.StandardOutput)
						{
							return reader.ReadToEnd();
						}
					}
				}
				catch (Exception ex)
				{
					throw new InvalidOperationException($"Failed to execute {command} on {ip}: {ex.Message}", ex);
				}
			});
		}

		private void btnSaveLog_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(logFilePath) && File.Exists(logFilePath))
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
					saveFileDialog.FileName = Path.GetFileName(logFilePath);  // Suggest the generated file name

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.Copy(logFilePath, saveFileDialog.FileName);
						MessageBox.Show("Log file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("No log file to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show($"File save error: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void clear1_Click(object sender, EventArgs e)
		{
			txtIpAddresses.Clear();
		}

		private void clear2_Click(object sender, EventArgs e)
		{
			txtLogs.Clear();
			lblProgress.Text = "Status: Waiting";
			lblTimeTaken.Text = "Time Taken: 0 ms";
		}
	}
}