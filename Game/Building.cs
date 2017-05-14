namespace BomberCommand
{
    class Building
    {
        public Building(int zone, int height)
        {
            this.zone = zone;
            this.height = height;
        }

        public void Update(int bombZone, int bombHeight)
        {
            if (bombZone == zone)
            {
                height = (bombHeight <= height) ? 
                    (bombHeight - 1) : height;
            }
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawBuilding(zone, height);
        }

        public bool Collides(int zone, int elevation)
            => (zone == this.zone) && (elevation <= this.height);

        private readonly int zone;
        private int height;
    }
}
