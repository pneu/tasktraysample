using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTray
{
    public partial class TaskTrayAppForm : Form
    {
        public TaskTrayAppForm()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIconTaskTray.Visible = false;
            Application.Exit();
        }
    }
}
