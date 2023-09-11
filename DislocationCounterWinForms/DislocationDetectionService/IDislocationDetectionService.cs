using Emgu.CV;
using Emgu.CV.Structure;

namespace DislocationCounterWinForms.DislocationDetectionService
{
    public interface IDislocationDetectionService
    {
        (int, Image<Bgr, byte>) CountShapes(Image<Gray, byte> binaryImage, Image<Bgr, byte> outputImage, double epsilon, double minimumViableArea, double maximumViableArea);
        Image<Gray, byte> PreviewGrayScaleImage(Image<Bgr, byte> input, int sensitivityValue);
    }
}