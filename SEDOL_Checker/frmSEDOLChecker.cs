using _10FA_SEDOL_Validator_casestudy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDOL_Checker
{
    public partial class frmSEDOLChecker : Form
    {
        public frmSEDOLChecker()
        {
            InitializeComponent();
        }

        private void btnSEDOLChecker_Click(object sender, EventArgs e)
        {
            SedolValidationResult Result = (SedolValidationResult)new SedolValidator().ValidateSedol(txtSEDOLChecker.Text);
            List<SedolValidationResult> lstSedolResult = new List<SedolValidationResult>();
            lstSedolResult.Add(Result);
            dgvSEDOLChecker.DataSource = lstSedolResult;
        }
    }
}
