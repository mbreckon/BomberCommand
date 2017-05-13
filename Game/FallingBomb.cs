using System.Collections.Generic;
using System.Drawing;

namespace BomberCommand
{
    class FallingBomb : Bomb
    {
        public FallingBomb(int range, int elevation)
        {
            this.range = range;
            this.elevation = elevation;
        }

        public Bomb Update(
            int planeRange, 
            int planeElevation, 
            bool triggered,
            List<Building> buildings)
        {
            elevation--;

            if (elevation <= 0)
            {
                return new ExplodingBomb(range, 1);
            }

            foreach (var building in buildings)
            {
                building.Update(range, elevation);
            }

            return this;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(
                Brushes.Black, 
                new Rectangle(
                    range * 16, 
                    (40 - elevation) * 16, 
                    16, 16));
        }

        private readonly int range;
        private int elevation;
    }
}
