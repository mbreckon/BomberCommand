using System.Collections.Generic;

namespace BomberCommand
{
    class City
    {
        public City(
            List<Building> buildings, 
            Plane plane)
        {
            this.buildings = buildings;
            this.plane = plane;

            sky = new Sky();
            ground = new Ground();
        }

        public void Update()
        {
            plane = plane.Update(buildings);
        }

        public void Draw(Graphics graphics)
        {
            sky.Draw(graphics);
            foreach (var building in buildings)
            {
                building.Draw(graphics);
            }
            ground.Draw(graphics);
            plane.Draw(graphics);
        }

        private readonly Sky sky;
        private readonly Ground ground;
        private readonly List<Building> buildings;

        private Plane plane;
    }
}
