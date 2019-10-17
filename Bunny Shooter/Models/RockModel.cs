using System.IO;

namespace Bunny_Shooter.Models
{
    public class RockModel : ElementModel
    {
        private const string NAME = "Rock";
        private const string IMAGE_PATH = "Rock.png";
        public RockModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }
    }
}
