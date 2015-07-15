namespace SizeOperations
{
    using System;

    public class SizeOperations
    {
        public static void Main()
        {
            var size = new Size(14.3, 7.2);
            var rotatedSize = size.GetRotatedSize(13.2);

            Console.WriteLine(size);
            Console.WriteLine(rotatedSize);
        }
    }
}
