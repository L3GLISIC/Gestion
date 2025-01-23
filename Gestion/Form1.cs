using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.View;

namespace Gestion
{
    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }

        private void proprietaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProprietaire frm = new frmProprietaire();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAppartement frm = new frmAppartement();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}
