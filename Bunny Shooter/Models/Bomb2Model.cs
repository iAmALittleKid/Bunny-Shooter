using Bunny_Shooter.Interfaces;
using System;
using System.IO;

namespace Bunny_Shooter.Models
{
    public class Bomb2Model : ElementModel, IElementMovement
    {
        private const string NAME = "Bomb2";
        private const string IMAGE_PATH = "Bomb2.png";
        public Bomb2Model(int xCoordinate, int yCoordinate) : base(xCoordinate, yCoordinate, NAME, Path.GetFullPath($@"Assets\{IMAGE_PATH}")) {}

        public void MoveElement()
        {
            throw new NotImplementedException();
        }
    }
}
