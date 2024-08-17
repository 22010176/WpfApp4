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
  /// Interaction logic for PlayerSide.xaml
  /// </summary>
  public partial class PlayerSide : UserControl
  {
    public string PlayerName { get; set; }

    public static readonly DependencyProperty IsSpinningProperty = DependencyProperty.Register(
      "IsSpinning",
      typeof(bool),
      typeof(PlayScreen),
      new PropertyMetadata(false)
    );

    public bool IsSpinning
    {
      get => (bool)GetValue(IsSpinningProperty);
      set
      {
        SetValue(IsSpinningProperty, (bool)value);
      }
    }
    public PlayerSide()
    {
      InitializeComponent();
      DataContext = this;
      IsSpinning = false;
    }
  }
}
