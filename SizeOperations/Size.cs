namespace SizeOperations
{
    using System;
    
    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public Size GetRotatedSize(double rotationAngle)
        {
            double width = GetSinAndCosOfDimensions(rotationAngle, this.Width, this.Height);
            double height = GetSinAndCosOfDimensions(rotationAngle, this.Height, this.Width);
            Size sizeAfterRotation = new Size(width, height);

            return sizeAfterRotation;
        }

        private double GetSinAndCosOfDimensions(double angle, double dimWithCos, double dimWithSin)
        {
            double dimensionWithCos = Math.Abs(Math.Cos(angle)) * dimWithCos;
            double dimensionWithSin = Math.Abs(Math.Sin(angle)) * dimWithSin;

            return dimensionWithCos + dimensionWithSin;
        }

        public override string ToString()
        {
            return String.Format("Width: {0:F3}, Height: {1:F3}", this.Width, this.Height);
        }
    }
}
