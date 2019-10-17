using Bunny_Shooter.Interfaces;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class WhiteRabbitModel : ElementModel, IElementMovement
    {
        private const string NAME = "White Rabbit";
        private const string IMAGE_PATH = "WhiteRabbit.png";
        public WhiteRabbitModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }

        public void MoveElement()
        {
            throw new System.NotImplementedException();
        }
    }
}

