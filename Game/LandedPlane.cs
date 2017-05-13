using System.Collections.Generic;
using System.Drawing;

namespace BomberCommand
{
    class LandedPlane : Plane
    {
        public LandedPlane(int range, int elevation)
        {
            this.range = range;
            this.elevation = elevation;
        }

        public Plane Update(List<Building> buildings)
        {
            return this;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(
                Brushes.Blue,
                new Rectangle(
                    range * 16,
                    (40 - elevation) * 16,
                    16, 16));

            graphics.DrawString("You won!", new Font("Console", 48.0f), Brushes.White, new PointF(100, 300));
        }

        private readonly int range;
        private readonly int elevation;
    }
}
