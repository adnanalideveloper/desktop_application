using System;                   // library start 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
                               // library close      
namespace ims
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)  //mdi event start
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // set string path
            if(File.Exists(Path+"\\connect")) // set if condition with connect file
            {
                login log = new login(); // created login class
                MainClass.showwindow(log, this); // go to showwindow mathed on main class
            }
           else
            {
                settings set = new settings();
                MainClass.showwindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            MainClass.showwindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login set = new login();
            MainClass.showwindow(set, this);
            
            MDI.logoutToolStripMenuItem.Enabled = false;
        }
    }
}
