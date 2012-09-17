using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVP.Model;
using MVP.PresentationLayer;

namespace MVP.WinForms
{
   public partial class Form1 : Form, IView
   {
      private IPresenter _presenter;

      public Form1()
      {
         InitializeComponent();
         _presenter = new Presenter(this, new PersonRepository());
      }

      public void NotifyOfInvalidation(string message)
      {
         lbl_Success.Text = message;
      }

      public void NotifyOfSuccess()
      {
         lbl_Success.Text = "Person Saved!";
      }

      private void btn_Save_Click(object sender, EventArgs e)
      {
         _presenter.SaveNewPerson(txtBox_name.Text, txtBox_email.Text);
      }
   }
}
