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
  /// Interaction logic for PlayScreen.xaml
  /// </summary>
  public partial class PlayScreen : UserControl
  {

    bool isSpinning;
    public bool IsSpinning
    {
      get => isSpinning;
      set { isSpinning = value; }
    }

    public PlayScreen()
    {
      InitializeComponent();
      DataContext = this;
      IsSpinning = false;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      MainWindow.GetMainWindow()._MainContent.contentControl.Content = new StartScreen();
    }
  }
}
