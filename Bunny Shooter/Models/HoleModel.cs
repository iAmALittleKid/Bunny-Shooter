using System.IO;

namespace Bunny_Shooter.Models
{
    public class HoleModel : ElementModel
    {
        private const string NAME = "Hole";
        private const string IMAGE_PATH = "Hole.png";
        public HoleModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }
    }
}

