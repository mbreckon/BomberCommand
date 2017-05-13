using System.Drawing;

namespace BomberCommand
{
    class GDIBomb
    {
        public GDIBomb(int range, int elevation)
        {
            this.range = range;
            this.elevation = elevation;
        }

        public void Draw(System.Drawing.Graphics graphics)
        {
            graphics.FillEllipse(
                Brushes.Black,
                new Rectangle(
                    range * 16,
                    (40 - elevation) * 16,
                    16, 16));
        }

        private readonly int range;
        private readonly int elevation;
    }
}
