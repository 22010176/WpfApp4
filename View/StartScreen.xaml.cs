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

namespace WpfApp4.View
{

  /// <summary>
  /// Interaction logic for StartScreen.xaml
  /// </summary>
  public partial class StartScreen : UserControl
  {
    private readonly MainWindow Parent;
    public StartScreen()
    {
      InitializeComponent();
      DataContext = this;
      Parent = MainWindow.GetMainWindow();
    }

    private void QuitBtn_Click(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void PlayBtn_Click(object sender, RoutedEventArgs e)
    {
      Parent._MainContent.contentControl.Content = new PlayScreen();
    }
  }
}
