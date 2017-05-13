using System;
using System.Windows.Forms;

namespace BomberCommand
{
    class KeyboardInput
    {
        public KeyboardInput(Control control)
        {
            control.KeyDown += Control_KeyDown;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                SpacePressed?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SpacePressed;
    }
}
