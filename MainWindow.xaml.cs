using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public static MainWindow GetMainWindow()
    {
      return (MainWindow)App.Current.MainWindow;
    }
    public MainWindow()
    {
      InitializeComponent();
    }

    private void TestBtm_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}