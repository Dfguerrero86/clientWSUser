using System;
using System.Windows.Forms;

namespace clientWSUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsUser.Service1Client oClient = new wsUser.Service1Client();
            String res = oClient.getApellidoPersona("1085254773");
            MessageBox.Show(res.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
