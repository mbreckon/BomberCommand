using System.Collections.Generic;

namespace BomberCommand
{
    interface Bomb
    {
        Bomb Update(
            int planeRange, 
            int planeElevation, 
            bool triggered, 
            List<Building> buildings);

        void Draw(Graphics graphics);
    }
}
