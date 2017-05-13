using System.Collections.Generic;
using System.Drawing;

namespace BomberCommand
{
    interface Plane
    {
        Plane Update(List<Building> buildings);
        void Draw(Graphics graphics);
    }
}
