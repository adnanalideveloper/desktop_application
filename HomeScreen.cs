using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userLable.Text = retrieval.EMP_NAME;
            
            MDI.logoutToolStripMenuItem.Enabled = true;
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showwindow(u, this,MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            MainClass.showwindow(u, this, MDI.ActiveForm);
        }

        private void proDD_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showwindow(u, this, MDI.ActiveForm);
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showwindow(u, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showwindow(u, this, MDI.ActiveForm);
        }
    }
}
