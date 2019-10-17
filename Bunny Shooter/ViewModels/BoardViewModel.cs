using Bunny_Shooter.Models;
using Bunny_Shooter.Results;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Bunny_Shooter.ViewModels
{
    public class BoardViewModel : Conductor<object>
    {
        private BindableCollection<ElementViewModel> _boardElements;
        
        public BindableCollection<ElementViewModel> BoardElements
        {
            get => _boardElements;
            set
            {
                _boardElements = value;
                NotifyOfPropertyChange(() => BoardElements);
            }
        }

        public BoardViewModel()
        {
            LoadElements();
        }

        public void LoadElements()
        {
            var elements = BoardModel.Board();
            var elementVms = elements.Select(e => new ElementViewModel()
            {
                Image = e.Image,
                ElementType = e.Type,
                X = e.X,
                Y = e.Y
            })
                .ToList();


            //var whiteRabbitModel = new WhiteRabbitModel(0, 0);
            //var greyRabbitModel = new GreyRabbitModel(0, 1);


            //var greyRabbitVm = new ElementViewModel()
            //{ ElementType = greyRabbitModel.Type, Image = greyRabbitModel.Image, X = greyRabbitModel.X, Y = greyRabbitModel.Y };

            //elementVms.Insert(0, greyRabbitVm);

            //var whiteRabbitVm = new ElementViewModel()
            //{ ElementType = whiteRabbitModel.Type, Image = whiteRabbitModel.Image, X = whiteRabbitModel.X, Y = whiteRabbitModel.Y };

            //elementVms.Insert(0, whiteRabbitVm);


            BoardElements = new BindableCollection<ElementViewModel>(elementVms);
        }

        public IEnumerable<IResult> ShowMessage(ElementViewModel element)
        {
            yield return new MessageDialogResult(
                $"ElementType: {element.ElementType}, PosX: {element.X}, PosY: {element.Y}",   "ElementClicked");
        }

    }
}