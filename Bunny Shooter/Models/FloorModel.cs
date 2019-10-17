using System.IO;

namespace Bunny_Shooter.Models
{
    public class FloorModel : ElementModel
    {
        private const string NAME = "Floor";
        private const string IMAGE_PATH = "Floor.png";
        public FloorModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }
    }
}

