using System;
using System.IO;
using System.Windows.Forms;
using SettingsMerger.Properties;
using Tools.XmlConfigMerge;

namespace SettingsMerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Icon = Resources.Add_Files_To_Archive_Blue;

#if DEBUG
            txtOldSettings.Text = @"C:\Users\Public\Documents\Xml Files\2012_Settings.config";
            txtNewSettings.Text = @"C:\Users\Public\Documents\Xml Files\LatestSettings.config";
#endif

        }

        private void btnOpenOldSettings_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                txtOldSettings.Text = openFileDialog.FileName;
            }
        }

        private void btnOpenNewSettings_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                txtNewSettings.Text = openFileDialog.FileName;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                var oldSettingsFile = txtOldSettings.Text;
                var newSettingsFile = txtNewSettings.Text;

                if (!string.IsNullOrEmpty(oldSettingsFile) && !string.IsNullOrEmpty(newSettingsFile))
                {
                    CreateNewConfigBackup(newSettingsFile);
                    MergeSettingConfigFiles(oldSettingsFile, newSettingsFile);
                }
                else
                {
                    lblStatus.Text = "Error - Either of Settings.config file is not provided";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error occurred";
            }
        }

        /// <summary>
        /// Merge elements and values from existing config file to new config file.
        /// </summary>
        /// <param name="existingConfigFile">The path to existing old config file.</param>
        /// <param name="newConfigFile">The path to newly installed config file</param>
        private void MergeSettingConfigFiles(string existingConfigFile, string newConfigFile)
        {
            // Merge an "existing" config's settings into a "new" config
            var config = new ConfigFileManager(newConfigFile, existingConfigFile, makeMergeFromConfigPathTheSavePath: true);
            config.Save(newConfigFile);

            lblStatus.Text = "Old settings migrated to new one successfully";
        }

        /// <summary>
        /// Create backup of new Settings.config file, in case anything goes wrong
        /// </summary>
        /// <param name="newSettingConfigFile">The full path to new Settings.config file</param>
        private static void CreateNewConfigBackup(string newSettingConfigFile)
        {
            // User is already having backup of his old Settings.config file
            var directory = Path.GetDirectoryName(newSettingConfigFile);
            var backupFileName = $"clean.{Path.GetFileNameWithoutExtension(newSettingConfigFile)}.config";

            if (directory != null)
            {
                var backupFile = Path.Combine(directory, backupFileName);
                File.Copy(newSettingConfigFile, backupFile);
            }
            else
            {
                throw new Exception("Path to new Settings.config file not found");
            }
        }
    }
}
