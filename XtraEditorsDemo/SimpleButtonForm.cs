using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XtraEditorsDemo
{
    public partial class SimpleButtonForm : DevExpress.XtraEditors.XtraForm
    {
        public SimpleButtonForm()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            simpleButton4.Text = "我在"+ DateTime.Now + "时候被点击了";
            simpleButton4.Size = simpleButton4.CalcBestSize();
        }
    }
}