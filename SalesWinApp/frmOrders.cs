using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        //Fields
        public bool IsAdmin { get; set; }


        public frmOrders()
        {
            InitializeComponent();
            RaiseEvent();
        }

        private void RaiseEvent()
        {

        }
    }
}
