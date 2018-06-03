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
            this.panelPreview = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonOpenInEditor = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelRecently = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowserDialogMain = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogSpeicherort = new System.Windows.Forms.FolderBrowserDialog();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelPictures
            // 
            this.flowLayoutPanelPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelPictures.AutoScroll = true;
            this.flowLayoutPanelPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPictures.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
            this.flowLayoutPanelPictures.Size = new System.Drawing.Size(282, 662);
            this.flowLayoutPanelPictures.TabIndex = 0;
            this.flowLayoutPanelPictures.Visible = false;
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.buttonStart);
            this.panelPreview.Controls.Add(this.textBoxName);
            this.panelPreview.Controls.Add(this.ButtonSave);
            this.panelPreview.Controls.Add(this.buttonOpenInEditor);
            this.panelPreview.Controls.Add(this.pictureBoxPreview);
            this.panelPreview.Location = new System.Drawing.Point(295, 7);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(661, 662);
            this.panelPreview.TabIndex = 1;
            this.panelPreview.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(291, 39);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(345, 630);
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
            this.ButtonSave.Location = new System.Drawing.Point(527, 630);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ButtonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonSave.selected = false;
            this.ButtonSave.Size = new System.Drawing.Size(129, 27);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Speichern";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonOpenInEditor.Location = new System.Drawing.Point(210, 630);
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
            this.pictureBoxPreview.Size = new System.Drawing.Size(658, 609);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            // 
            // flowLayoutPanelRecently
            // 
            this.flowLayoutPanelRecently.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRecently.AutoScroll = true;
            this.flowLayoutPanelRecently.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelRecently.Location = new System.Drawing.Point(958, 7);
            this.flowLayoutPanelRecently.Name = "flowLayoutPanelRecently";
            this.flowLayoutPanelRecently.Size = new System.Drawing.Size(167, 662);
            this.flowLayoutPanelRecently.TabIndex = 3;
            this.flowLayoutPanelRecently.Visible = false;
            // 
            // folderBrowserDialogMain
            // 
            this.folderBrowserDialogMain.Description = "wählen sie den Ordner mit den Bildern aus";
            // 
            // folderBrowserDialogSpeicherort
            // 
            this.folderBrowserDialogSpeicherort.Description = "Wählen sie einen Speicherort aus";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(10)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1131, 675);
            this.Controls.Add(this.flowLayoutPanelRecently);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.flowLayoutPanelPictures);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Focus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictures;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecently;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMain;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSpeicherort;
        private System.Windows.Forms.Button buttonOpenInEditor;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonStart;
    }
}

