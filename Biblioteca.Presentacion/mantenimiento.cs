using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocio;

namespace Biblioteca.Presentacion
{
    public partial class mantenimiento : Form
    {
        public mantenimiento()
        {
            InitializeComponent();
        }

        //Limpia la informacion dentro de las cajas de texto
        private void Limpiar()
        {
            nbooksTxt.Clear();
            isbnTxt.Clear();
            titleTxt.Clear();
            authTxt.Clear();
            editTxt.Clear();
            yearTxt.Clear();
            nediTxt.Clear();
            paisTxt.Clear();
            idiTxt.Clear();
            mateTxt.Clear();
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Registro de libro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Registro de libro:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Ingresar datos de libro
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (nbooksTxt.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos");
                }
                else
                {
                    Rpta = NLibro.Insertar(Int32.Parse(nbooksTxt.Text), isbnTxt.Text.Trim(), titleTxt.Text.Trim(), authTxt.Text.Trim(), editTxt.Text.Trim(), Int32.Parse(yearTxt.Text), Int32.Parse(nediTxt.Text), paisTxt.Text.Trim(), idiTxt.Text.Trim(), mateTxt.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta en el registro.");
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
