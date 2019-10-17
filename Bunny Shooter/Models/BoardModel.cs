using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bunny_Shooter.Models
{
    public class BoardModel
    {
        public static List<ElementModel> Board()
        {
            var path = Path.GetFullPath(@"Assets\Scenery.txt");
            return GetSceneryElements(path);
        }
        private static List<ElementModel> GetSceneryElements(string pathToFile)
        {
            string[] scenery = File.ReadLines(pathToFile).ToArray();

            List<ElementModel> elementsList = new List<ElementModel>();

            for (int row = 0; row < scenery.Length; row++)
            {
                var line = scenery[row];

                var lineChars = line.Split('\t');

                for (int col = 0; col < lineChars.Length; col++)
                {
                    var type = lineChars[col];

                    if (type == "H")
                    {
                        elementsList.Add(new HoleModel(col, row));
                    }
                    else if (type == "R")
                    {
                        elementsList.Add(new RockModel(col, row));
                    }
                    else if (type == "B")
                    {
                        elementsList.Add(new BushModel(col, row));
                    }
                    else
                    {
                        elementsList.Add(new FloorModel(col, row));
                    }
                }
            }
            return elementsList;
        }
    }
}
