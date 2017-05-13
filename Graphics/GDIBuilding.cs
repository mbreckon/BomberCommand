using System.Drawing;

namespace BomberCommand
{
    class GDIBuilding
    {
        public GDIBuilding(int zone, int height)
        {
            this.zone = zone;
            this.height = height;
        }

        public void Draw(System.Drawing.Graphics graphics)
        {
            var pixelHeight = 16 * height;

            graphics.FillRectangle(
                Brushes.Black,
                new Rectangle(
                    zone * 16,
                    (40 * 16) - pixelHeight,
                    16,
                    pixelHeight));
        }

        private readonly int height;
        private readonly int zone;
    }
}
