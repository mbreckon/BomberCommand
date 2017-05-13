using System.Windows.Forms;

namespace BomberCommand
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            new FrameRate(
                5,
                new Display(
                    this,
                    new GDIGraphics(
                        new City(
                            new Buildings(
                                new HeightRange(0, 30)
                                ).Build(40),
                            new FlyingPlane(
                                new BombTrigger(
                                    new KeyboardInput(this)
                                )
                            )
                        )
                    )
                )
            ).Run();
        }
    }
}
