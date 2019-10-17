using Bunny_Shooter.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Bunny_Shooter.Views
{
    /// <summary>
    /// Interaction logic for BoardView.xaml
    /// </summary>
    public partial class BoardView : UserControl
    {
        public BoardView()
        {
            InitializeComponent();
            BoardElements = new BoardViewModel().BoardElements;
            Loaded += BoardGrid;
        }

        public BindableCollection<ElementViewModel> BoardElements { get; set; }

        public Image CreateImage(ElementViewModel element)
        {
            Image elementImage = new Image();
            ImageSource elementImageSource = new BitmapImage(new Uri(element.Image));
            elementImage.Source = elementImageSource;
            return elementImage;
        }

        private void BoardGrid(object sender, RoutedEventArgs e)
        {

            Grid elementGrid = new Grid();

            foreach (ElementViewModel element in BoardElements)
            {
                var maxcol = element.X+1;
                var maxrow = element.Y+1;

                var elementImage = CreateImage(element);

                for (int i = 0; i < maxcol; i++)
                {
                    var cd = new ColumnDefinition();
                    cd.Width = new GridLength(40);
                    elementGrid.ColumnDefinitions.Add(cd);
                    Grid.SetColumn(elementImage, i);

                    for (int j = 0; j < maxrow; j++)
                    {
                        var rd = new RowDefinition();
                        rd.Height = new GridLength(40);
                        elementGrid.RowDefinitions.Add(rd);
                        Grid.SetRow(elementImage, j);
                    }
                }
                elementGrid.Children.Add(elementImage);
            }
            LayoutRoot.Children.Add(elementGrid);
        } 
    }
}
