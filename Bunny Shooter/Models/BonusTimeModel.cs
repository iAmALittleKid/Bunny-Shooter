using Bunny_Shooter.Interfaces;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class BonusTimeModel : ElementModel, IElementMovement
    {
        private const string NAME = "Clock";
        private const string IMAGE_PATH = "Clock.png";
        public BonusTimeModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }

        public void MoveElement()
        {
            int _x = X;
            int _y = Y;
        }
    }
}
