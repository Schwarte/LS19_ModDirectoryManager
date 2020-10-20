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
        static string user = Environment.UserName;
        static string dataPath = "C:\\Users\\" + user + "\\Documents\\My Games\\FarmingSimulator2019";
        string metaDataPath = dataPath + "\\LS19_ModDirectoryManager_Metadata.txt";
        public ModDirManagerForm()
        {
            InitializeComponent();

            StartProgressBar.Visible = false;

            if (File.Exists(@metaDataPath))
            {
                string[] metaData = System.IO.File.ReadAllLines(metaDataPath);

                if (metaData.Length >= 3)
                {
                    GamePathTextbox.Text = metaData[0];
                    ModDirPathTextbox.Text = metaData[1];

                    if (metaData[2] == "true")
                    {
                     
                        Directory.Delete(Path.Combine(metaData[0], "mods"));
                        SelectModDirListbox.Items.Clear();
                        ModDirExtCheckbox.Checked = true;
                        string[] mods = Directory.GetDirectories(metaData[1],"mods*", SearchOption.TopDirectoryOnly);
                        /* foreach (string mod in mods)
                        {
                            string path = metaData[1] + "\\mods";
                            string[] seperator = new string[] { path };
                            string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                            SelectModDirListbox.Items.Add(tmp[1]);
                        } */
                    } 
                    else
                    {
                        string oldModPath = dataPath + "\\mods";
                        string newOldModPath = dataPath + "\\modsAlt";
                        if (Directory.Exists(oldModPath))
                        {
                            if (metaData[3] == "empty")
                            {
                                Directory.Move(oldModPath, newOldModPath);
                            }
                            else
                            {
                                string latestModPath = dataPath + "\\mods" + metaData[3];
                                Directory.Move(oldModPath, latestModPath);
                            }
                        }
                        
                        SelectModDirListbox.Items.Clear();
                        string[] mods = Directory.GetDirectories(dataPath, "mods*", SearchOption.TopDirectoryOnly);
                        foreach (string mod in mods)
                        {
                            string path = dataPath + "\\mods";
                            string[] seperator = new string[] { path };
                            string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                            SelectModDirListbox.Items.Add(tmp[1]);
                        }

                        ModDirPathLabel.Visible = false;
                        ModDirPathButton.Visible = false;
                        ModDirPathTextbox.Visible = false;
                    } 
                }
            }
            else
            {
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

                SelectModDirListbox.Items.Clear();
                string[] mods = Directory.GetDirectories(ModDirPathTextbox.Text, "mods*", SearchOption.TopDirectoryOnly);
                foreach (string mod in mods)
                {
                    string path = ModDirPathTextbox.Text + "\\mods";
                    string[] seperator = new string[] { path };
                    string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                    SelectModDirListbox.Items.Add(tmp[1]);
                }

            }
            else if (ModDirExtCheckbox.Checked == false)
            {
                ModDirPathLabel.Visible = false;
                ModDirPathButton.Visible = false;
                ModDirPathTextbox.Visible = false;

                SelectModDirListbox.Items.Clear();
                string[] mods = Directory.GetDirectories(dataPath, "mods*", SearchOption.TopDirectoryOnly);
                foreach (string mod in mods)
                {
                    string path = dataPath + "\\mods";
                    string[] seperator = new string[] { path };
                    string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                    SelectModDirListbox.Items.Add(tmp[1]);
                }
            }
        }

        private void ModDirPathButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Beschreibung";
            objDialog.SelectedPath = @allModsFilePath;       
            DialogResult objResult = objDialog.ShowDialog(this);
            allModsFilePath = objDialog.SelectedPath;
            ModDirPathTextbox.Text = allModsFilePath;

            SelectModDirListbox.Items.Clear();
            string[] mods = Directory.GetDirectories(ModDirPathTextbox.Text, "mods*", SearchOption.TopDirectoryOnly);
            foreach (string mod in mods)
            {
                string path = ModDirPathTextbox.Text + "\\mods";
                string[] seperator = new string[] { path };
                string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                SelectModDirListbox.Items.Add(tmp[1]);
            }

        }

        private void CreateNewModDirButton_Click(object sender, EventArgs e)
        {
            string modDirName = CreateNewModDirTextbox.Text;

            if (ModDirExtCheckbox.Checked == true)
            {
                string newModDir = ModDirPathTextbox.Text + "\\mods" + modDirName;
                Directory.CreateDirectory(newModDir);

                SelectModDirListbox.Items.Clear();
                string[] mods = Directory.GetDirectories(ModDirPathTextbox.Text, "mods*", SearchOption.TopDirectoryOnly);
                foreach (string mod in mods)
                {
                    string path = ModDirPathTextbox.Text + "\\mods";
                    string[] seperator = new string[] { path };
                    string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                    SelectModDirListbox.Items.Add(tmp[1]);
                }

            }
            else
            {
                string newModDir = dataPath + "\\mods" + modDirName;
                Directory.CreateDirectory(newModDir);

                SelectModDirListbox.Items.Clear();
                string[] mods = Directory.GetDirectories(dataPath, "mods*", SearchOption.TopDirectoryOnly);
                foreach (string mod in mods)
                {
                    string path = dataPath + "\\mods";
                    string[] seperator = new string[] { path };
                    string[] tmp = mod.Split(seperator, StringSplitOptions.None);
                    SelectModDirListbox.Items.Add(tmp[1]);
                }
            }
        }

        private void openSelectedModDirButton_Click(object sender, EventArgs e)
        {
            //Modordner öffnen, If Abzweigung für Checkbox, Pfad wieder zusammen setzen
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            string[] metadata = new string[4];
            metadata[0] = GamePathTextbox.Text;
            metadata[1] = ModDirPathTextbox.Text;
            
            if (ModDirExtCheckbox.Checked == true)
            {
                metadata[2] = "true";
                metadata[3] = "empty";
                string orgPath = metadata[1] + "\\mods" + SelectModDirListbox.SelectedItem;
                string modPath = dataPath + "\\mods";
                
                if (Directory.Exists(modPath))
                {
                    string[] mods = GetFileNames(orgPath, "*.zip");
                    int modCount = mods.Length;
                    int i = 0;
                    StartProgressBar.Visible = true;
                    StartProgressBar.Maximum = modCount;
                    foreach (string mod in mods)
                    {
                        
                        File.Copy(Path.Combine(orgPath, mod), Path.Combine(modPath, mod),true);

                        i++;
                        StartProgressBar.Value = i;
                    } 
                }
                else
                {
                    Directory.CreateDirectory(modPath);
                    string[] mods = GetFileNames(orgPath, "*.zip");
                    int modCount = mods.Length;
                    int i = 0;
                    StartProgressBar.Visible = true;
                    StartProgressBar.Maximum = modCount;
                    foreach (string mod in mods)
                    {                    
                        File.Copy(Path.Combine(orgPath, mod), Path.Combine(modPath, mod));
                        i++;
                        StartProgressBar.Value = i;
                    } 
                }

            } 
            else
            {
                metadata[2] = "false";
                metadata[3] = SelectModDirListbox.SelectedItem.ToString();
                string modPath = dataPath + "\\mods";
                string selectedMods =modPath + metadata[3];
                if (Directory.Exists(modPath))
                {
                    Directory.Delete(modPath);
                    Directory.Move(selectedMods, modPath);
                } 
                else
                {
                    Directory.Move(selectedMods, modPath);
                }
            }
                   
            System.IO.File.WriteAllLines(@metaDataPath, metadata);
            Process.Start(metadata[0]);
            this.Close();
        }

        private static string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }
    }
}
