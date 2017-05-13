using System.Drawing;

namespace BomberCommand
{
    class GDIGraphics : Renderable, BomberCommand.Graphics
    {
        public GDIGraphics(City city)
        {
            this.city = city;
            font = new Font("Console", 48.0f);
        }

        public void Update()
        {
            city.Update();
        }

        public void Draw(System.Drawing.Graphics graphics)
        {
            this.graphics = graphics;
            city.Draw(this);
        }

        public void DrawBuilding(int zone, int height)
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

        public void DrawGround()
        {
            graphics.FillRectangle(
                Brushes.DarkOliveGreen,
                new Rectangle(0, 40 * 16, 40 * 16, 16));
        }

        public void DrawBomb(int range, int elevation)
        {
            graphics.FillEllipse(
                Brushes.Black,
                new Rectangle(
                    range * 16,
                    (40 - elevation) * 16,
                    16, 16));
        }

        public void DrawSky(System.Drawing.Color colour)
        {
            graphics.Clear(colour);
        }

        public void DrawExplosion(int range, int elevation, int frame)
        {
            if (frame == 0)
            {
                graphics.FillEllipse(
                    Brushes.Yellow,
                    new Rectangle(
                        (range * 16),
                        ((40 - elevation) * 16),
                        16, 16));
            }
            else
            {
                graphics.FillEllipse(
                    Brushes.Orange,
                    new Rectangle(
                        (range * 16) - 4,
                        ((40 - elevation) * 16) - 4,
                        28, 28));
            }
        }

        public void DrawFailMessage()
        {
            graphics.DrawString(
                "You failed!", 
                font, 
                Brushes.White, 
                new PointF(100, 300));
        }

        public void DrawLandedPlane(int range, int elevation)
        {
            graphics.FillRectangle(
                Brushes.Blue,
                new Rectangle(
                    range * 16,
                    (40 - elevation) * 16,
                    16, 16));
        }

        public void DrawFlyingPlane(int range, int elevation)
        {
            graphics.FillRectangle(
                Brushes.Black,
                new Rectangle(
                    range * 16,
                    (40 - elevation) * 16,
                    16, 16));
        }

        public void DrawSuccessMessage()
        {
            graphics.DrawString(
                "You won!", 
                font, 
                Brushes.White, 
                new PointF(100, 300));
        }

        private System.Drawing.Graphics graphics;

        private readonly City city;
        private readonly Font font;
    }
}