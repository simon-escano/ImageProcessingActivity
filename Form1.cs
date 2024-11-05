using AForge.Video;
using AForge.Video.DirectShow;

namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Boolean cameraRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feature.SelectedIndex = 0;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cameras.Items.Add(filterInfo.Name);
            cameras.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                stopCamera();
                chosenImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void chooseBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                chosenBackground.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void feature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (feature.SelectedItem?.ToString() == "Subtraction")
            {
                backgroundPanel.Enabled = true;
                cameraPanel.Enabled = true;
            }
            else
            {
                chosenBackground.Image = null;
                backgroundPanel.Enabled = false;
                cameraPanel.Enabled = false;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (!cameraRunning && chosenImage.Image == null)
            {
                MessageBox.Show("Please upload an image first.");
                return;
            }
            switch (feature.SelectedItem?.ToString())
            {
                case "Basic Copy":
                    processed.Image = BasicDIP.BasicCopy(new Bitmap(chosenImage.Image));
                    break;
                case "Color Inversion":
                    processed.Image = BasicDIP.ColorInversion(new Bitmap(chosenImage.Image));
                    break;
                case "Greyscale":
                    processed.Image = BasicDIP.Greyscale(new Bitmap(chosenImage.Image));
                    break;
                case "Histogram":
                    processed.Image = BasicDIP.Histogram(new Bitmap(chosenImage.Image), processed);
                    break;
                case "Sepia":
                    processed.Image = BasicDIP.Sepia(new Bitmap(chosenImage.Image));
                    break;
                case "Subtraction":
                    if (chosenBackground.Image == null)
                    {
                        MessageBox.Show("Please upload a background image first.");
                        return;
                    }

                    Bitmap chosenBitmap = new Bitmap(chosenImage.Image);
                    Bitmap backgroundBitmap = new Bitmap(chosenBackground.Image);

                    if (chosenBitmap.Size !=  backgroundBitmap.Size) {
                        MessageBox.Show("Images must be the same size.");
                        return;
                    }

                    processed.Image = BasicDIP.Subtraction(chosenBitmap, backgroundBitmap);


                    break;
            }
        }

        private void toggleCamera_Click(object sender, EventArgs e)
        {
            if (cameraRunning)
            {
                toggleCamera.Text = "Turn On";
                chooseImage.Enabled = true;
                cameras.Enabled = true;
                cameraRunning = false;
                stopCamera();
            } 
            else
            {
                toggleCamera.Text = "Turn Off";
                chooseImage.Enabled = false;
                cameras.Enabled = false;
                cameraRunning = true;
                startCamera();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (processed.Image == null)
            {
                MessageBox.Show("Please process an image first.");
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                processed.Image.Save(dialog.FileName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }

        private void startCamera()
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameras.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += (s, e) =>
            {
                chosenImage.Image = (Bitmap)e.Frame.Clone();
            };
            videoCaptureDevice.Start();
        }

        private void stopCamera()
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                chosenImage.Image = null;
            }
        }
    }
}
