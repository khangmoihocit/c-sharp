using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_buoi4
{
    public partial class MDI4Laichau : Form
    {
        public MDI4Laichau()
        {
            InitializeComponent();
        }

        private Form findOpennedForm(string formName)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formName))
                    return f;
            }
            return null;
        }

        private void miniNewForm_Click(object sender, EventArgs e)
        {
            Form f = findOpennedForm("HelloForm");
            if(f == null)
            {
                f = new HelloForm();
                f.MdiParent = this;
                f.Show();
                f.Activate();
            }
        }

        private void miniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDI4Laichau_Load(object sender, EventArgs e)
        {
            
        }
    }
}
