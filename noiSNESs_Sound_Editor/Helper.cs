using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noiSNESs_Sound_Editor
{
    class Helper
    {
        /// <summary>
        /// Displays a FileDialog and performs an operation over the choosen file.
        /// </summary>
        /// <param name="openFile">True to display a OpenFileDialog and false to display a SaveFileDialog.</param>
        /// <param name="fileDialogFilter">I.e. "SPC File|*.spc"</param>
        /// <param name="fileDialogTitle">I.e. "Choose a SPC file"</param>
        /// <param name="function">Bool function to perform using the choosen file.</param>
        /// <returns>True if the file is choosen and the function returns true.</returns>
        public static bool fileDialogHelper(bool openFile, string fileDialogFilter, string fileDialogTitle, Func<string, bool> function, string preDefinedName="")
        {
            // Displays an OpenFileDialog so the user can select a res
            using (var fileDialog = (openFile) ? (FileDialog)new OpenFileDialog() : new SaveFileDialog())
            {
                fileDialog.Filter = fileDialogFilter;
                fileDialog.Title = fileDialogTitle;
                if(!string.IsNullOrEmpty(preDefinedName)) fileDialog.FileName = preDefinedName;

                // Show the Dialog
                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return false;

                if (string.IsNullOrEmpty(fileDialog.FileName))
                    return false;

                try
                {
                    return function(fileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.ToString(), "Error");
                }

                return false;
            }
        }
    }
}
