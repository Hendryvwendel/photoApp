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
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.SelectImages = new System.Windows.Forms.Button();
            this.ChooseDestination = new System.Windows.Forms.Button();
            this.DestinationPath = new System.Windows.Forms.TextBox();
            this.ListPhotos = new System.Windows.Forms.ListBox();
            this.ImagePrevious = new System.Windows.Forms.PictureBox();
            this.ImageAfter = new System.Windows.Forms.PictureBox();
            this.SelectWatermark = new System.Windows.Forms.Button();
            this.WatermarkPath = new System.Windows.Forms.TextBox();
            this.ApplyWatermark = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.WatermarkPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(188, 23);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(500, 22);
            this.SourcePath.TabIndex = 0;
            // 
            // SelectImages
            // 
            this.SelectImages.Location = new System.Drawing.Point(32, 23);
            this.SelectImages.Name = "SelectImages";
            this.SelectImages.Size = new System.Drawing.Size(132, 23);
            this.SelectImages.TabIndex = 1;
            this.SelectImages.Text = "Select Images";
            this.SelectImages.UseVisualStyleBackColor = true;
            this.SelectImages.Click += new System.EventHandler(this.SelectImages_Click);
            // 
            // ChooseDestination
            // 
            this.ChooseDestination.Location = new System.Drawing.Point(733, 24);
            this.ChooseDestination.Name = "ChooseDestination";
            this.ChooseDestination.Size = new System.Drawing.Size(159, 23);
            this.ChooseDestination.TabIndex = 2;
            this.ChooseDestination.Text = "Choose Destination";
            this.ChooseDestination.UseVisualStyleBackColor = true;
            this.ChooseDestination.Click += new System.EventHandler(this.ChooseDestination_Click);
            // 
            // DestinationPath
            // 
            this.DestinationPath.Location = new System.Drawing.Point(908, 24);
            this.DestinationPath.Name = "DestinationPath";
            this.DestinationPath.Size = new System.Drawing.Size(500, 22);
            this.DestinationPath.TabIndex = 3;
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
            // ApplyWatermark
            // 
            this.ApplyWatermark.AutoSize = true;
            this.ApplyWatermark.Location = new System.Drawing.Point(1153, 861);
            this.ApplyWatermark.Name = "ApplyWatermark";
            this.ApplyWatermark.Size = new System.Drawing.Size(131, 20);
            this.ApplyWatermark.TabIndex = 9;
            this.ApplyWatermark.Text = "Apply Watermark";
            this.ApplyWatermark.UseVisualStyleBackColor = true;
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
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.WatermarkPreview);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ApplyWatermark);
            this.Controls.Add(this.WatermarkPath);
            this.Controls.Add(this.SelectWatermark);
            this.Controls.Add(this.ImageAfter);
            this.Controls.Add(this.ImagePrevious);
            this.Controls.Add(this.ListPhotos);
            this.Controls.Add(this.DestinationPath);
            this.Controls.Add(this.ChooseDestination);
            this.Controls.Add(this.SelectImages);
            this.Controls.Add(this.SourcePath);
            this.Name = "HomePage";
            this.Text = "PhotoApp";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Button SelectImages;
        private System.Windows.Forms.Button ChooseDestination;
        private System.Windows.Forms.TextBox DestinationPath;
        private System.Windows.Forms.ListBox ListPhotos;
        private System.Windows.Forms.PictureBox ImagePrevious;
        private System.Windows.Forms.PictureBox ImageAfter;
        private System.Windows.Forms.Button SelectWatermark;
        private System.Windows.Forms.TextBox WatermarkPath;
        private System.Windows.Forms.CheckBox ApplyWatermark;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox WatermarkPreview;
    }
}

