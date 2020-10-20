namespace LS19_ModDirectoryManager
{
    partial class ModDirManagerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.GamePathLabel = new System.Windows.Forms.Label();
            this.GamePathTextbox = new System.Windows.Forms.TextBox();
            this.GamePathButton = new System.Windows.Forms.Button();
            this.ModDirPathButton = new System.Windows.Forms.Button();
            this.ModDirPathTextbox = new System.Windows.Forms.TextBox();
            this.ModDirPathLabel = new System.Windows.Forms.Label();
            this.CreateNewModDirButton = new System.Windows.Forms.Button();
            this.CreateNewModDirTextbox = new System.Windows.Forms.TextBox();
            this.CreateNewModDirLabel = new System.Windows.Forms.Label();
            this.SelectModDirLabel = new System.Windows.Forms.Label();
            this.SelectModDirListbox = new System.Windows.Forms.ListBox();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ModDirExtCheckbox = new System.Windows.Forms.CheckBox();
            this.openSelectedModDirButton = new System.Windows.Forms.Button();
            this.StartProgressBar = new System.Windows.Forms.ProgressBar();
            this.deleteModDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamePathLabel
            // 
            this.GamePathLabel.AutoSize = true;
            this.GamePathLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePathLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.GamePathLabel.Location = new System.Drawing.Point(18, 19);
            this.GamePathLabel.Name = "GamePathLabel";
            this.GamePathLabel.Size = new System.Drawing.Size(112, 19);
            this.GamePathLabel.TabIndex = 0;
            this.GamePathLabel.Text = "LS19 Spielpfad";
            // 
            // GamePathTextbox
            // 
            this.GamePathTextbox.Location = new System.Drawing.Point(22, 41);
            this.GamePathTextbox.Name = "GamePathTextbox";
            this.GamePathTextbox.Size = new System.Drawing.Size(545, 20);
            this.GamePathTextbox.TabIndex = 1;
            this.GamePathTextbox.Text = "C:";
            // 
            // GamePathButton
            // 
            this.GamePathButton.Location = new System.Drawing.Point(581, 41);
            this.GamePathButton.Name = "GamePathButton";
            this.GamePathButton.Size = new System.Drawing.Size(161, 20);
            this.GamePathButton.TabIndex = 2;
            this.GamePathButton.Text = "Spielpfad auswählen";
            this.GamePathButton.UseVisualStyleBackColor = true;
            this.GamePathButton.Click += new System.EventHandler(this.GamePathButton_Click);
            // 
            // ModDirPathButton
            // 
            this.ModDirPathButton.Location = new System.Drawing.Point(581, 136);
            this.ModDirPathButton.Name = "ModDirPathButton";
            this.ModDirPathButton.Size = new System.Drawing.Size(161, 20);
            this.ModDirPathButton.TabIndex = 5;
            this.ModDirPathButton.Text = "Modordner auswählen";
            this.ModDirPathButton.UseVisualStyleBackColor = true;
            this.ModDirPathButton.Click += new System.EventHandler(this.ModDirPathButton_Click);
            // 
            // ModDirPathTextbox
            // 
            this.ModDirPathTextbox.Location = new System.Drawing.Point(22, 136);
            this.ModDirPathTextbox.Name = "ModDirPathTextbox";
            this.ModDirPathTextbox.Size = new System.Drawing.Size(545, 20);
            this.ModDirPathTextbox.TabIndex = 4;
            this.ModDirPathTextbox.Text = "C:";
            // 
            // ModDirPathLabel
            // 
            this.ModDirPathLabel.AutoSize = true;
            this.ModDirPathLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModDirPathLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ModDirPathLabel.Location = new System.Drawing.Point(18, 114);
            this.ModDirPathLabel.Name = "ModDirPathLabel";
            this.ModDirPathLabel.Size = new System.Drawing.Size(158, 19);
            this.ModDirPathLabel.TabIndex = 3;
            this.ModDirPathLabel.Text = "LS19 Modordnerpfad";
            // 
            // CreateNewModDirButton
            // 
            this.CreateNewModDirButton.Location = new System.Drawing.Point(275, 200);
            this.CreateNewModDirButton.Name = "CreateNewModDirButton";
            this.CreateNewModDirButton.Size = new System.Drawing.Size(161, 20);
            this.CreateNewModDirButton.TabIndex = 8;
            this.CreateNewModDirButton.Text = "Modordner erstellen";
            this.CreateNewModDirButton.UseVisualStyleBackColor = true;
            this.CreateNewModDirButton.Click += new System.EventHandler(this.CreateNewModDirButton_Click);
            // 
            // CreateNewModDirTextbox
            // 
            this.CreateNewModDirTextbox.Location = new System.Drawing.Point(22, 200);
            this.CreateNewModDirTextbox.Name = "CreateNewModDirTextbox";
            this.CreateNewModDirTextbox.Size = new System.Drawing.Size(238, 20);
            this.CreateNewModDirTextbox.TabIndex = 7;
            this.CreateNewModDirTextbox.Text = "#861";
            // 
            // CreateNewModDirLabel
            // 
            this.CreateNewModDirLabel.AutoSize = true;
            this.CreateNewModDirLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewModDirLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CreateNewModDirLabel.Location = new System.Drawing.Point(18, 178);
            this.CreateNewModDirLabel.Name = "CreateNewModDirLabel";
            this.CreateNewModDirLabel.Size = new System.Drawing.Size(199, 19);
            this.CreateNewModDirLabel.TabIndex = 6;
            this.CreateNewModDirLabel.Text = "neuen Modordner erstellen";
            // 
            // SelectModDirLabel
            // 
            this.SelectModDirLabel.AutoSize = true;
            this.SelectModDirLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectModDirLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SelectModDirLabel.Location = new System.Drawing.Point(18, 242);
            this.SelectModDirLabel.Name = "SelectModDirLabel";
            this.SelectModDirLabel.Size = new System.Drawing.Size(166, 19);
            this.SelectModDirLabel.TabIndex = 9;
            this.SelectModDirLabel.Text = "Modordner auswählen";
            // 
            // SelectModDirListbox
            // 
            this.SelectModDirListbox.FormattingEnabled = true;
            this.SelectModDirListbox.Location = new System.Drawing.Point(22, 264);
            this.SelectModDirListbox.Name = "SelectModDirListbox";
            this.SelectModDirListbox.Size = new System.Drawing.Size(238, 186);
            this.SelectModDirListbox.TabIndex = 10;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(581, 405);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(161, 45);
            this.StartGameButton.TabIndex = 11;
            this.StartGameButton.Text = "Spiel starten";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ModDirExtCheckbox
            // 
            this.ModDirExtCheckbox.AutoSize = true;
            this.ModDirExtCheckbox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModDirExtCheckbox.ForeColor = System.Drawing.SystemColors.Window;
            this.ModDirExtCheckbox.Location = new System.Drawing.Point(22, 79);
            this.ModDirExtCheckbox.Name = "ModDirExtCheckbox";
            this.ModDirExtCheckbox.Size = new System.Drawing.Size(227, 23);
            this.ModDirExtCheckbox.TabIndex = 14;
            this.ModDirExtCheckbox.Text = "Modordner extern speichern";
            this.ModDirExtCheckbox.UseVisualStyleBackColor = true;
            this.ModDirExtCheckbox.CheckedChanged += new System.EventHandler(this.ModDirExtCheckbox_CheckedChanged);
            // 
            // openSelectedModDirButton
            // 
            this.openSelectedModDirButton.Location = new System.Drawing.Point(275, 264);
            this.openSelectedModDirButton.Name = "openSelectedModDirButton";
            this.openSelectedModDirButton.Size = new System.Drawing.Size(161, 20);
            this.openSelectedModDirButton.TabIndex = 15;
            this.openSelectedModDirButton.Text = "Modordner öffnen";
            this.openSelectedModDirButton.UseVisualStyleBackColor = true;
            this.openSelectedModDirButton.Click += new System.EventHandler(this.openSelectedModDirButton_Click);
            // 
            // StartProgressBar
            // 
            this.StartProgressBar.Location = new System.Drawing.Point(275, 362);
            this.StartProgressBar.Name = "StartProgressBar";
            this.StartProgressBar.Size = new System.Drawing.Size(467, 27);
            this.StartProgressBar.TabIndex = 16;
            // 
            // deleteModDir
            // 
            this.deleteModDir.Location = new System.Drawing.Point(275, 430);
            this.deleteModDir.Name = "deleteModDir";
            this.deleteModDir.Size = new System.Drawing.Size(161, 20);
            this.deleteModDir.TabIndex = 17;
            this.deleteModDir.Text = "Modordner löschen";
            this.deleteModDir.UseVisualStyleBackColor = true;
            this.deleteModDir.Click += new System.EventHandler(this.deleteModDir_Click);
            // 
            // ModDirManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.deleteModDir);
            this.Controls.Add(this.StartProgressBar);
            this.Controls.Add(this.openSelectedModDirButton);
            this.Controls.Add(this.ModDirExtCheckbox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.SelectModDirListbox);
            this.Controls.Add(this.SelectModDirLabel);
            this.Controls.Add(this.CreateNewModDirButton);
            this.Controls.Add(this.CreateNewModDirTextbox);
            this.Controls.Add(this.CreateNewModDirLabel);
            this.Controls.Add(this.ModDirPathButton);
            this.Controls.Add(this.ModDirPathTextbox);
            this.Controls.Add(this.ModDirPathLabel);
            this.Controls.Add(this.GamePathButton);
            this.Controls.Add(this.GamePathTextbox);
            this.Controls.Add(this.GamePathLabel);
            this.Name = "ModDirManagerForm";
            this.Text = "LS19 Modordner Auswahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GamePathLabel;
        private System.Windows.Forms.TextBox GamePathTextbox;
        private System.Windows.Forms.Button GamePathButton;
        private System.Windows.Forms.Button ModDirPathButton;
        private System.Windows.Forms.TextBox ModDirPathTextbox;
        private System.Windows.Forms.Label ModDirPathLabel;
        private System.Windows.Forms.Button CreateNewModDirButton;
        private System.Windows.Forms.TextBox CreateNewModDirTextbox;
        private System.Windows.Forms.Label CreateNewModDirLabel;
        private System.Windows.Forms.Label SelectModDirLabel;
        private System.Windows.Forms.ListBox SelectModDirListbox;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.CheckBox ModDirExtCheckbox;
        private System.Windows.Forms.Button openSelectedModDirButton;
        private System.Windows.Forms.ProgressBar StartProgressBar;
        private System.Windows.Forms.Button deleteModDir;
    }
}

