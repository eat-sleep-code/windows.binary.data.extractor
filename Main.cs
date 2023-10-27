using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace BinaryDataExtractor
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			folderInput.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			serverInput.Text = "";
			databaseInput.Text = "";
			usernameInput.Text = "";
			passwordInput.Text = "";
			queryInput.Text = "";
			
			CheckReadiness();
		}



		private void FolderButton_Click(object sender, EventArgs e)
		{
			try
			{
				folderBrowserDialog.SelectedPath = folderInput.Text.Trim();
			}
			catch
			{
				folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			}
			DialogResult folderBrowserDialogResult = folderBrowserDialog.ShowDialog();

			if (folderBrowserDialogResult == DialogResult.OK)
			{
				folderInput.Text = folderBrowserDialog.SelectedPath;
			}
		}



		private void ExportButton_Click(object sender, EventArgs e)
		{
			SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
			//connectionString.ApplicationIntent = ApplicationIntent.ReadOnly;
			connectionString.DataSource = serverInput.Text.Trim();
			connectionString.InitialCatalog = databaseInput.Text.Trim();
			
			if (trustedConnectionSelector.Checked == true)
			{
				connectionString.TrustServerCertificate = true;
			}
			else
			{
				connectionString.UserID = usernameInput.Text.Trim();
				connectionString.Password = passwordInput.Text.Trim();
			}

			//MessageBox.Show(connectionString.ToString());
			try 
			{
				
				SqlConnection dbConnection = new SqlConnection(connectionString.ToString());
				SqlCommand dbCommand = new SqlCommand(queryInput.Text.Trim(), dbConnection);

				dbCommand.CommandTimeout = 604800;
                dbConnection.Open();
				using (SqlDataReader dataReader = dbCommand.ExecuteReader())
				{
					while (dataReader.Read())
					{
						Byte[] fileData = (Byte[])dataReader["FileData"];
						String fileName = (String)dataReader["FileName"];
						GenerateFile(fileData, folderInput.Text.Trim(), fileName, "");
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}


		}



		private void CancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}




		private void GenerateFile(byte[] fileData, string filePath, string fileName, string fileType)
		{
			try
			{
				FileStream fileStream = new FileStream(filePath + "\\" + fileName, FileMode.OpenOrCreate, FileAccess.Write);
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				binaryWriter.Write(fileData);
				binaryWriter.Flush();
				binaryWriter.Close();
				fileStream.Close();
			}
			catch //(Exception ex)
			{
				// SUPPRESS ERROR
			}
		}


		private void TrustedConnectionCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (trustedConnectionSelector.Checked == true)
			{
				usernameInput.Text = "";
				passwordInput.Text = "";
				usernameInput.Enabled = false;
				passwordInput.Enabled = false;
			}
			else
			{
				usernameInput.Enabled = true;
				passwordInput.Enabled = true;
			}
			CheckReadiness();
		}

		
		#region "Check Readiness"

			private void CheckReadiness()
			{
				exportButton.Enabled = false;
				if (serverInput.Text.Trim().Length > 0 && databaseInput.Text.Trim().Length > 0 && queryInput.Text.Trim().Length > 0)
				{
					if (trustedConnectionSelector.Checked == true || (usernameInput.Text.Trim().Length > 0 && passwordInput.Text.Trim().Length > 0))
					{
						exportButton.Enabled = true;
					}
				}
			}

			private void serverInput_TextChanged(object sender, EventArgs e)
			{
				CheckReadiness();
			}

			private void databaseInput_TextChanged(object sender, EventArgs e)
			{
				CheckReadiness();
			}

			private void usernameInput_TextChanged(object sender, EventArgs e)
			{
				CheckReadiness();
			}

			private void passwordInput_TextChanged(object sender, EventArgs e)
			{
				CheckReadiness();
			}

			private void queryInput_TextChanged(object sender, EventArgs e)
			{
				CheckReadiness();
			}

		#endregion

			

		


	}
}
