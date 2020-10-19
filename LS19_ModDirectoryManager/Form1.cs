﻿using System;
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
        static string user = Environment.UserName;
        static string dataPath = "C:\\Users\\" + user + "\\Documents\\My Games\\FarmingSimulator2019";
        string metaDataPath = dataPath + "\\LS19_ModDirectoryManager_Metadata.txt";
        public ModDirManagerForm()
        {
            InitializeComponent();

            if (File.Exists(@metaDataPath))
            {
                ErrorLabel.Text = "Metadatei vorhanden";
                string[] metaData = System.IO.File.ReadAllLines(metaDataPath);

                if (metaData.Length == 3)
                {
                    GamePathTextbox.Text = metaData[0];
                    ModDirPathTextbox.Text = metaData[1];

                    if (metaData[2] == "true")
                    {
                        ModDirExtCheckbox.Checked = true;
                    } else
                    {
                        ModDirPathLabel.Visible = false;
                        ModDirPathButton.Visible = false;
                        ModDirPathTextbox.Visible = false;
                    } 
                }
            }
            else
            {
                ErrorLabel.Text = "Metadatei wurde erstellt";
                File.Create(metaDataPath);

                ModDirPathLabel.Visible = false;
                ModDirPathButton.Visible = false;
                ModDirPathTextbox.Visible = false;
            }
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
        
        private void ModDirExtCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ModDirExtCheckbox.Checked == true)
            {
                ModDirPathLabel.Visible = true;
                ModDirPathButton.Visible = true;
                ModDirPathTextbox.Visible = true;
            }
            else if (ModDirExtCheckbox.Checked == false)
            {
                ModDirPathLabel.Visible = false;
                ModDirPathButton.Visible = false;
                ModDirPathTextbox.Visible = false;
            }
        }

        private void ModDirPathButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Beschreibung";
            objDialog.SelectedPath = @allModsFilePath;       // Vorgabe Pfad (und danach der gewählte Pfad)
            DialogResult objResult = objDialog.ShowDialog(this);
            allModsFilePath = objDialog.SelectedPath;
            ModDirPathTextbox.Text = allModsFilePath;
        }

        private void CreateNewModDirButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectModDirListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            string[] metadata = new string[3];
            metadata[0] = GamePathTextbox.Text;
            metadata[1] = ModDirPathTextbox.Text;
            
            if (ModDirExtCheckbox.Checked == true)
            {
                metadata[2] = "true";
            } else
            {
                metadata[2] = "false";
            }
                   
            System.IO.File.WriteAllLines(@metaDataPath, metadata);
        }
    }
}
