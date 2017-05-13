using System.Drawing;

namespace BomberCommand
{
    class Ground
    {
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(
                Brushes.DarkOliveGreen, 
                new Rectangle(0, 40 * 16, 40 * 16, 16));
        }
    }
}
