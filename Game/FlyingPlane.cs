using System.Collections.Generic;
using System.Linq;

namespace BomberCommand
{
    class FlyingPlane : Plane
    {
        public FlyingPlane(BombTrigger bombTrigger)
        {
            this.bombTrigger = bombTrigger;
            elevation = 40;
            range = 0;
        }

        public Plane Update(List<Building> buildings)
        {
            range++;

            if ((range == 39) && (elevation == 1))
                return new LandedPlane(range, elevation);

            if (range >= 40)
            {
                range = 0;
                elevation--;
            }

            if (buildings.Any(x => x.Collides(range, elevation)))
                return new ExplodingPlane(range, elevation);

            bombTrigger.Update(range, elevation, buildings);
            return this;
        }

        public void Draw(Graphics graphics)
        {
            bombTrigger.Draw(graphics);
            graphics.DrawFlyingPlane(range, elevation);
        }

        private readonly BombTrigger bombTrigger;

        private int elevation;
        private int range;
    }
}
