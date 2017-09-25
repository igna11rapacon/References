using SampleEntityFrameworkAccess;
using SampleEntityFrameworkContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credential credential = new Credential();
            //credential.Username = "sample";
            //credential.Username = "password";
            using (var ctx = new Context())
            {
                var result = ctx.Credentials.FirstOrDefault(xxx => xxx.Username == "sample");
                credential = result;
            }
        }
    }
}
