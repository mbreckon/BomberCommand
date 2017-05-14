using System.Drawing;
using System.Drawing.Drawing2D;

namespace BomberCommand
{
    class GDISpriteBasedGraphics : Renderable, BomberCommand.Graphics
    {
        public GDISpriteBasedGraphics(City city)
        {
            this.city = city;

            planeBitmap = new Bitmap(
                BomberCommand.Properties.Resources.plane);

            bombBitmap = new Bitmap(
                BomberCommand.Properties.Resources.bomb);

            buildingBitmap = new Bitmap(
                BomberCommand.Properties.Resources.building1);

            sky = new GDISky();
            
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
            for (int i = 1; i <= height; i++)
            {
                graphics.DrawImage(buildingBitmap,
                    new Point(
                        zone * 16,
                        (40 - i) * 16));
            }
        }

        public void DrawGround()
        {
            new GDIGround()
                .Draw(graphics);
        }

        public void DrawBomb(int range, int elevation)
        {
            graphics.DrawImage(
                bombBitmap,
                new Point(
                    range * 16,
                    (40 - elevation) * 16));
        }

        public void DrawSky(System.Drawing.Color colour)
        {
            sky.Draw(graphics);
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
            graphics.DrawImage(
                planeBitmap,
                range * 16,
                (40 - elevation) * 16);
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
        private readonly Bitmap planeBitmap;
        private readonly Bitmap bombBitmap;
        private readonly Bitmap buildingBitmap;
        private readonly GDISky sky;
    }
}
