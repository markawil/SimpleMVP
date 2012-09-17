namespace MVP.WinForms
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btn_Save = new System.Windows.Forms.Button();
         this.btn_Cancel = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtBox_name = new System.Windows.Forms.TextBox();
         this.txtBox_email = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lbl_Success = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btn_Save
         // 
         this.btn_Save.Location = new System.Drawing.Point(46, 166);
         this.btn_Save.Name = "btn_Save";
         this.btn_Save.Size = new System.Drawing.Size(75, 23);
         this.btn_Save.TabIndex = 0;
         this.btn_Save.Text = "Save";
         this.btn_Save.UseVisualStyleBackColor = true;
         this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
         // 
         // btn_Cancel
         // 
         this.btn_Cancel.Location = new System.Drawing.Point(158, 166);
         this.btn_Cancel.Name = "btn_Cancel";
         this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
         this.btn_Cancel.TabIndex = 1;
         this.btn_Cancel.Text = "Cancel";
         this.btn_Cancel.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(46, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(38, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Name:";
         // 
         // txtBox_name
         // 
         this.txtBox_name.Location = new System.Drawing.Point(49, 44);
         this.txtBox_name.Name = "txtBox_name";
         this.txtBox_name.Size = new System.Drawing.Size(184, 20);
         this.txtBox_name.TabIndex = 3;
         // 
         // txtBox_email
         // 
         this.txtBox_email.Location = new System.Drawing.Point(49, 101);
         this.txtBox_email.Name = "txtBox_email";
         this.txtBox_email.Size = new System.Drawing.Size(184, 20);
         this.txtBox_email.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(46, 84);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(35, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Email:";
         // 
         // lbl_Success
         // 
         this.lbl_Success.AutoSize = true;
         this.lbl_Success.Location = new System.Drawing.Point(46, 130);
         this.lbl_Success.Name = "lbl_Success";
         this.lbl_Success.Size = new System.Drawing.Size(82, 13);
         this.lbl_Success.TabIndex = 6;
         this.lbl_Success.Text = "Info Not Saved.";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 229);
         this.Controls.Add(this.lbl_Success);
         this.Controls.Add(this.txtBox_email);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtBox_name);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btn_Cancel);
         this.Controls.Add(this.btn_Save);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btn_Save;
      private System.Windows.Forms.Button btn_Cancel;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtBox_name;
      private System.Windows.Forms.TextBox txtBox_email;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lbl_Success;
   }
}

