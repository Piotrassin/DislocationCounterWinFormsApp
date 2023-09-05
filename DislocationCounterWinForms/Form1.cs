using DislocationCounterWinForms.DislocationDetectionService;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DysklokacjowoWinForms
{
    public partial class Form1 : Form
    {
        private readonly IDislocationDetectionService dislocationDetectionService;

        private Image<Bgr, byte>? inputImage;
        private Image<Gray, byte>? binaryImage;
        private Image<Bgr, byte>? outputImage;
        private int thresholdValue;

        public Form1(IDislocationDetectionService dislocationDetectionService)
        {
            InitializeComponent();
            this.dislocationDetectionService = dislocationDetectionService;
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
                    inputImage = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = inputImage.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inputImage is null)
            {
                return;
            }

            try
            {
                binaryImage = dislocationDetectionService.PreviewGrayScaleImage(inputImage, thresholdValue);
                pictureBox1.Image = binaryImage.ToBitmap();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void countDislocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is null || binaryImage is null)
            {
                return;
            }
            this.processToolStripMenuItem_Click(sender, e);

            (var numOfDislocations, outputImage) = dislocationDetectionService.CountShapes(binaryImage, outputImage);


            resultValueLabel.Text = numOfDislocations.ToString();
            pictureBox1.Image = outputImage.ToBitmap();
        }

        private void ThresholdSelector_ValueChanged(object sender, EventArgs e)
        {
            if (sender is null)
            {
                return;
            }

            var newValue = (sender as NumericUpDown).Value;
            thresholdValue = Int32.Parse(newValue.ToString());
        }

    }
}