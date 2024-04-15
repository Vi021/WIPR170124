using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR170124
{
    public partial class StuSeacrhFrm : Form
    {
        public StuSeacrhFrm()
        {
            InitializeComponent();
        }

        private void SeacrhForm_Load(object sender, EventArgs e)
        {
            DaTi_stuBrthDate.MaxDate = DateTime.Now;
            DaTi_stuBrthDate.Value = DateTime.Now.AddMinutes(-1);
        }
    }
}
