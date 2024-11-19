using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private bool cameraRunning = false;
        private Color chosenColor;
        private Bitmap backgroundBitmap;
        private NewFrameEventHandler activeFrameHandler;

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

            if (cameras.Items.Count > 0)
                cameras.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    stopCamera();
                    Image image = Image.FromFile(dialog.FileName);
                    chosenImage.Image = image;
                    chosenImageText.Text = $"Size: {image.Width}x{image.Height}";
                }
            }
        }

        private void chooseBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(dialog.FileName);
                    chosenBackground.Image = image;
                    chosenBackgroundText.Text = $"Size: {image.Width}x{image.Height}";
                }
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
                    ProcessSubtraction();
                    break;
                case "Gaussian Blur":
                    processed.Image = Convolution.GaussianBlur(new Bitmap(chosenImage.Image));
                    break;
                case "Sharpen":
                    processed.Image = Convolution.Sharpen(new Bitmap(chosenImage.Image));
                    break;
                case "Mean Removal":
                    processed.Image = Convolution.MeanRemoval(new Bitmap(chosenImage.Image));
                    break;
                case "Emboss":
                    processed.Image = Convolution.Emboss(new Bitmap(chosenImage.Image));
                    break;
                case "Emboss Laplascian":
                    processed.Image = Convolution.EmbossLaplascian(new Bitmap(chosenImage.Image));
                    break;
                case "Horz/Vertical":
                    processed.Image = Convolution.HorzVertical(new Bitmap(chosenImage.Image));
                    break;
                case "All Directions":
                    processed.Image = Convolution.AllDirections(new Bitmap(chosenImage.Image));
                    break;
                case "Lossy":
                    processed.Image = Convolution.Lossy(new Bitmap(chosenImage.Image));
                    break;
                case "Horizontal Only":
                    processed.Image = Convolution.HorizontalOnly(new Bitmap(chosenImage.Image));
                    break;
                case "Vertical Only":
                    processed.Image = Convolution.VerticalOnly(new Bitmap(chosenImage.Image));
                    break;
                case "Edge Enhance":
                    processed.Image = Convolution.EdgeEnhance(new Bitmap(chosenImage.Image));
                    break;
                case "Edge Detection":
                    processed.Image = Convolution.EdgeDetection(new Bitmap(chosenImage.Image));
                    break;
            }
        }


        private void ProcessSubtraction()
        {
            if (chosenBackground.Image == null)
            {
                MessageBox.Show("Please upload a background image first.");
                return;
            }

            backgroundBitmap = new Bitmap(chosenBackground.Image);
            Bitmap chosenBitmap = new Bitmap(chosenImage.Image);

            if (chosenBitmap.Size != backgroundBitmap.Size)
            {
                MessageBox.Show("Images must be the same size.");
                return;
            }

            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    chosenColor = colorDialog.Color;

                    if (cameraRunning)
                    {
                        StartSubtractionCamera();
                    }
                    else
                    {
                        processed.Image = BasicDIP.Subtraction(chosenColor, chosenBitmap, backgroundBitmap);
                    }
                }
            }
        }

        private void toggleCamera_Click(object sender, EventArgs e)
        {
            if (cameraRunning)
            {
                stopCamera();
                toggleCamera.Text = "Turn On";
                chooseImage.Enabled = true;
                cameras.Enabled = true;
                cameraRunning = false;
            }
            else
            {
                StartCamera();
                toggleCamera.Text = "Turn Off";
                chooseImage.Enabled = false;
                cameras.Enabled = false;
                cameraRunning = true;
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (processed.Image == null)
            {
                MessageBox.Show("Please process an image first.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    processed.Image.Save(dialog.FileName);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }

        private void StartCamera()
        {
            if (videoCaptureDevice != null)
            {
                if (activeFrameHandler != null)
                    videoCaptureDevice.NewFrame -= activeFrameHandler;

                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameras.SelectedIndex].MonikerString);

                activeFrameHandler = DefaultFrameHandler;
                videoCaptureDevice.NewFrame += activeFrameHandler;
                videoCaptureDevice.Start();
            }
        }

        private void StartSubtractionCamera()
        {
            if (videoCaptureDevice != null)
            {
                if (activeFrameHandler != null)
                    videoCaptureDevice.NewFrame -= activeFrameHandler;

                activeFrameHandler = SubtractionFrameHandler;
                videoCaptureDevice.NewFrame += activeFrameHandler;
            }
        }

        private void DefaultFrameHandler(object s, NewFrameEventArgs e)
        {
            try
            {
                Bitmap frame = (Bitmap)e.Frame.Clone();
                chosenImage.Invoke((MethodInvoker)(() =>
                {
                    chosenImage.Image = frame;
                    chosenImageText.Text = $"Size: {frame.Width}x{frame.Height}";
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DefaultFrameHandler: {ex.Message}");
            }
        }

        private void SubtractionFrameHandler(object s, NewFrameEventArgs e)
        {
            try
            {
                Bitmap frame = (Bitmap)e.Frame.Clone();
                Bitmap processedFrame = BasicDIP.Subtraction(chosenColor, frame, backgroundBitmap);
                processed.Invoke((MethodInvoker)(() =>
                {
                    processed.Image = processedFrame;
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SubtractionFrameHandler: {ex.Message}");
            }
        }

        private void stopCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                if (activeFrameHandler != null)
                {
                    videoCaptureDevice.NewFrame -= activeFrameHandler;
                    activeFrameHandler = null;
                }

                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice.Stop();

                chosenImage.Image = null;
                processed.Image = null;
            }
        }
    }
}