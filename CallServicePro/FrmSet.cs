using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CallServicePro
{
    public partial class FrmSet : DevExpress.XtraEditors.XtraForm
    {
        public FrmSet()
        {
            InitializeComponent();
        }

       

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Filter = @"MP4|*.mp4|AVI|*.avi",
            };
            ofd.ShowDialog();
            if(ofd.FileName != null)
            {
                txtPath.Text = ofd.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}