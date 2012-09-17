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

namespace MVP.WPF
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window, IView
   {
      private IPresenter _presenter;

      public MainWindow()
      {
         InitializeComponent();
         _presenter = new Presenter(this, new PersonRepository());
      }

      public void NotifyOfInvalidation(string message)
      {
         ValidationLabel.Content = message;
      }

      public void NotifyOfSuccess()
      {
         ValidationLabel.Content = "Person Saved!";
      }

      private void button1_Click(object sender, RoutedEventArgs e)
      {
         _presenter.SaveNewPerson(txtBox_name.Text, txtBox_email.Text);
      }
   }
}
