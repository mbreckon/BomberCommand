using System.Drawing;

namespace BomberCommand
{
    interface Renderable
    {
        void Update();
        void Draw(Graphics g);
    }
}