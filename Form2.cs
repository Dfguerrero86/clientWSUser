using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientWSUser
{
    public partial class Form2 : Form
    {
        String documento = "";
        public Form2(String documento, bool enabled)
        {
            InitializeComponent();
            if (documento != null && !"".Equals(documento) && enabled == true)
            {
                this.documento = documento;
                this.Text = "Actualizar Persona";
                this.button1.Text = "Actualizar Persona";
                wsUser.Service1Client oClient = new wsUser.Service1Client();
                wsUser.Persona persona = oClient.getPersona(documento);
                txtTipoDocumento.Text = persona.TipoDocumento;
                txtTipoDocumento.Enabled = false;
                txtNumeroDocumento.Text = persona.NumeroDocumento;
                txtNumeroDocumento.ReadOnly = true;
                txtPrimerNombre.Text = persona.PrimerNombre;
                txtSegundoNombre.Text = persona.SegundoNombre;
                txtPrimerApellido.Text = persona.PrimerApellido;
                txtSegundoApellido.Text = persona.SegundoApellido;
                txtGrupoSanguineo.Text = persona.GrupoSanguineo;
                txtSexo.Text = persona.Sexo;
                txtDireccion.Text = persona.Direccion;
                txtCelular.Text = persona.Celular;
            } else if (documento != null && !"".Equals(documento) && enabled == false) {
                this.Text = "Detalle Persona";
                this.button1.Text = "Detalle Persona";
                this.button1.Visible = false;
                wsUser.Service1Client oClient = new wsUser.Service1Client();
                wsUser.Persona persona = oClient.getPersona(documento);
                txtTipoDocumento.Text = persona.TipoDocumento;
                txtTipoDocumento.Enabled = false;
                txtNumeroDocumento.Text = persona.NumeroDocumento;
                txtNumeroDocumento.Enabled = false;
                txtPrimerNombre.Text = persona.PrimerNombre;
                txtPrimerNombre.Enabled = false;
                txtSegundoNombre.Text = persona.SegundoNombre;
                txtSegundoNombre.Enabled = false;
                txtPrimerApellido.Text = persona.PrimerApellido;
                txtPrimerApellido.Enabled = false;
                txtSegundoApellido.Text = persona.SegundoApellido;
                txtSegundoApellido.Enabled = false;
                txtGrupoSanguineo.Text = persona.GrupoSanguineo;
                txtGrupoSanguineo.Enabled = false;
                txtSexo.Text = persona.Sexo;
                txtSexo.Enabled = false;
                txtDireccion.Text = persona.Direccion;
                txtDireccion.Enabled = false;
                txtCelular.Text = persona.Celular;
                txtCelular.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsUser.Service1Client oClient = new wsUser.Service1Client();
            wsUser.Persona personaUpd = new wsUser.Persona();
            //Validaciones Agregar
            if (txtTipoDocumento.Text == null || "".Equals(txtTipoDocumento.Text) || txtNumeroDocumento.Text == null || "".Equals(txtNumeroDocumento.Text) || txtPrimerNombre.Text == null || "".Equals(txtPrimerNombre.Text) || txtPrimerApellido.Text == null || "".Equals(txtPrimerApellido.Text))
            {
                MessageBox.Show("Los campos con * son obligatorios");
            }
            else { 
                personaUpd.TipoDocumento = txtTipoDocumento.Text;
                personaUpd.NumeroDocumento = txtNumeroDocumento.Text;
                personaUpd.PrimerNombre = txtPrimerNombre.Text;
                personaUpd.SegundoNombre = txtSegundoNombre.Text;
                personaUpd.PrimerApellido = txtPrimerApellido.Text;
                personaUpd.SegundoApellido = txtSegundoApellido.Text;
                personaUpd.GrupoSanguineo = txtGrupoSanguineo.Text;
                personaUpd.Sexo = txtSexo.Text;
                personaUpd.Direccion = txtDireccion.Text;
                personaUpd.Celular = txtCelular.Text;

                Int64 res = 0;
                String resOperacion = "";
                if (this.documento != null && !"".Equals(this.documento))
                {
                    const string message = "Esta seguro que desea actualizar la información de la persona?";
                    const string caption = "Actualizar Persona Confirmación";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        res = oClient.updatePersona(personaUpd);
                        resOperacion = "Persona actualizada correctamente!";
                    }
                }
                else {
                    res= oClient.addPersona(personaUpd);
                    resOperacion = "Persona agregada correctamente!";
                }
                this.Close();
                ((DataGridView)Form1.ActiveForm.Controls[1]).DataSource = oClient.getPersonas();              
                if (res == 1)
                {
                    MessageBox.Show(resOperacion);
                }
                else
                {
                    MessageBox.Show("Error al intentar Agregar/ Actualizar Persona");
                }
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCelular.Text, "^[0-9]"))
            {
                txtCelular.Text = "";
            }
        }
    }
}
