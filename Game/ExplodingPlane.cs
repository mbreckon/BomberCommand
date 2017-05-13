using System.Collections.Generic;
using System.Drawing;

namespace BomberCommand
{
    class ExplodingPlane : Plane
    {
        public ExplodingPlane(int range, int elevation)
        {
            this.elevation = elevation;
            this.range = range;
        }

        public Plane Update(List<Building> buildings)
        {
            frameCount++;
            return this;
        }

        public void Draw(Graphics graphics)
        {
            switch (frameCount)
            {
                case 0:
                    graphics.FillEllipse(
                        Brushes.Yellow,
                        new Rectangle(
                            (range * 16),
                            ((40 - elevation) * 16),
                            16, 16));
                    break;
                case 1:
                    graphics.FillEllipse(
                        Brushes.Orange,
                        new Rectangle(
                            (range * 16) - 4,
                            ((40 - elevation) * 16) - 4,
                            28, 28));
                    break;

                default:
                    graphics.DrawString("You failed!", new Font("Console", 48.0f), Brushes.White, new PointF(100, 300));
                    break;
            }
        }

        private int frameCount = 0;

        private readonly int elevation;
        private readonly int range;
    }
}
