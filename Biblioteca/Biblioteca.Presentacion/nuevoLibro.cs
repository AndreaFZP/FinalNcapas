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
    public partial class nuevoLibro : Form
    {
        public nuevoLibro()
        {
            InitializeComponent();
        }

        //Limpia la informacion dentro de las cajas de texto
        private void Limpiar()
        {
            btnInsertar.Visible = true;
            btnActualizar.Visible = false;
            btnBorrar.Visible = false;

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
                        this.Listar();
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

<<<<<<< Updated upstream:Biblioteca/Biblioteca.Presentacion/nuevoLibro.cs
        
=======
        private void mantenimiento_Load(object sender, EventArgs e)
        {
            Listar();
        }

        //Ejecuta el listado de los registros
        private void Listar()
        {
            try
            {
                librosGrid.DataSource = NLibro.Listar();
                this.Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void librosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnBorrar.Visible = true;
                btnInsertar.Visible = false;
                nbooksTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["NumeroEjemplares"].Value);
                isbnTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["ISBN"].Value);
                titleTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Titulo"].Value);
                authTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Autor"].Value);
                editTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Editorial"].Value);
                yearTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Año"].Value);
                nediTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["NumeroEdicion"].Value);
                paisTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Pais"].Value);
                idiTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Idioma"].Value);
                mateTxt.Text = Convert.ToString(librosGrid.CurrentRow.Cells["Materia"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                    string idBook = Convert.ToString(librosGrid.CurrentRow.Cells["ID"].Value);
                    Rpta = NLibro.Actualizar(Int32.Parse(idBook),Int32.Parse(nbooksTxt.Text), isbnTxt.Text.Trim(), titleTxt.Text.Trim(), authTxt.Text.Trim(), editTxt.Text.Trim(), Int32.Parse(yearTxt.Text), Int32.Parse(nediTxt.Text), paisTxt.Text.Trim(), idiTxt.Text.Trim(), mateTxt.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta en el registro.");
                        this.Limpiar();
                        this.Listar();
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el registro?", "Biblioteca", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string idBook;
                    string Rpta = "";
                    
                    idBook = Convert.ToString(librosGrid.CurrentRow.Cells["ID"].Value);
                    Rpta = NLibro.Eliminar(Int32.Parse(idBook));

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se eliminó el registro: ");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                        
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
>>>>>>> Stashed changes:Biblioteca.Presentacion/mantenimiento.cs
    }
}
