using Emgu.CV;
using Emgu.CV.Structure;

namespace DysklokacjowoWinForms
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte>? image;
        double thresholdValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thresholdValue = 100;
        }

        private void importPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp;|All Files (*.*)|*.*;";
                if (dialog.ShowDialog() is DialogResult.OK)
                {
                    image = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = image.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void countDislocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image is null)
            {
                return;
            }

            try
            {
                var temp = image.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));
                pictureBox1.Image = temp.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ImportPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp;|All Files (*.*)|*.*;";
                if (dialog.ShowDialog() is DialogResult.OK)
                {
                    image = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = image.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CountDislocationsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (image is null)
            {
                return;
            }

            try
            {
                var temp = image.Convert<Gray, byte>().ThresholdBinary(new Gray(thresholdValue), new Gray(255));
                pictureBox1.Image = temp.ToBitmap();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ThresholdSelector_ValueChanged(object sender, EventArgs e)
        {
            if (sender is null)
            {
                return;
            }

            var newValue = (sender as NumericUpDown).Value;
            thresholdValue = Double.Parse(newValue.ToString());
        }
    }
}