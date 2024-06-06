using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
namespace XRay
{
    internal class RadiographComparer
    {
        public enum ComparisonResult
        {
            NoProgress,
            ProgressInTreatment,
            ProgressionOfDisease
        }

        public static ComparisonResult CompareRadiographs(Image<Bgr, byte> image1, Image<Bgr, byte> image2)
        {
            // Convert images to grayscale
            Image<Gray, byte> grayImage1 = image1.Convert<Gray, byte>();
            Image<Gray, byte> grayImage2 = image2.Convert<Gray, byte>();

            // Compute histograms
            DenseHistogram hist1 = new DenseHistogram(256, new RangeF(0, 256));
            DenseHistogram hist2 = new DenseHistogram(256, new RangeF(0, 256));

            hist1.Calculate(new Image<Gray, byte>[] { grayImage1 }, false, null);
            hist2.Calculate(new Image<Gray, byte>[] { grayImage2 }, false, null);

            // Convert histograms to CV_32F
            Mat histMat1 = new Mat();
            Mat histMat2 = new Mat();
            hist1.CopyTo(histMat1);
            hist2.CopyTo(histMat2);

            histMat1.ConvertTo(histMat1, DepthType.Cv32F);
            histMat2.ConvertTo(histMat2, DepthType.Cv32F);

            // Compute correlation score
            double score = CvInvoke.CompareHist(histMat1, histMat2, HistogramCompMethod.Correl);

            // Define thresholds for comparison
            double thresholdNoProgress = 0.98;
            double thresholdProgressInTreatment = 0.85;

            if (score >= thresholdNoProgress)
            {
                return ComparisonResult.NoProgress;
            }
            else if (score >= thresholdProgressInTreatment)
            {
                return ComparisonResult.ProgressInTreatment;
            }
            else
            {
                return ComparisonResult.ProgressionOfDisease;
            }
        }
    }
}
