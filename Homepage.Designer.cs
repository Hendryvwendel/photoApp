namespace photoApp
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.SelectImages = new System.Windows.Forms.Button();
            this.ListPhotos = new System.Windows.Forms.ListBox();
            this.ImagePrevious = new System.Windows.Forms.PictureBox();
            this.ImageAfter = new System.Windows.Forms.PictureBox();
            this.SelectWatermark = new System.Windows.Forms.Button();
            this.WatermarkPath = new System.Windows.Forms.TextBox();
            this.ApplyWatermarkCheck = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.WatermarkPreview = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripHomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripAfbeeldingenButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkPreview)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(188, 51);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(500, 22);
            this.SourcePath.TabIndex = 0;
            // 
            // SelectImages
            // 
            this.SelectImages.Location = new System.Drawing.Point(32, 51);
            this.SelectImages.Name = "SelectImages";
            this.SelectImages.Size = new System.Drawing.Size(132, 23);
            this.SelectImages.TabIndex = 1;
            this.SelectImages.Text = "Select Images";
            this.SelectImages.UseVisualStyleBackColor = true;
            this.SelectImages.Click += new System.EventHandler(this.SelectImages_Click);
            // 
            // ListPhotos
            // 
            this.ListPhotos.FormattingEnabled = true;
            this.ListPhotos.ItemHeight = 16;
            this.ListPhotos.Location = new System.Drawing.Point(32, 89);
            this.ListPhotos.Name = "ListPhotos";
            this.ListPhotos.Size = new System.Drawing.Size(315, 932);
            this.ListPhotos.TabIndex = 4;
            this.ListPhotos.SelectedIndexChanged += new System.EventHandler(this.ListPhotos_SelectedIndexChanged);
            // 
            // ImagePrevious
            // 
            this.ImagePrevious.Location = new System.Drawing.Point(385, 89);
            this.ImagePrevious.Name = "ImagePrevious";
            this.ImagePrevious.Size = new System.Drawing.Size(700, 700);
            this.ImagePrevious.TabIndex = 5;
            this.ImagePrevious.TabStop = false;
            // 
            // ImageAfter
            // 
            this.ImageAfter.Location = new System.Drawing.Point(1139, 89);
            this.ImageAfter.Name = "ImageAfter";
            this.ImageAfter.Size = new System.Drawing.Size(700, 700);
            this.ImageAfter.TabIndex = 6;
            this.ImageAfter.TabStop = false;
            // 
            // SelectWatermark
            // 
            this.SelectWatermark.Location = new System.Drawing.Point(1146, 823);
            this.SelectWatermark.Name = "SelectWatermark";
            this.SelectWatermark.Size = new System.Drawing.Size(140, 23);
            this.SelectWatermark.TabIndex = 7;
            this.SelectWatermark.Text = "Select Watermark";
            this.SelectWatermark.UseVisualStyleBackColor = true;
            this.SelectWatermark.Click += new System.EventHandler(this.SelectWatermark_Click);
            // 
            // WatermarkPath
            // 
            this.WatermarkPath.Location = new System.Drawing.Point(1292, 823);
            this.WatermarkPath.Name = "WatermarkPath";
            this.WatermarkPath.Size = new System.Drawing.Size(547, 22);
            this.WatermarkPath.TabIndex = 8;
            // 
            // ApplyWatermarkCheck
            // 
            this.ApplyWatermarkCheck.AutoSize = true;
            this.ApplyWatermarkCheck.Location = new System.Drawing.Point(1153, 861);
            this.ApplyWatermarkCheck.Name = "ApplyWatermarkCheck";
            this.ApplyWatermarkCheck.Size = new System.Drawing.Size(130, 20);
            this.ApplyWatermarkCheck.TabIndex = 9;
            this.ApplyWatermarkCheck.Text = "Apply Watermark";
            this.ApplyWatermarkCheck.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1636, 904);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(203, 72);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // WatermarkPreview
            // 
            this.WatermarkPreview.Location = new System.Drawing.Point(850, 850);
            this.WatermarkPreview.Name = "WatermarkPreview";
            this.WatermarkPreview.Size = new System.Drawing.Size(252, 180);
            this.WatermarkPreview.TabIndex = 11;
            this.WatermarkPreview.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHomeButton,
            this.toolStripAfbeeldingenButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1902, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripHomeButton
            // 
            this.toolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHomeButton.Name = "toolStripHomeButton";
            this.toolStripHomeButton.Size = new System.Drawing.Size(44, 22);
            this.toolStripHomeButton.Text = "Home";
            this.toolStripHomeButton.Click += new System.EventHandler(this.toolStripHomeButton_Click);
            // 
            // toolStripAfbeeldingenButton
            // 
            this.toolStripAfbeeldingenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAfbeeldingenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAfbeeldingenButton.Name = "toolStripAfbeeldingenButton";
            this.toolStripAfbeeldingenButton.Size = new System.Drawing.Size(148, 22);
            this.toolStripAfbeeldingenButton.Text = "Opgeslagen Afbeeldingen";
            this.toolStripAfbeeldingenButton.Click += new System.EventHandler(this.toolStripAfbeeldingenButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WatermarkPreview);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ApplyWatermarkCheck);
            this.Controls.Add(this.WatermarkPath);
            this.Controls.Add(this.SelectWatermark);
            this.Controls.Add(this.ImageAfter);
            this.Controls.Add(this.ImagePrevious);
            this.Controls.Add(this.ListPhotos);
            this.Controls.Add(this.SelectImages);
            this.Controls.Add(this.SourcePath);
            this.Name = "HomePage";
            this.Text = "PhotoApp";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkPreview)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Button SelectImages;
        private System.Windows.Forms.ListBox ListPhotos;
        private System.Windows.Forms.PictureBox ImagePrevious;
        private System.Windows.Forms.PictureBox ImageAfter;
        private System.Windows.Forms.Button SelectWatermark;
        private System.Windows.Forms.TextBox WatermarkPath;
        private System.Windows.Forms.CheckBox ApplyWatermarkCheck;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox WatermarkPreview;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripHomeButton;
        private System.Windows.Forms.ToolStripButton toolStripAfbeeldingenButton;
    }
}

