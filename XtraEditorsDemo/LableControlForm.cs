using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace XtraEditorsDemo
{
    public partial class LableControlForm : XtraForm
    {
        public LableControlForm()
        {
            InitializeComponent();
        }

        private void labelControl1_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            XtraMessageBox.Show(e.Link);
        }
    }
}
