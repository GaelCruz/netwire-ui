using Avalonia.Controls;
using yt_tutorial.ViewModels;

namespace yt_tutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
        {
            if (e.ClickCount != 2)
            {
                return;
            }

            (DataContext as MainViewModel)?.SideMenuResizeCommand?.Execute(null);
        }

    }
}