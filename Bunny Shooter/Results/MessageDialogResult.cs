using Caliburn.Micro;
using System.Windows;

namespace Bunny_Shooter.Results
{
    public class MessageDialogResult : ResultBase
    {
        private readonly string content;
        private readonly string title;

        public MessageDialogResult(string content, string title)
        {
            this.content = content;
            this.title = title;
        }

        public override async void Execute(CoroutineExecutionContext context)
        {
            //var dialog = new MessageDialog(content, title);

            //await dialog.ShowAsync();

            MessageBox.Show(content, title, MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK,
                MessageBoxOptions.None);

            OnCompleted();
        }

    }
}
