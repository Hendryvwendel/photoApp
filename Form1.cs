using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace photoApp
{
    public partial class HomePage : Form
    {
        private string imgLocation = "";
        private string WatermarkFilePath = "";

        public HomePage()
        {
            InitializeComponent();
        }

        private void SelectImages_Click(object sender, EventArgs e)
        {
            var selectDirectory = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Selecteer de map",
                ShowNewFolderButton = true
            };

            ListPhotos.Items.Clear();

            if (selectDirectory.ShowDialog() == DialogResult.OK)
            {
                SourcePath.Text = selectDirectory.SelectedPath;
                var dinfo = new DirectoryInfo(selectDirectory.SelectedPath);
                var files = dinfo.GetFiles("*.jpg");
                foreach (var file in files) ListPhotos.Items.Add(file.Name);
            }
        }

        private void ListPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgLocation = Path.Combine(SourcePath.Text, ListPhotos.SelectedItem.ToString());
            ImagePrevious.SizeMode = PictureBoxSizeMode.Zoom;

            using (var tmpBitmap = new Bitmap(imgLocation))
            {
                ImagePrevious.Image = new Bitmap(tmpBitmap);
            }
        }

        private void SelectWatermark_Click(object sender, EventArgs e)
        {
            var chooseWatermark = new OpenFileDialog
            {
                Filter = "Png Bestanden (*.png)|*.png|Alle Bestanden (*.*)|*.*",
                FilterIndex = 1,
                InitialDirectory = "c:\\",
                RestoreDirectory = false
            };

            if (chooseWatermark.ShowDialog() == DialogResult.OK)
            {
                WatermarkFilePath = chooseWatermark.FileName;
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
            var imageFolderPath = SourcePath.Text;

            if (Directory.Exists(imageFolderPath))
            {
                var imageFiles = Directory.GetFiles(imageFolderPath, "*.jpg", SearchOption.TopDirectoryOnly);

                foreach (var imgLocation in imageFiles)
                {
                    try
                    {
                        if (ApplyWatermarkCheck.Checked)
                        {
                            if (!File.Exists(WatermarkFilePath))
                            {
                                MessageBox.Show("Het watermerkbestand bestaat niet. Controleer het pad.");
                                return;
                            }

                            SaveImageToDatabaseWithWatermark(imgLocation, WatermarkFilePath);
                        }
                        else
                        {
                            SaveImageToDatabaseWithoutWatermark(imgLocation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fout bij verwerken afbeelding: " + imgLocation + "\n" + ex.Message);
                    }
                }

                MessageBox.Show("Afbeeldingen succesvol verwerkt en opgeslagen in de database.");
            }
            else
            {
                MessageBox.Show("Zorg ervoor dat de originele map bestaat.");
            }
        }

        private void SaveImageToDatabaseWithWatermark(string originalImagePath, string watermarkImagePath)
        {
            using (var watermarkedImage = ApplyWatermark(originalImagePath, watermarkImagePath))
            {
                byte[] imageData;
                using (var memoryStream = new MemoryStream())
                {
                    watermarkedImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    imageData = memoryStream.ToArray();
                }

                var fileName = Path.GetFileName(originalImagePath);
                var uploadDate = DateTime.Now;

                var connectionString = "Server=localhost;Database=stage-vwc;User=root;Password=Hendry@2007;";

                using (var connection = new MySqlConnection(connectionString))
                {
                    var query = "INSERT INTO afbeeldingen (name, image, date) VALUES (@FileName, @Image, @UploadDate)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FileName", fileName);
                        command.Parameters.AddWithValue("@Image", imageData);
                        command.Parameters.AddWithValue("@UploadDate", uploadDate);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void SaveImageToDatabaseWithoutWatermark(string originalImagePath)
        {
            var fileName = Path.GetFileName(originalImagePath);
            var fileData = FileToByteArray(originalImagePath);
            var uploadDate = DateTime.Now;

            var connectionString = "Server=localhost;Database=stage-vwc;User=root;Password=Hendry@2007;";

            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO afbeeldingen (name, image, date) VALUES (@FileName, @Image, @UploadDate)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@Image", fileData);
                    command.Parameters.AddWithValue("@UploadDate", uploadDate);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private Bitmap ApplyWatermark(string originalImagePath, string watermarkImagePath)
        {
            using (var originalImage = Image.FromFile(originalImagePath))
            using (var watermarkImage = Image.FromFile(watermarkImagePath))
            {
                var result = new Bitmap(originalImage.Width, originalImage.Height);

                using (var graphics = Graphics.FromImage(result))
                {
                    graphics.DrawImage(originalImage, new Rectangle(0, 0, result.Width, result.Height));

                    var watermarkX = result.Width - watermarkImage.Width - 10;
                    var watermarkY = result.Height - watermarkImage.Height - 10;

                    graphics.DrawImage(watermarkImage, new Rectangle(watermarkX, watermarkY, watermarkImage.Width, watermarkImage.Height));
                }

                return result;
            }
        }

        private static byte[] FileToByteArray(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        private void ChooseDestination_Click(object sender, EventArgs e)
        {
            
        }
    }
}
