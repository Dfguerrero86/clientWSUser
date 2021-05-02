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

        private void Form1_Load(object sender, EventArgs e)
        {
            wsUser.Service1Client oClient = new wsUser.Service1Client();
            dataGridView.DataSource = oClient.getPersonas();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                var form2 = new Form2(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), false);
                form2.Show();
            }
            if (e.ColumnIndex == 5)
            {
                var form2 = new Form2(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), true);
                form2.Show();
            }
            if (e.ColumnIndex == 6)
            {
                wsUser.Service1Client oClient = new wsUser.Service1Client();
                Int64 res=oClient.deletePersona(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                MessageBox.Show(res==1?"Eliminado":"No Eliminado");
                dataGridView.DataSource = oClient.getPersonas();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(null, true);
            form2.Show();
        }
    }
}
