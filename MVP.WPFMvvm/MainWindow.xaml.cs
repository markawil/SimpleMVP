using System;
using System.Collections.Generic;
using System.Linq;
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
using MVP.Model;
using MVP.PresentationLayer;

namespace MVP.WPFMvvm
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      private ViewModel _vm;
      public MainWindow()
      {
         InitializeComponent();

         _vm = new ViewModel(new PersonRepository());
         this.DataContext = _vm;
      }

      private void button1_Click(object sender, RoutedEventArgs e)
      {
         _vm.SaveNewPerson(txtBox_name.Text, txtBox_email.Text);
      }
   }
}
