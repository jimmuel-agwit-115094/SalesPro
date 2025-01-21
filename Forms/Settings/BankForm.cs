using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPro.Forms.Settings
{
    public partial class BankForm : Form
    {
        public string _actionForm;
        public int _bankId;
        public int _bankRowVersion;

        public BankForm()
        {
            InitializeComponent();
        }
    }
}
