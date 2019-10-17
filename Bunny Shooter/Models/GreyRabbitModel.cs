using Bunny_Shooter.Interfaces;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class GreyRabbitModel : ElementModel, IElementMovement
    {
        private const string NAME = "Grey Rabbit";
        private const string IMAGE_PATH = "GreyRabbit.png";
        public GreyRabbitModel(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) { }

        public void MoveElement()
        {
            throw new System.NotImplementedException();
        }
    }
}

