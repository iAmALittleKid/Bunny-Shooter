using System;
using System.Collections.Generic;
using System.Windows;
using Bunny_Shooter.ViewModels;

namespace Bunny_Shooter.Models
{
    public abstract class ElementModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Image { get; protected set; }
        public string Type { get; private set; }

        public ElementModel(int xCoordinate, int yCoordinate, string type, string image)
        {
            X = xCoordinate;
            Y = yCoordinate;
            Type = type;
            Image = image;
        }

    }
}

