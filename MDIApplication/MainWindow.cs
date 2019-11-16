using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class MainWindow : Form
    {

        // Windows for to show child window open and sorting demo. 
        //Also has a button that opens printer setup dialog when clicked


        public MainWindow()
        {
            InitializeComponent();            
        }


        // added a button hide method call so that button1 doesnt show in front of child windows
        // when child windows are created
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            button1.Hide();
            child.MdiParent = this;
            child.Show();
            
            
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            
        }
        

        // clicking the button opens up printer setup
        private void button1_Click(object sender, EventArgs e)
        {
           
                printDialog1.ShowDialog();
                Refresh();         


        }     



    }
}
