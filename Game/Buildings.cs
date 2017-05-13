using System.Collections.Generic;
using System.Linq;

namespace BomberCommand
{
    /// <summary>
    /// Creates a series of random height buildings
    /// based on a given range
    /// </summary>
    class Buildings
    {
        public Buildings(HeightRange heightRange)
        {
            this.heightRange = heightRange;
        }

        public List<Building> Build(int zones)
        {
            return Enumerable.Range(0, zones)
                .Select(zone =>
                    new Building(
                        zone,
                        heightRange.GenerateRandomHeight()))
                .ToList();
        }

        private readonly HeightRange heightRange;
    }
}
