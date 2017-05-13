using System.Collections.Generic;

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
            if (frameCount < 2)
            {
                graphics.DrawExplosion(range, elevation, frameCount);
            }
            else
            {
                graphics.DrawFailMessage();
            }
        }

        private int frameCount = 0;

        private readonly int elevation;
        private readonly int range;
    }
}
