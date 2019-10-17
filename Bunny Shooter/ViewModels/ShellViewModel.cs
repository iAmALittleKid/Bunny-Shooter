using Caliburn.Micro;

namespace Bunny_Shooter.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void LoadBoard()
        {
            var boardVm = new BoardViewModel();
            boardVm.LoadElements();
            ActivateItem(boardVm);
        }
    }
}
