namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            feature.SelectedIndex = 0;
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
            }
            else
            {
                chosenBackground.Image = null;
                backgroundPanel.Enabled = false;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (chosenImage.Image == null)
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

                    if (chosenBitmap.Size != backgroundBitmap.Size)
                    {
                        MessageBox.Show("The chosen image and background must be the same size.");
                        return;
                    }

                    processed.Image = BasicDIP.Subtraction(chosenBitmap, backgroundBitmap);
                    break;
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
    }
}
