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

        public (int, Image<Bgr, byte>) CountShapes(Image<Gray, byte> binaryImage, Image<Bgr, byte> outputImage, double epsilon, double minimumViableArea, double maximumViableArea)
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
                var perimeter = CvInvoke.ArcLength(contours[i], true); //todo add a slider control to the UI for minimum viable perimeter.
                var approxNumOfEdges = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(contours[i], approxNumOfEdges, epsilon * perimeter, true);
                var area = CvInvoke.ContourArea(contours[i]);

                if(area > maximumViableArea || area < minimumViableArea)
                {
                    continue;
                }

                CvInvoke.DrawContours(outputImage, contours, i, new MCvScalar(0, 0, 255));

                var moments = CvInvoke.Moments(contours[i]);

                int x = (int)(moments.M10 / moments.M00);
                int y = (int)(moments.M01 / moments.M00);

                CvInvoke.PutText(outputImage, $"{approxNumOfEdges.Size}", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 0, 255), 2);
                if (approxNumOfEdges >= 4) //todo maybe? add a control for it 
                {
                    numberOfDislocations++;
                }
            }

            return (numberOfDislocations, outputImage);
        }
    }
}
