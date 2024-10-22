using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace photoApp
{
    public partial class HomePage : Form
    {
        private int counter = 1;
        private string imgDestination = "";
        private string imgLocation = "";
        private string outputFileName = "";
        private string WatermarkFilePath = "";

        public HomePage()
        {
            InitializeComponent();
        }

        private void SelectImages_Click(object sender, EventArgs e)
        {
            var selectDirectory = new FolderBrowserDialog();
            selectDirectory.RootFolder = Environment.SpecialFolder.Desktop;
            selectDirectory.Description = "Select your folder";
            selectDirectory.ShowNewFolderButton = true;
            ListPhotos.Items.Clear();

            if (selectDirectory.ShowDialog() == DialogResult.OK)
            {
                SourcePath.Text = selectDirectory.SelectedPath;
                var dinfo = new DirectoryInfo(selectDirectory.SelectedPath);
                var Files = dinfo.GetFiles("*.jpg");
                foreach (var file in Files) ListPhotos.Items.Add(file.Name);
            }
        }

        private void ListPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgLocation = SourcePath.Text + "/" + ListPhotos.SelectedItem;
            ImagePrevious.SizeMode = PictureBoxSizeMode.Zoom;
            ImageAfter.SizeMode = PictureBoxSizeMode.Zoom;
            using (var tmpBitmap = new Bitmap(imgLocation))
            {
                ImagePrevious.Image = new Bitmap(tmpBitmap);
                ImageAfter.Image = new Bitmap(tmpBitmap);
            }
        }

        private void SelectWatermark_Click(object sender, EventArgs e)
        {
            var ChooseWatermark = new OpenFileDialog();
            ChooseWatermark.Filter = "Png Files (*.png)|*.png|All Files (*.*)|*.*";
            ChooseWatermark.FilterIndex = 1;
            ChooseWatermark.InitialDirectory = "c:\\";
            ChooseWatermark.RestoreDirectory = false;

            if (ChooseWatermark.ShowDialog() == DialogResult.OK)
            {
                WatermarkFilePath = ChooseWatermark.FileName;
                WatermarkPreview.SizeMode = PictureBoxSizeMode.Zoom;
                using (var tmpBitmap = new Bitmap(WatermarkFilePath))
                {
                    WatermarkPreview.Image = new Bitmap(tmpBitmap);
                }
                WatermarkPath.Text = WatermarkFilePath;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ApplyWatermark.Checked)
            {
                var imageFolderPath = SourcePath.Text;
                var outputFolderPath = DestinationPath.Text;
                var watermarkImage = WatermarkFilePath;

                ImageAfter.SizeMode = PictureBoxSizeMode.Zoom;

                if (Directory.Exists(imageFolderPath) && Directory.Exists(outputFolderPath))
                {
                    var imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly);

                    foreach (var imgLocation in imageFiles)
                        try
                        {
                            using (var image = Image.FromFile(imgLocation))
                            {
                                using (var g = Graphics.FromImage(image))
                                {
                                    var watermark = Image.FromFile(watermarkImage);
                                    g.DrawImage(watermark, new Point(0, 0));
                                    outputFileName = Path.Combine(outputFolderPath, "watermarkadded-" +
                                        Path.GetFileName(imgLocation));
                                    while (File.Exists(imgDestination))
                                    {
                                        var outputFileName = Path.Combine(outputFolderPath,
                                            "watermarkadded-" + Path.GetFileName(imgLocation) + counter++);
                                    }
                                    image.Save(outputFileName);
                                    ImageAfter.Image = new Bitmap(outputFileName);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing image: " + imgLocation + "\n" + ex.Message);
                        }
                }
                else
                {
                    MessageBox.Show("Please ensure the image folder and output folder exist.");
                }
            }
            else
            {
                var imageFolderPath = SourcePath.Text;
                var outputFolderPath = DestinationPath.Text;
                if (Directory.Exists(imageFolderPath) && Directory.Exists(outputFolderPath))
                {
                    var imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly);

                    foreach (var imgLocation in imageFiles)
                        try
                        {
                            var destinationFileName = Path.Combine(outputFolderPath, Path.GetFileName(imgLocation));
                            File.Move(imgLocation, destinationFileName);
                            ListPhotos.Items.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error moving image: " + imgLocation + "\n" + ex.Message);
                        }
                }
                else
                {
                    MessageBox.Show("Please ensure the image folder and output folder exist.");
                }
            }
        }

        private void ChooseDestination_Click(object sender, EventArgs e)
        {
            var SelectDestination = new FolderBrowserDialog();
            SelectDestination.RootFolder = Environment.SpecialFolder.Desktop;
            SelectDestination.ShowNewFolderButton = true;
            if (SelectDestination.ShowDialog() == DialogResult.OK)
                DestinationPath.Text = SelectDestination.SelectedPath;
        }
    }
}