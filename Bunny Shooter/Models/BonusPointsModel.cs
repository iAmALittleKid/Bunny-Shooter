using Bunny_Shooter.Interfaces;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class BonusPointsModel : ElementModel, IElementMovement
    {
        private const string NAME = "Points";
        private const string IMAGE_PATH = @"C:\Users\Jose\Desktop\Academy\Bunny Shooter\Bunny Shooter\Assets\Points.png";
        public BonusPointsModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }

        public void MoveElement()
        {
            throw new System.NotImplementedException();
        }
    }
}
