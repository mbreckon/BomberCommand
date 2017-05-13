using System.Drawing;

namespace BomberCommand
{
    class GDIGround
    {
        public void Draw(System.Drawing.Graphics graphics)
        {
            graphics.FillRectangle(
                Brushes.DarkOliveGreen,
                    new Rectangle(0, 40 * 16, 40 * 16, 16));
        }
    }
}
