namespace Focus
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDateiname = new System.Windows.Forms.Label();
            this.bunifuFlatButtonSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.labelBreite = new System.Windows.Forms.Label();
            this.labelHöhe = new System.Windows.Forms.Label();
            this.labelHöhePX = new System.Windows.Forms.Label();
            this.labelBreitePX = new System.Windows.Forms.Label();
            this.labelErstelldatum = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonResize = new System.Windows.Forms.Button();
            this.panelAuflösung = new System.Windows.Forms.Panel();
            this.buttonResetSize = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBoxLoadingGIF = new System.Windows.Forms.PictureBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.labelContrast = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelGamma = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.checkBoxOilPainting = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelAuflösung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(703, 750);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(96, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // labelDateiname
            // 
            this.labelDateiname.AutoSize = true;
            this.labelDateiname.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateiname.Location = new System.Drawing.Point(6, 7);
            this.labelDateiname.Name = "labelDateiname";
            this.labelDateiname.Size = new System.Drawing.Size(84, 21);
            this.labelDateiname.TabIndex = 2;
            this.labelDateiname.Text = "Dateiname";
            // 
            // bunifuFlatButtonSave
            // 
            this.bunifuFlatButtonSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonSave.BorderRadius = 0;
            this.bunifuFlatButtonSave.ButtonText = "Speichern";
            this.bunifuFlatButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonSave.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonSave.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonSave.Iconimage")));
            this.bunifuFlatButtonSave.Iconimage_right = null;
            this.bunifuFlatButtonSave.Iconimage_right_Selected = null;
            this.bunifuFlatButtonSave.Iconimage_Selected = null;
            this.bunifuFlatButtonSave.IconMarginLeft = 0;
            this.bunifuFlatButtonSave.IconMarginRight = 0;
            this.bunifuFlatButtonSave.IconRightVisible = true;
            this.bunifuFlatButtonSave.IconRightZoom = 0D;
            this.bunifuFlatButtonSave.IconVisible = true;
            this.bunifuFlatButtonSave.IconZoom = 90D;
            this.bunifuFlatButtonSave.IsTab = false;
            this.bunifuFlatButtonSave.Location = new System.Drawing.Point(828, 730);
            this.bunifuFlatButtonSave.Name = "bunifuFlatButtonSave";
            this.bunifuFlatButtonSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonSave.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.selected = false;
            this.bunifuFlatButtonSave.Size = new System.Drawing.Size(157, 32);
            this.bunifuFlatButtonSave.TabIndex = 3;
            this.bunifuFlatButtonSave.Text = "Speichern";
            this.bunifuFlatButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonSave.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonSave.Click += new System.EventHandler(this.bunifuFlatButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.White;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(721, 730);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(101, 32);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Abbrechen";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelBreite
            // 
            this.labelBreite.AutoSize = true;
            this.labelBreite.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreite.Location = new System.Drawing.Point(6, 63);
            this.labelBreite.Name = "labelBreite";
            this.labelBreite.Size = new System.Drawing.Size(49, 21);
            this.labelBreite.TabIndex = 7;
            this.labelBreite.Text = "Breite";
            // 
            // labelHöhe
            // 
            this.labelHöhe.AutoSize = true;
            this.labelHöhe.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHöhe.Location = new System.Drawing.Point(6, 42);
            this.labelHöhe.Name = "labelHöhe";
            this.labelHöhe.Size = new System.Drawing.Size(47, 21);
            this.labelHöhe.TabIndex = 8;
            this.labelHöhe.Text = "Höhe";
            // 
            // labelHöhePX
            // 
            this.labelHöhePX.AutoSize = true;
            this.labelHöhePX.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHöhePX.Location = new System.Drawing.Point(72, 42);
            this.labelHöhePX.Name = "labelHöhePX";
            this.labelHöhePX.Size = new System.Drawing.Size(54, 21);
            this.labelHöhePX.TabIndex = 9;
            this.labelHöhePX.Text = "720 px";
            // 
            // labelBreitePX
            // 
            this.labelBreitePX.AutoSize = true;
            this.labelBreitePX.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreitePX.Location = new System.Drawing.Point(72, 63);
            this.labelBreitePX.Name = "labelBreitePX";
            this.labelBreitePX.Size = new System.Drawing.Size(60, 21);
            this.labelBreitePX.TabIndex = 10;
            this.labelBreitePX.Text = "1280 px";
            // 
            // labelErstelldatum
            // 
            this.labelErstelldatum.AutoSize = true;
            this.labelErstelldatum.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErstelldatum.Location = new System.Drawing.Point(6, 87);
            this.labelErstelldatum.Name = "labelErstelldatum";
            this.labelErstelldatum.Size = new System.Drawing.Size(95, 21);
            this.labelErstelldatum.TabIndex = 11;
            this.labelErstelldatum.Text = "Erstelldatum";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(5, 6);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(84, 21);
            this.labelHeight.TabIndex = 13;
            this.labelHeight.Text = "Höhe in px";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(5, 27);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(86, 21);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "Breite in px";
            // 
            // buttonResize
            // 
            this.buttonResize.BackColor = System.Drawing.Color.White;
            this.buttonResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.Location = new System.Drawing.Point(5, 57);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(254, 27);
            this.buttonResize.TabIndex = 27;
            this.buttonResize.Text = "Übernehmen";
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // panelAuflösung
            // 
            this.panelAuflösung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAuflösung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuflösung.Controls.Add(this.buttonResetSize);
            this.panelAuflösung.Controls.Add(this.numericUpDownWidth);
            this.panelAuflösung.Controls.Add(this.numericUpDownHeight);
            this.panelAuflösung.Controls.Add(this.buttonResize);
            this.panelAuflösung.Controls.Add(this.labelHeight);
            this.panelAuflösung.Controls.Add(this.labelWidth);
            this.panelAuflösung.Location = new System.Drawing.Point(721, 134);
            this.panelAuflösung.Name = "panelAuflösung";
            this.panelAuflösung.Size = new System.Drawing.Size(264, 93);
            this.panelAuflösung.TabIndex = 30;
            // 
            // buttonResetSize
            // 
            this.buttonResetSize.BackColor = System.Drawing.Color.White;
            this.buttonResetSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetSize.Location = new System.Drawing.Point(151, 27);
            this.buttonResetSize.Name = "buttonResetSize";
            this.buttonResetSize.Size = new System.Drawing.Size(107, 25);
            this.buttonResetSize.TabIndex = 30;
            this.buttonResetSize.Text = "Reset";
            this.buttonResetSize.UseVisualStyleBackColor = false;
            this.buttonResetSize.Click += new System.EventHandler(this.buttonResetSize_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(95, 31);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownWidth.TabIndex = 29;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(95, 7);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownHeight.TabIndex = 28;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelErstelldatum);
            this.panelInfo.Controls.Add(this.textBoxName);
            this.panelInfo.Controls.Add(this.labelBreite);
            this.panelInfo.Controls.Add(this.labelDateiname);
            this.panelInfo.Controls.Add(this.labelHöhe);
            this.panelInfo.Controls.Add(this.labelHöhePX);
            this.panelInfo.Controls.Add(this.labelBreitePX);
            this.panelInfo.Location = new System.Drawing.Point(721, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(264, 116);
            this.panelInfo.TabIndex = 31;
            // 
            // pictureBoxLoadingGIF
            // 
            this.pictureBoxLoadingGIF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoadingGIF.Image = global::Focus.Properties.Resources.Ellipsis;
            this.pictureBoxLoadingGIF.Location = new System.Drawing.Point(721, 675);
            this.pictureBoxLoadingGIF.Name = "pictureBoxLoadingGIF";
            this.pictureBoxLoadingGIF.Size = new System.Drawing.Size(264, 52);
            this.pictureBoxLoadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoadingGIF.TabIndex = 32;
            this.pictureBoxLoadingGIF.TabStop = false;
            this.pictureBoxLoadingGIF.Visible = false;
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarContrast.Location = new System.Drawing.Point(721, 256);
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(264, 45);
            this.trackBarContrast.TabIndex = 33;
            this.trackBarContrast.Value = 1;
            this.trackBarContrast.Scroll += new System.EventHandler(this.Change);
            // 
            // labelContrast
            // 
            this.labelContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrast.AutoSize = true;
            this.labelContrast.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrast.Location = new System.Drawing.Point(721, 232);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(67, 21);
            this.labelContrast.TabIndex = 12;
            this.labelContrast.Text = "Kontrast";
            // 
            // labelBrightness
            // 
            this.labelBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrightness.Location = new System.Drawing.Point(721, 307);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(75, 21);
            this.labelBrightness.TabIndex = 34;
            this.labelBrightness.Text = "Helligkeit";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBrightness.Location = new System.Drawing.Point(721, 331);
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(264, 45);
            this.trackBarBrightness.TabIndex = 35;
            this.trackBarBrightness.Value = 1;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.Change);
            // 
            // labelGamma
            // 
            this.labelGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamma.Location = new System.Drawing.Point(721, 381);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(63, 21);
            this.labelGamma.TabIndex = 36;
            this.labelGamma.Text = "Gamma";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.Location = new System.Drawing.Point(721, 405);
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(264, 45);
            this.trackBarGamma.TabIndex = 37;
            this.trackBarGamma.Value = 1;
            this.trackBarGamma.Scroll += new System.EventHandler(this.Change);
            // 
            // checkBoxOilPainting
            // 
            this.checkBoxOilPainting.AutoSize = true;
            this.checkBoxOilPainting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOilPainting.Location = new System.Drawing.Point(721, 457);
            this.checkBoxOilPainting.Name = "checkBoxOilPainting";
            this.checkBoxOilPainting.Size = new System.Drawing.Size(91, 21);
            this.checkBoxOilPainting.TabIndex = 38;
            this.checkBoxOilPainting.Text = "Ölgemälde";
            this.checkBoxOilPainting.UseVisualStyleBackColor = true;
            this.checkBoxOilPainting.CheckedChanged += new System.EventHandler(this.Change);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 774);
            this.Controls.Add(this.checkBoxOilPainting);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.trackBarGamma);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.labelContrast);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.pictureBoxLoadingGIF);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelAuflösung);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.bunifuFlatButtonSave);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "Editor";
            this.ShowInTaskbar = false;
            this.Text = "Focus | Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelAuflösung.ResumeLayout(false);
            this.panelAuflösung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDateiname;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label labelBreite;
        private System.Windows.Forms.Label labelHöhe;
        private System.Windows.Forms.Label labelHöhePX;
        private System.Windows.Forms.Label labelBreitePX;
        private System.Windows.Forms.Label labelErstelldatum;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Panel panelAuflösung;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Button buttonResetSize;
        private System.Windows.Forms.PictureBox pictureBoxLoadingGIF;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.CheckBox checkBoxOilPainting;
    }
}