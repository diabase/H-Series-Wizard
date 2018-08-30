using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabaseWizard
{
    public partial class frmJobName : Form
    {
        public frmJobName()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Perform validaton here
            btnOK.Enabled = txtName.Text.Trim() != "" && txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }
    }
}
