using System.IO;

namespace Bunny_Shooter.Models
{
    public class BushModel : ElementModel
    {
        private const string NAME = "Bush";
        private const string IMAGE_PATH = "Bush.png";
        public BushModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }
    }
}