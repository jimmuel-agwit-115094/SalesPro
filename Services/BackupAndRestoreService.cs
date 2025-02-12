using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SalesPro.Helpers;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace SalesPro.Services
{
    public class BackupAndRestoreService
    {
        private string connectionString;
        public BackupAndRestoreService()
        {
            string encryptedConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            string decryptedPassword = DatabaseSecurityService.GetDecryptedPassword();
            connectionString = encryptedConnectionString.Replace(DatabaseSecurityService.ExtractPassword(encryptedConnectionString), decryptedPassword);
        }

        public void BackupDatabase()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a new MySqlCommand object and associate it with the connection
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;

                    // Set the backup file path and name
                    string backupFolder = "C:/" + "\\SalesPro.BackupDatabase";
                    string backupFileName = $"SalesPro_{DateTime.Now:yyyy.MMdd_hh.mm}.rar";
                    string backupFilePath = Path.Combine(backupFolder, backupFileName);

                    // Create the backup folder if it doesn't exist
                    Directory.CreateDirectory(backupFolder);

                    MySqlBackup mb = new MySqlBackup(command);
                    mb.ExportToFile(backupFilePath);
                    connection.Close();
                    MessageHandler.ShowInfo($"Database with file name : {backupFileName} " +
                        $"successfully completed. Backup file saved to: {backupFilePath}");
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowError($"Error database backup: {ex}");
            }
        }

        public void RestoreDatabase()
        {
            if (MessageHandler.ShowQuestionGeneric("Confirm restore database?"))
            {
                try
                {
                    using (OpenFileDialog fd = new OpenFileDialog())
                    {
                        fd.Title = "Select database backup file.";
                        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        fd.Filter = "Database Backups (*.rar)|*.rar";
                        fd.FilterIndex = 0;

                        if (fd.ShowDialog() == DialogResult.OK)
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                MySqlCommand command = new MySqlCommand();
                                command.Connection = connection;

                                MySqlBackup mb = new MySqlBackup(command);
                                mb.ImportFromFile(fd.FileName);

                                connection.Close();

                                MessageBox.Show("Database restore successfully completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageHandler.ShowError($"Error restoring database: {ex}");
                }
            }
        }
    }
}
