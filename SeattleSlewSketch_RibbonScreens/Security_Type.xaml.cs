using System;
using System.Collections.Generic;
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

namespace SeattleSlewSketch_RibbonScreens
{
	/// <summary>
	/// Interaction logic for Security_Type.xaml
	/// </summary>
	public partial class Security_Type : UserControl
	{
		public Security_Type()
		{
			this.InitializeComponent();
		}
//  public bool NavigatioPaneOff
//  {
//   get { return navigationPane.Visibility == System.Windows.Visibility.Collapsed; }
//   set 
//   { 
//    navigationPane.Visibility = value ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible; 
//   }
//  }
  public bool ExpanderPaneOff
  {
   get { return navigationPaneExpander.Visibility == System.Windows.Visibility.Collapsed; }
   set
   {
    navigationPaneExpander.Visibility = value ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible;
   }
  }
  
  private void navigationPaneExpander_CloseButtonClick(object sender, RoutedEventArgs e)
  {

  }


//  private void button1_Click(object sender, RoutedEventArgs e)
//  {
//   System.IO.MemoryStream ms = new System.IO.MemoryStream();
//   navigationPane.SaveState(ms);
//   ms.Position = 0;
//   NavigationPaneDemo.Properties.Settings.Default.NavigationPaneSettings = new System.IO.StreamReader(ms).ReadToEnd();
//
//   // Load settings 
//   navigationPane.LoadState(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(NavigationPaneDemo.Properties.Settings.Default.NavigationPaneSettings))); 
//
//  }

//  private void Button_Click_1(object sender, RoutedEventArgs e)
//  {
//   System.IO.MemoryStream ms = new System.IO.MemoryStream();
//   navigationPane.SaveState(ms);
//   ms.Position = 0;
//   NavigationPaneDemo.Properties.Settings.Default.NavigationPaneSettings = new System.IO.StreamReader(ms).ReadToEnd(); 
//   // settings are correctly saved
//   //NavigationPaneDemo.Properties.Settings.Default.Reset();
//  }

//  private void Button_Click_2(object sender, RoutedEventArgs e)
//  {
//   // Load settings 
//   navigationPane.LoadState(); 
//
//  }

//  private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
//  {
//   //Button_Click_2(this, null);
//   navigationPane.IsMinimized = true;
//  }

//  private void navigationPane_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
//  {
//  	// TODO: Add event handler implementation here.
//  }
// }

// class test:IValueConverter
// {
//
//  public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
//  {
//   return parameter;
//  }
//
//  public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
//  {
//   return value;
//  }
// }

// class NavigationPaneExpandConverter: IMultiValueConverter
// {
//  public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
//  {
//   return values[0];
//  }

  public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
  {
   return new object[]{value, value};
  }
 }
}
