using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace photoApp
{
    public partial class HomePage : Form
    {
        private string WatermarkFilePath;
        private string imgLocation;
        public HomePage()
        {
            InitializeComponent();
        }

        private void SelectImages_Click(object sender, EventArgs e)
        {
            //Open up a new file explorer window to open a directory
            FolderBrowserDialog SelectDirectory = new FolderBrowserDialog();
            //Set the root folder
            SelectDirectory.RootFolder = Environment.SpecialFolder.Desktop;
            //Show the description in the explorer window
            SelectDirectory.Description = "Select your folder";
            //shows the new folder button
            SelectDirectory.ShowNewFolderButton = true;

            //clear the previous files in the list
            ListPhotos.Items.Clear();



            if (SelectDirectory.ShowDialog() == DialogResult.OK)
            {
                //set the selected directory in the textbox path
                SourcePath.Text = SelectDirectory.SelectedPath;

                //put all the files in the directory
                DirectoryInfo dinfo = new DirectoryInfo(SelectDirectory.SelectedPath);

                FileInfo[] Files = dinfo.GetFiles("*.jpg");

                foreach (FileInfo file in Files)
                {
                    ListPhotos.Items.Add(file.Name);
                }

            }
        }

        private void SelectWatermark_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChooseWatermark = new OpenFileDialog();
            ChooseWatermark.Filter = "Png Files (*.png)|*.png|All Files (*.*)|*.*";
            ChooseWatermark.FilterIndex = 1;
            ChooseWatermark.InitialDirectory = "c:\\";
            ChooseWatermark.RestoreDirectory = false;


            if (ChooseWatermark.ShowDialog() == DialogResult.OK)
            {
                WatermarkFilePath = ChooseWatermark.FileName;
                WatermarkPreview.SizeMode = PictureBoxSizeMode.Zoom;
                using (Bitmap tmpBitmap = new Bitmap(WatermarkFilePath))
                {
                    WatermarkPreview.Image = new Bitmap(tmpBitmap);
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (ApplyWatermark.Checked)
            {
                string imageFolderPath = SourcePath.Text;
                string outputFolderPath = DestinationPath.Text;
                string watermarkImage = WatermarkFilePath;
                ImageAfter.SizeMode = PictureBoxSizeMode.Zoom;

                // Controleer of de directories bestaan
                if (Directory.Exists(imageFolderPath) && Directory.Exists(outputFolderPath))
                {
                    string[] imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly);

                    foreach (string imgLocation in imageFiles)
                    {
                        try
                        {
                            using (Image image = Image.FromFile(imgLocation))
                            {
                                using (Graphics g = Graphics.FromImage(image))
                                {
                                    Image watermark = Image.FromFile(watermarkImage);
                                    g.DrawImage(watermark, new Point(0, 0));
                                    string outputFileName = Path.Combine(outputFolderPath, "watermarkadded-" + Path.GetFileName(imgLocation));
                                    image.Save(outputFileName);
                                    ImageAfter.Image = new Bitmap(outputFileName);
                                    ListPhotos.Items.Clear();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing image: " + imgLocation + "\n" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure the image folder and output folder exist.");
                }
            }
            else
            {
                string imageFolderPath = SourcePath.Text;
                string outputFolderPath = DestinationPath.Text;

                // Controleer of de directories bestaan
                if (Directory.Exists(imageFolderPath) && Directory.Exists(outputFolderPath))
                {
                    string[] imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly);

                    foreach (string imgLocation in imageFiles)
                    {
                        try
                        {
                            string destinationFileName = Path.Combine(outputFolderPath, Path.GetFileName(imgLocation));
                            File.Move(imgLocation, destinationFileName);
                            ListPhotos.Items.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error moving image: " + imgLocation + "\n" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure the image folder and output folder exist.");
                }
            }
        }
    }
}
