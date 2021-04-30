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
            wsUser.Service1Client oClient = new wsUser.Service1Client();
            dataGridView.DataSource = oClient.getPersonas();
            //dataGridView.Columns[5].


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) {
                wsUser.Service1Client oClient = new wsUser.Service1Client();
                wsUser.Persona persona = oClient.getPersona(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                MessageBox.Show("Tipo Documento: " + persona.TipoDocumento + "\nNúmero Documento: " + persona.NumeroDocumento
                    + "\nPrimer Nombre: " + persona.PrimerNombre + "\nSegundo Nombre: " + persona.SegundoNombre
                    + "\nPrimer Apellido: " + persona.PrimerApellido + "\nSegundo Apellido: " + persona.SegundoApellido
                    + "\nGrupo Sanguineo: " + persona.GrupoSanguineo + "\nSexo: " + persona.Sexo
                    + "\nDirección: " + persona.Direccion + "\nCelular: " + persona.Celular);
            }
            if (e.ColumnIndex == 5)
            {
                wsUser.Service1Client oClient = new wsUser.Service1Client();
                Int64 res=oClient.deletePersona(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                MessageBox.Show(res==1?"Eliminado":"No Eliminado");
                dataGridView.DataSource = oClient.getPersonas();
            }
        }
    }
}
