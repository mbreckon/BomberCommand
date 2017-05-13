using System.Collections.Generic;
using System.Drawing;

namespace BomberCommand
{
    /// <summary>
    /// A bomb that is waiting to be triggered
    /// </summary>
    class WaitingBomb : Bomb
    {
        public Bomb Update(
            int planeRange,
            int planeElevation, 
            bool triggered,
            List<Building> buildings)
        {
            if (triggered)
            {
                return new FallingBomb(
                    planeRange, 
                    planeElevation);
            }

            return this;
        }

        public void Draw(Graphics g)
        {

        }
    }
}
