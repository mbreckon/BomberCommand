using System.Collections.Generic;

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
                    planeElevation - 1);
            }

            return this;
        }

        public void Draw(Graphics g)
        {

        }
    }
}
