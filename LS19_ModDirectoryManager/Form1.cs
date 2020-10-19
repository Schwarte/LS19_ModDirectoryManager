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

namespace LS19_ModDirectoryManager
{
    public partial class ModDirManagerForm : Form
    {
        string gameFilePath = "c:\\";
        string allModsFilePath = "c:\\";

        public ModDirManagerForm()
        {
            InitializeComponent();

            

          //  var gameFileContent = string.Empty;
          //  var gameFilePath = string.Empty;
          //  var allModsFilePath = string.Empty;
        }

        private void GamePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Wähle die LS19 .exe aus";
                openFileDialog.InitialDirectory = gameFilePath;
                openFileDialog.Filter = "Farming Simulator (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    gameFilePath = openFileDialog.FileName;
                    GamePathTextbox.Text = gameFilePath;
                }
            }
        }

        private void ModDirPathButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Beschreibung";
            objDialog.SelectedPath = @allModsFilePath;       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            allModsFilePath = objDialog.SelectedPath;
            ModDirPath.Text = allModsFilePath;
        }

        private void CreateNewModDirButton_Click(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectModDirListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModDirPathTextbox_Load(object sender, EventArgs e)
        {

        }
    }
}
