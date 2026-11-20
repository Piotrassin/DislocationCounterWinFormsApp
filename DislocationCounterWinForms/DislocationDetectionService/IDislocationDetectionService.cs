using Emgu.CV;
using Emgu.CV.Structure;

namespace DislocationCounterWinForms.DislocationDetectionService
{
    public interface IDislocationDetectionService
    {
        (int, Bitmap) CountAndDrawContours(double minimumViableArea, double maximumViableArea, double epsilon = 0.04);
        Bitmap PreviewFilteredImage(int thresholdValue);
        Bitmap GetInputImage();
        Bitmap GetBinaryImage();
        Bitmap GetOutputImage();
        Bitmap PopulateInputImage(string path);
        Bitmap LoadImageFromFile(string path);
    }
}