using System.Windows.Forms;

namespace BomberCommand
{
    class FrameRate
    {
        public FrameRate(int framesPerSecond, Display display)
        {
            this.framesPerSecond = framesPerSecond;
            this.display = display;

            timer = new Timer();
            timer.Tick += Timer_Tick;
        }

        public void Run()
        {
            timer.Interval = (int)((1.0 / framesPerSecond) * 1000.0);
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            display.NewFrame();
        }

        private readonly Timer timer;
        private readonly int framesPerSecond;
        private readonly Display display;
    }
}
