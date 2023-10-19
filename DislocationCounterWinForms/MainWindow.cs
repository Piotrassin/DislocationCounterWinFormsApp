using DislocationCounterWinForms;
using DislocationCounterWinForms.DislocationDetectionService;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DysklokacjowoWinForms
{
    public partial class MainWindow : Form
    {
        private readonly IDislocationDetectionService dislocationDetectionService;

        private Image<Bgr, byte>? inputImage;
        private Image<Gray, byte>? binaryImage;
        private Image<Bgr, byte>? outputImage;
        private bool tabSwitchingEnabled = true;

        public MainWindow(IDislocationDetectionService dislocationDetectionService)
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
            PreviewFilteredImage();
            showProcessedImageTab();
        }

        private void PreviewFilteredImage()
        {
            if (inputImage is null)
            {
                return;
            }

            try
            {
                binaryImage = dislocationDetectionService.PreviewGrayScaleImage(inputImage, (int)thresholdSelector.Value);
                processedPictureBox.Image = binaryImage.ToBitmap();
            }
            catch (Exception ex)
            {
                defaultExceptionHandler(ex);
            }
        }

        private void countShapesButton_Click(object sender, EventArgs e)
        {
            PreviewFilteredImage();
            CountShapes();
            showProcessedImageTab();
        }

        private void CountShapes()
        {
            (var numOfDislocations, outputImage) = dislocationDetectionService.CountShapes(
                binaryImage,
                outputImage,
                (double)minimumViableAreaSelector.Value,
                (double)maximumViableAreaSelector.Value);

            resultValueLabel.Text = numOfDislocations.ToString();
            processedPictureBox.Image = outputImage.ToBitmap();
        }

        private void resetSettingButton_Click(object sender, EventArgs e)
        {
            //temporarily block switching tabs when resetting settings due to auto preview enabled
            tabSwitchingEnabled = false;
            resetSettings();
            tabSwitchingEnabled = true;
        }

        private void defaultExceptionHandler(Exception ex)
        {
            MessageBox.Show(ex.Message.ToString(), "Error");
        }

        private void resetSettings()
        {
            thresholdSelector.Value = ConfigConstants.DefaultThresholdValue;

            minimumViableAreaSelector.Minimum = ConfigConstants.MinimumViableAreaValue;
            minimumViableAreaSelector.Maximum = ConfigConstants.MaximumViableAreaValue;

            maximumViableAreaSelector.Minimum = ConfigConstants.MinimumViableAreaValue;
            maximumViableAreaSelector.Maximum = ConfigConstants.MaximumViableAreaValue;

            minimumViableAreaSelector.Value = ConfigConstants.DefaultMinViableAreaValue;
            maximumViableAreaSelector.Value = ConfigConstants.DefaultMaxViableAreaValue;
        }

        private void importPictureButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp;|All Files (*.*)|*.*;";
                if (dialog.ShowDialog() is DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(dialog.FileName);
                    originalPictureBox.Image = inputImage.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                defaultExceptionHandler(ex);
            }

            showOriginalImageTab();
        }

        private void thresholdSelector_ValueChanged(object sender, EventArgs e)
        {
            if (!autoPreviewCheckBox.Checked)
            {
                return;
            }

            PreviewFilteredImage();

            if (tabSwitchingEnabled)
            {
                showProcessedImageTab();
            }
        }

        private void showProcessedImageTab()
        {
            tabControl1.SelectTab(1);
        }

        private void showOriginalImageTab()
        {
            tabControl1.SelectTab(0);
        }

    }
}