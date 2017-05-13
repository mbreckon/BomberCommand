using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberCommand
{
    class ExplodingBomb : Bomb
    {
        public ExplodingBomb(int range, int elevation)
        {
            this.range = range;
            this.elevation = elevation;
            frameCount = 0;
        }

        public Bomb Update(
            int planeRange, 
            int planeElevation, 
            bool triggered, 
            List<Building> buildings)
        {
            frameCount++;
            if (frameCount > 1)
                return new WaitingBomb();
            else
                return this;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawExplosion(range, elevation, frameCount);
        }

        private readonly int range;
        private readonly int elevation;
        private int frameCount;
    }
}
