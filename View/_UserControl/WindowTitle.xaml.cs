using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4.View._UserControl
{
  /// <summary>
  /// Interaction logic for WindowTitle.xaml
  /// </summary>
  public partial class WindowTitle : UserControl
  {
    public WindowTitle()
    {
      InitializeComponent();
    }

    private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (App.Current.MainWindow.WindowState == WindowState.Maximized) App.Current.MainWindow.WindowState = WindowState.Normal;
      Application.Current.MainWindow.DragMove();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }
    private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.MainWindow.WindowState = WindowState.Minimized;
    }

    private void WindowSizeChangeBtn_Click(object sender, RoutedEventArgs e)
    {
      CheckBox checkBox = (CheckBox)sender;
      App.Current.MainWindow.WindowState = App.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    }
  }
}
