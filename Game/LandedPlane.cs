using System.Collections.Generic;

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
            graphics.DrawLandedPlane(range, elevation);
            graphics.DrawSuccessMessage();
        }

        private readonly int range;
        private readonly int elevation;
    }
}
