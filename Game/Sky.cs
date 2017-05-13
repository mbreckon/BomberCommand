using System.Drawing;

namespace BomberCommand
{
    class Sky
    {
        public Sky()
        {
            colour = Color.SkyBlue;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawSky(colour);
        }

        private Color colour;
    }
}
