using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DysklokacjowoWinForms
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte>? inputImage;
        Image<Gray, byte>? binaryImage;
        Image<Bgr, byte>? outputImage;
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
                    inputImage = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = inputImage.ToBitmap();
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
            if (inputImage is null)
            {
                return;
            }

            try
            {
                var temp = inputImage.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(230), new Gray(255));
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
                    inputImage = new Image<Bgr, byte>(dialog.FileName);
                    pictureBox1.Image = inputImage.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (inputImage is null)
            {
                return;
            }

            try
            {
                binaryImage = inputImage.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(thresholdValue), new Gray(255));
                pictureBox1.Image = binaryImage.ToBitmap();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void CountDislocationsButton_Click(object sender, EventArgs e)
        {
            if (sender is null || binaryImage is null)
            {
                return;
            }

            int numberOfDislocations = 0;
            var contours = new VectorOfVectorOfPoint();
            var matrix = new Mat();

            CvInvoke.FindContours(
                binaryImage,
                contours,
                matrix,
                Emgu.CV.CvEnum.RetrType.External,
                method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            outputImage = binaryImage.Convert<Bgr, Byte>();
            for (int i = 0; i < contours.Size; i++)
            {
                var perimeter = CvInvoke.ArcLength(contours[i], true);
                var approxNumOfEdges = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contours[i], approxNumOfEdges, 0.03 * perimeter, true);
                
                CvInvoke.DrawContours(outputImage, contours, i, new MCvScalar(0, 0, 255));

                var moments = CvInvoke.Moments(contours[i]);
                int x = (int)(moments.M10 / moments.M00);
                int y = (int)(moments.M01 / moments.M00);


                CvInvoke.PutText(outputImage, $"{approxNumOfEdges.Size}", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.3, new MCvScalar(0, 0, 255), 1);
                if (approxNumOfEdges >= 4)
                {
                    numberOfDislocations++;
                }
            }
            ResultValueLabel.Text = numberOfDislocations.ToString();
            pictureBox1.Image = outputImage.ToBitmap();

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