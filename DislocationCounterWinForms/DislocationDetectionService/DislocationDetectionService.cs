using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace DislocationCounterWinForms.DislocationDetectionService
{
    public class DislocationDetectionService : IDislocationDetectionService
    {
        public Image<Gray, byte> PreviewGrayScaleImage(Image<Bgr, byte> input, int sensitivityValue)
        {
            return input.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(sensitivityValue), new Gray(255));
        }

        public (int, Image<Bgr, byte>) CountShapes(Image<Gray, byte> binaryImage, Image<Bgr, byte> outputImage, double minimumViableArea, double maximumViableArea, double epsilon = 0.04)
        {
            int numberOfDislocations = 0;
            var contours = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(
                binaryImage,
                contours,
                new Mat(),
                Emgu.CV.CvEnum.RetrType.External,
                method: Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            outputImage = binaryImage.Convert<Bgr, Byte>();

            for (int i = 0; i < contours.Size; i++)
            {
                var perimeter = CvInvoke.ArcLength(contours[i], true);
                var approxNumOfEdges = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contours[i], approxNumOfEdges, epsilon * perimeter, true);
                var area = CvInvoke.ContourArea(contours[i]);

                if(area > maximumViableArea || area < minimumViableArea)
                {
                    continue;
                }

                CvInvoke.DrawContours(outputImage, contours, i, new MCvScalar(0, 0, 255), 3);

                numberOfDislocations++;
            }

            return (numberOfDislocations, outputImage);
        }
    }
}
