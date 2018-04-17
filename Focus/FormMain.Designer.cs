namespace Focus
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowLayoutPanelPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonChooseDirectory = new MonoFlat.Class1.MonoFlat_Button();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonOpenInEditor = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzeichnisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BilderverzeichnisWählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeicherortWählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelRecently = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonChooseSpeicherort = new MonoFlat.Class1.MonoFlat_Button();
            this.folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogSpeicherort = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPictures.SuspendLayout();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.flowLayoutPanelRecently.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPictures
            // 
            this.flowLayoutPanelPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelPictures.AutoScroll = true;
            this.flowLayoutPanelPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPictures.Controls.Add(this.ButtonChooseDirectory);
            this.flowLayoutPanelPictures.Location = new System.Drawing.Point(13, 27);
            this.flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
            this.flowLayoutPanelPictures.Size = new System.Drawing.Size(282, 489);
            this.flowLayoutPanelPictures.TabIndex = 0;
            // 
            // ButtonChooseDirectory
            // 
            this.ButtonChooseDirectory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseDirectory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonChooseDirectory.Image = null;
            this.ButtonChooseDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChooseDirectory.Location = new System.Drawing.Point(3, 3);
            this.ButtonChooseDirectory.Name = "ButtonChooseDirectory";
            this.ButtonChooseDirectory.Size = new System.Drawing.Size(274, 41);
            this.ButtonChooseDirectory.TabIndex = 1;
            this.ButtonChooseDirectory.Text = "Ordner wählen";
            this.ButtonChooseDirectory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ButtonChooseDirectory.Click += new System.EventHandler(this.ButtonChooseDirectory_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.textBoxName);
            this.panelPreview.Controls.Add(this.ButtonSave);
            this.panelPreview.Controls.Add(this.buttonOpenInEditor);
            this.panelPreview.Controls.Add(this.pictureBoxPreview);
            this.panelPreview.Location = new System.Drawing.Point(301, 27);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(645, 489);
            this.panelPreview.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(329, 457);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 27);
            this.textBoxName.TabIndex = 6;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSave.BorderRadius = 0;
            this.ButtonSave.ButtonText = "Speichern";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Iconimage")));
            this.ButtonSave.Iconimage_right = null;
            this.ButtonSave.Iconimage_right_Selected = null;
            this.ButtonSave.Iconimage_Selected = null;
            this.ButtonSave.IconMarginLeft = 0;
            this.ButtonSave.IconMarginRight = 0;
            this.ButtonSave.IconRightVisible = true;
            this.ButtonSave.IconRightZoom = 0D;
            this.ButtonSave.IconVisible = true;
            this.ButtonSave.IconZoom = 90D;
            this.ButtonSave.IsTab = false;
            this.ButtonSave.Location = new System.Drawing.Point(511, 457);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ButtonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonSave.selected = false;
            this.ButtonSave.Size = new System.Drawing.Size(129, 27);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Speichern";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Textcolor = System.Drawing.Color.White;
            this.ButtonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonOpenInEditor
            // 
            this.buttonOpenInEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenInEditor.BackColor = System.Drawing.Color.White;
            this.buttonOpenInEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenInEditor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenInEditor.Location = new System.Drawing.Point(194, 457);
            this.buttonOpenInEditor.Name = "buttonOpenInEditor";
            this.buttonOpenInEditor.Size = new System.Drawing.Size(129, 27);
            this.buttonOpenInEditor.TabIndex = 3;
            this.buttonOpenInEditor.Text = "Bild im Editor öffnen";
            this.buttonOpenInEditor.UseVisualStyleBackColor = false;
            this.buttonOpenInEditor.Click += new System.EventHandler(this.buttonOpenInEditor_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(645, 456);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.verzeichnisToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1121, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.startToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // verzeichnisToolStripMenuItem
            // 
            this.verzeichnisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BilderverzeichnisWählenToolStripMenuItem,
            this.SpeicherortWählenToolStripMenuItem});
            this.verzeichnisToolStripMenuItem.Name = "verzeichnisToolStripMenuItem";
            this.verzeichnisToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.verzeichnisToolStripMenuItem.Text = "Verzeichnis";
            // 
            // BilderverzeichnisWählenToolStripMenuItem
            // 
            this.BilderverzeichnisWählenToolStripMenuItem.Name = "BilderverzeichnisWählenToolStripMenuItem";
            this.BilderverzeichnisWählenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.BilderverzeichnisWählenToolStripMenuItem.Text = "Ursprungsverzeichnis wählen";
            this.BilderverzeichnisWählenToolStripMenuItem.Click += new System.EventHandler(this.UrsprungsverzeichnisWählenToolStripMenuItem_Click);
            // 
            // SpeicherortWählenToolStripMenuItem
            // 
            this.SpeicherortWählenToolStripMenuItem.Name = "SpeicherortWählenToolStripMenuItem";
            this.SpeicherortWählenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.SpeicherortWählenToolStripMenuItem.Text = "Speicherort wählen";
            this.SpeicherortWählenToolStripMenuItem.Click += new System.EventHandler(this.SpeicherortWählenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // flowLayoutPanelRecently
            // 
            this.flowLayoutPanelRecently.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRecently.AutoScroll = true;
            this.flowLayoutPanelRecently.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelRecently.Controls.Add(this.ButtonChooseSpeicherort);
            this.flowLayoutPanelRecently.Location = new System.Drawing.Point(952, 27);
            this.flowLayoutPanelRecently.Name = "flowLayoutPanelRecently";
            this.flowLayoutPanelRecently.Size = new System.Drawing.Size(157, 352);
            this.flowLayoutPanelRecently.TabIndex = 3;
            // 
            // ButtonChooseSpeicherort
            // 
            this.ButtonChooseSpeicherort.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseSpeicherort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ButtonChooseSpeicherort.Image = null;
            this.ButtonChooseSpeicherort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChooseSpeicherort.Location = new System.Drawing.Point(3, 3);
            this.ButtonChooseSpeicherort.Name = "ButtonChooseSpeicherort";
            this.ButtonChooseSpeicherort.Size = new System.Drawing.Size(149, 41);
            this.ButtonChooseSpeicherort.TabIndex = 2;
            this.ButtonChooseSpeicherort.Text = "Speicherort wählen";
            this.ButtonChooseSpeicherort.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ButtonChooseSpeicherort.Click += new System.EventHandler(this.ButtonChooseSpeicherort_Click);
            // 
            // folderBrowserDialogMain
            // 
            this.folderBrowserDialogMain.Description = "wählen sie den Ordner mit den Bildern aus";
            // 
            // folderBrowserDialogSpeicherort
            // 
            this.folderBrowserDialogSpeicherort.Description = "Wählen sie einen Speicherort aus";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(952, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 131);
            this.panel1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1121, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelRecently);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.flowLayoutPanelPictures);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Focus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelPictures.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.flowLayoutPanelRecently.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictures;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecently;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private MonoFlat.Class1.MonoFlat_Button ButtonChooseDirectory;
        private System.Windows.Forms.ToolStripMenuItem verzeichnisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeicherortWählenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BilderverzeichnisWählenToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSpeicherort;
        private MonoFlat.Class1.MonoFlat_Button ButtonChooseSpeicherort;
        private System.Windows.Forms.Button buttonOpenInEditor;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
    }
}

