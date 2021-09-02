using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vazelinWF
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (progressBar1.Value >= 11)
        progressBar1.Value -= 10;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      progressBar1.Value++;
      if (progressBar1.Value >= 99)
        progressBar1.Value = 0;
    }
  }
}
