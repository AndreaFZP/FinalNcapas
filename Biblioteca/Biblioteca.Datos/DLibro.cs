using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Entidades;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class DLibro
    {
        //Procedimiento para agregar un nuevo libro
        public string Insertar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nejemplares", SqlDbType.Int).Value = Obj.nEjemplares;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@año", SqlDbType.Int).Value = Obj.Anio;
                Comando.Parameters.Add("@nedicion", SqlDbType.Int).Value = Obj.nEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;


                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        //Actualizar libro
        public string Actualizar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigolibro", SqlDbType.Int).Value = Obj.CodigoLibro;
                Comando.Parameters.Add("@nejemplares", SqlDbType.Int).Value = Obj.nEjemplares;
                Comando.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@año", SqlDbType.Int).Value = Obj.Anio;
                Comando.Parameters.Add("@nedicion", SqlDbType.Int).Value = Obj.nEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;


                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        //Eliminar Libro
        public string Eliminar(int id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@codigolibro", SqlDbType.Int).Value = id;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
