using System.Collections.Generic;

namespace BomberCommand
{
    interface Plane
    {
        Plane Update(List<Building> buildings);
        void Draw(Graphics graphics);
    }
}
