using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny_Shooter.ViewModels
{
    public class ElementViewModel : Screen
    {
        private int  _x;
        private int  _y;

        public int X 
        { 
            get { return _x; }
            set
            {
                _x = value;
                NotifyOfPropertyChange(() => X);
            }
        }
        public int Y 
        { 
            get { return _y; }
            set
            {
                _y = value;
                NotifyOfPropertyChange(() => Y);
            }
        }
        public string Image { get; set; }
        public string ElementType { get; set; }

        public (int, int) MoveElement()
        {
            Random rnd = new Random();
            X = rnd.Next(29);
            Y = rnd.Next(19);

            return (X, Y);
        }

    }
}
