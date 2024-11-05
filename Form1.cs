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

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                uploaded.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void feature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void go_Click(object sender, EventArgs e)
        {
            if (uploaded.Image == null)
            {
                MessageBox.Show("Please upload an image first.");
                return;
            }
            if (feature.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a feature first.");
                return;
            }
            switch (feature.SelectedItem?.ToString())
            {
                case "Basic Copy":
                    processed.Image = Features.BasicCopy(new Bitmap(uploaded.Image));
                    break;
                case "Color Inversion":
                    processed.Image = Features.ColorInversion(new Bitmap(uploaded.Image));
                    break;
                case "Greyscale":
                    processed.Image = Features.Greyscale(new Bitmap(uploaded.Image));
                    break;
                case "Histogram":
                    processed.Image = Features.Histogram(new Bitmap(uploaded.Image));
                    break;
                case "Sepia":
                    processed.Image = Features.Sepia(new Bitmap(uploaded.Image));
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
