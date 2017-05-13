using System;
using System.Drawing;

namespace BomberCommand
{
    class Building
    {
        public Building(int zone, int height)
        {
            this.zone = zone;
            this.height = height;
        }

        public void Update(int bombZone, int bombHeight)
        {
            if (bombZone == zone)
            {
                height = (bombHeight <= height) ? 
                    (height - 1) : height;
            }
        }

        public void Draw(Graphics graphics)
        {
            var pixelHeight = 16 * height;

            graphics.FillRectangle(
                Brushes.Black,
                new Rectangle(
                    zone * 16, 
                    (40 * 16) - pixelHeight, 
                    16, 
                    pixelHeight));
        }

        public bool Collides(int zone, int elevation)
            => (zone == this.zone) && (elevation <= this.height);

        private readonly int zone;
        private int height;
    }
}
