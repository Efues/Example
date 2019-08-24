using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
  public partial class MainForm : Form
  {
    private SubForm subform;

    public MainForm()
    {
      InitializeComponent();
    }

    private void Subform_FormClosed(object sender, FormClosedEventArgs e)
    {
      textBoxStatus.AppendText("sub formが閉じられました");
      textBoxStatus.AppendText(System.Environment.NewLine);
    }

    private void buttonOpenSubform_Click(object sender, EventArgs e)
    {
      if(subform == null || subform.IsDisposed)
      {
        subform = new SubForm();
        subform.FormClosed += Subform_FormClosed;
      }
      if(subform.Visible)
      {
        textBoxStatus.AppendText("すでにsub formは表示されています");
        textBoxStatus.AppendText(System.Environment.NewLine);
      }
      else
      {
        subform.Show();
        textBoxStatus.AppendText("sub formが開かれました");
        textBoxStatus.AppendText(System.Environment.NewLine);
      }
    }
  }
}
