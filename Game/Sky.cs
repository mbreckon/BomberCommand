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
            graphics.Clear(colour);
        }

        private Color colour;
    }
}
