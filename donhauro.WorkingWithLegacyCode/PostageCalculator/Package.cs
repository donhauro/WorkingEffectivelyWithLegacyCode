using System;

namespace PostageCalculator
{
    public class Package
    {
        private readonly int Weight;
        private readonly int Height;
        private readonly int Width;
        private readonly int Depth;

        public Package(int weight, int height, int width, int depth)
        {
            Weight = weight;
            Height = height;
            Width = width;
            Depth = depth;
        }

        public decimal PostageInBaseCurrency()
        {
            if (this.Weight <= 60 && this.Height <= 229 && this.Width <= 162 && this.Depth <= 25)
            {
                return 120m;
            }
            if (this.Weight <= 500 && this.Height <= 324 && this.Width <= 229 && this.Depth <= 100)
            {
                return this.Weight * 4;
            }

            if (this.Weight <= 800 && this.Height <= 500 && this.Width <= 300 && this.Depth <= 150)
            {
                return this.Weight * 5;
            }

            return Math.Max(this.Weight, this.Height * this.Width * this.Depth / 1000m) * 6;
        }
    }
}