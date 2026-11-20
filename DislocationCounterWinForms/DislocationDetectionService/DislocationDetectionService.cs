using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DislocationCounterWinForms.DislocationDetectionService
{
    public class DislocationDetectionService : IDislocationDetectionService
    {
        private Image<Bgr, byte>? inputImage;
        private Image<Gray, byte>? binaryImage;
        private Image<Bgr, byte>? outputImage;

        public Bitmap GetInputImage()
        {
            return inputImage.ToBitmap();
        }

        public Bitmap GetBinaryImage()
        {
            return binaryImage.ToBitmap();
        }

        public Bitmap GetOutputImage()
        {
            return outputImage.ToBitmap();
        }
        public Bitmap LoadImageFromFile(string path)
        {
            inputImage = CreateBgrImageByFilePath(path);
            return GetInputImage();
        }
        public Bitmap PopulateInputImage(string path)
        {
            inputImage = CreateBgrImageByFilePath(path);
            return GetInputImage();
        }

        private Image<Bgr, byte> CreateBgrImageByFilePath(string path)
        {
            return inputImage = new Image<Bgr, byte>(path);
        }

        public Image<Gray, byte> PreviewGrayScaleImage(Image<Bgr, byte> input, int sensitivityValue)
        {
            return input.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(sensitivityValue), new Gray(255));
        }

        private (Image<Bgr, byte>, VectorOfVectorOfPoint) FindCountours(Image<Gray, byte> binaryImage)
        {
            var contours = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(
                binaryImage,
                contours,
                new Mat(),
                Emgu.CV.CvEnum.RetrType.External,
                method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

            var outputImage = binaryImage.Convert<Bgr, Byte>();
            return (outputImage, contours);
        }

        private static (int, Image<Bgr, byte>) CountContours(Image<Bgr, byte> inputImage, VectorOfVectorOfPoint contours, double minimumViableArea, double maximumViableArea, double epsilon = 0.04)
        {
            int numberOfDislocations = 0;

            for (int i = 0; i < contours.Size; i++)
            {
                var perimeter = CvInvoke.ArcLength(contours[i], true);
                var approxNumOfEdges = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contours[i], approxNumOfEdges, epsilon * perimeter, true);
                var area = CvInvoke.ContourArea(contours[i]);

                if (area > maximumViableArea || area < minimumViableArea)
                {
                    continue;
                }

                CvInvoke.DrawContours(inputImage, contours, i, new MCvScalar(0, 0, 255), 3);

                numberOfDislocations++;
            }

            return (numberOfDislocations, inputImage);
        }

        public Bitmap PreviewFilteredImage(int thresholdValue)
        {
            if (inputImage is null)
            {
                throw new NullReferenceException();
            }

            try
            {
                binaryImage = PreviewGrayScaleImage(inputImage, thresholdValue);
                return GetBinaryImage();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public (int, Bitmap) CountAndDrawContours(double minimumViableArea, double maximumViableArea, double epsilon = 0.04)
        {
            (var processedImg, var contours) = FindCountours(binaryImage);
            (var numberOfContours, outputImage) = CountContours(processedImg, contours, minimumViableArea, maximumViableArea, epsilon);
            return (numberOfContours, GetOutputImage());
        }

    }
}
