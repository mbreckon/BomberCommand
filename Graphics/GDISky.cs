using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BomberCommand
{
    class GDISky
    {
        public GDISky()
        {
            skyBrushes = new List<Brush>() {
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.LightSkyBlue,
                    Color.White),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.SkyBlue,
                    Color.AntiqueWhite),
                //new LinearGradientBrush(
                //    new Point(0, 0),
                //    new Point(0, 680),
                //    Color.CornflowerBlue,
                //    Color.BlanchedAlmond),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.CornflowerBlue,
                    Color.LightYellow),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.CornflowerBlue,
                    Color.Orange),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.BlueViolet,
                    Color.OrangeRed),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.Purple,
                    Color.Blue),
                new LinearGradientBrush(
                    new Point(0, 0),
                    new Point(0, 680),
                    Color.Black,
                    Color.DarkSlateBlue),
            };
        }

        public void Draw(System.Drawing.Graphics graphics)
        {
            frameCount++;

            var brush = frameCount / 180;

            graphics.FillRectangle(
                skyBrushes[brush < skyBrushes.Count ? brush : skyBrushes.Count - 1],
                graphics.VisibleClipBounds);
        }

        private readonly List<Brush> skyBrushes;
        private int frameCount = 0;
    }
}
