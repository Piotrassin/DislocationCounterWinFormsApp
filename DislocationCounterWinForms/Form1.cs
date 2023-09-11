using DislocationCounterWinForms;
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

        public Form1(IDislocationDetectionService dislocationDetectionService)
        {
            InitializeComponent();
            this.dislocationDetectionService = dislocationDetectionService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetSettings();
        }

        private void minimumViableAreaSelector_ValueChanged(object sender, EventArgs e)
        {
            if (minimumViableAreaSelector.Value > maximumViableAreaSelector.Value)
            {
                maximumViableAreaSelector.Value = minimumViableAreaSelector.Value;
            }
        }

        private void maximumViableAreaSelector_ValueChanged(object sender, EventArgs e)
        {
            if (maximumViableAreaSelector.Value < minimumViableAreaSelector.Value)
            {
                minimumViableAreaSelector.Value = maximumViableAreaSelector.Value;
            }
        }
        private void previewFilteredShapesButton_Click(object sender, EventArgs e)
        {
            if (inputImage is null)
            {
                return;
            }

            try
            {
                binaryImage = dislocationDetectionService.PreviewGrayScaleImage(inputImage, (int)thresholdSelector.Value);
                pictureBox1.Image = binaryImage.ToBitmap();
            }
            catch (Exception ex)
            {
                defaultExceptionHandler(ex);
            }
        }

        private void countShapesButton_Click(object sender, EventArgs e)
        {
            this.previewFilteredShapesButton_Click(sender, e);

            (var numOfDislocations, outputImage) = dislocationDetectionService.CountShapes(
                binaryImage,
                outputImage,
                (double)maxErrorSelector.Value,
                (double)minimumViableAreaSelector.Value,
                (double)maximumViableAreaSelector.Value);

            resultValueLabel.Text = numOfDislocations.ToString();
            pictureBox1.Image = outputImage.ToBitmap();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
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
                defaultExceptionHandler(ex);
            }
        }
        private void resetSettingButton_Click(object sender, EventArgs e)
        {
            resetSettings();
        }

        private void defaultExceptionHandler(Exception ex)
        {
            MessageBox.Show(ex.Message.ToString(), "Error");
        }

        private void resetSettings()
        {
            thresholdSelector.Value = ConfigConstants.DefaultThresholdValue;
            maxErrorSelector.Value = ConfigConstants.DefaultMaxErrorValue;

            minimumViableAreaSelector.Minimum = ConfigConstants.MinimumViableAreaValue;
            minimumViableAreaSelector.Maximum = ConfigConstants.MaximumViableAreaValue;

            maximumViableAreaSelector.Minimum = ConfigConstants.MinimumViableAreaValue;
            maximumViableAreaSelector.Maximum = ConfigConstants.MaximumViableAreaValue;

            minimumViableAreaSelector.Value = ConfigConstants.DefaultMinViableAreaValue;
            maximumViableAreaSelector.Value = ConfigConstants.DefaultMaxViableAreaValue;
        }
    }
}