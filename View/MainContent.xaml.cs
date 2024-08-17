using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
  /// Interaction logic for MainContent.xaml
  /// </summary>
  public partial class MainContent : UserControl, INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;
    
    public MainContent()
    {
      InitializeComponent();
      DataContext = this;
      contentControl.Content = new StartScreen();
    }
    void OnPropertyChange([CallerMemberName] string? property= "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
  }
}
