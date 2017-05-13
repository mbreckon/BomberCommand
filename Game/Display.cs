using System.Windows.Forms;

namespace BomberCommand
{
    class Display
    {
        public Display(Control control, Renderable renderable)
        {
            this.control = control;
            this.renderable = renderable;

            this.control.Paint += Control_Paint;
        }

        public void NewFrame()
        {
            renderable.Update();
            control.Refresh();
        }

        private void Control_Paint(object sender, PaintEventArgs e)
        {
            renderable.Draw(e.Graphics);
        }

        private Control control;
        private Renderable renderable;
    }
}
