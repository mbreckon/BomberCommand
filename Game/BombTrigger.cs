using System;
using System.Collections.Generic;

namespace BomberCommand
{
    class BombTrigger
    {
        public BombTrigger(
            KeyboardInput input)
        {
            bomb = new WaitingBomb();
            triggered = false;

            input.SpacePressed += Input_SpacePressed;
        }

        private void Input_SpacePressed(object sender, EventArgs e)
        {
            triggered = true;
        }

        public void Update(
            int planeRange, 
            int planeElevation, 
            List<Building> buildings)
        {
            bomb = bomb.Update(
                planeRange,
                planeElevation,
                triggered, 
                buildings);

            triggered = false;
        }

        public void Draw(Graphics graphics)
        {
            bomb.Draw(graphics);
        }

        private Bomb bomb;
        private bool triggered;
    }
}
