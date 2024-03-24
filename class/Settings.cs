using System.Windows.Forms;

namespace Local_library
{
    internal class Settings
    {
        public string FilePath { get; set; }


        /// <summary>
        /// Changes the file path of the settings file.
        /// </summary>
        /// <returns>
        /// Returns true if the file path was successfully changed, false otherwise.
        /// </returns>
        public bool changeFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Select a JSON file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;

                    // Save the file path in the program settings
                    Properties.Settings.Default.FilePath = FilePath;
                    Properties.Settings.Default.Save();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
