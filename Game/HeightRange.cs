using System;

namespace BomberCommand
{
    class HeightRange
    {
        public HeightRange(int minHeight, int maxHeight)
        {
            this.minHeight = minHeight;
            this.maxHeight = maxHeight;
        }

        public int GenerateRandomHeight()
            => randomGenerator
                .Next(maxHeight - minHeight) + minHeight;

        private readonly Random randomGenerator = new Random();

        private readonly int minHeight;
        private readonly int maxHeight;
    }
}
