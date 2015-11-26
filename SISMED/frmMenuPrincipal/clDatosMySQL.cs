using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace frmMenuPrincipal
{
    class clDatosMySQL
    {
        MySqlTransaction trans = null;

        //Variables para necesarias para la conexion con la BD en MYSQL
        string server = "localhost";
        string user = "root";
        string password = "";
        string bd = "sismed";
        string cadcon = "";
        //Objetos necesarios para realizar transacciones en la BD
        //OCNX es el encargado de realizar la conexion con la BD        
        MySqlConnection OCNX = new MySqlConnection();
        //OCM encargado de ejecutar sentencias de tipo INSERT, UPDATE o DELETE
        MySqlCommand OCM;
        //ODA encargado de ejecutar sentencias de tipo SELECT
        MySqlDataAdapter ODA;
        //Constructor se encarga de conectarse con la BD cada vez se instancie un objeto
        //de esta clase
        public clDatosMySQL()
        {
            if (OCNX.State == ConnectionState.Closed)
            {
                cadcon = @"server = " + server + ";" +
                         "user = " + user + ";" +
                         "database = " + bd + ";" +
                         "port = 3306;" +
                         "password = " + password + ";";
                OCNX.ConnectionString = cadcon;
            
                OCNX.Open();
            }
        }

        public int ObtenerUltimoID()
        {
            OCM = new MySqlCommand("select last_insert_id()", this.OCNX);
            int id = Convert.ToInt32(OCM.ExecuteScalar());
            return id;
        }

        //Funcion para realizar transacciones en la BD
        public int EjercutarSQL(string sSQL)
        {
            OCM = new MySqlCommand(sSQL, OCNX);
            return OCM.ExecuteNonQuery();
        }
        //Función para validar un registro existente
        public int obtenerCatidad(string sSQL)
        {
            int cant = 0;
            OCM = new MySqlCommand(sSQL, OCNX);
            cant = Convert.ToInt32(OCM.ExecuteScalar());
            return cant;

        }
        //Funcion para consultar muchos registros de una tabla
        public DataTable ObtenerDatos(string sSQL)
        {
            ODA = new MySqlDataAdapter(sSQL, OCNX);
            DataTable Tabla = new DataTable();
            ODA.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                return Tabla;
            }
            else
            {
                Console.WriteLine("No hay datos..");
                return null;
            }
        }
        //Funcion para consutar un registro especifico
        public DataRow ObtenerFila(string sSQL)
        {
            DataTable Tabla = ObtenerDatos(sSQL);
            if (Tabla != null )
            {
                DataRow Fila = Tabla.Rows[0];
                return Fila;
            }
            else
            {
                return null;
            }
        }
        //Metodo para cargar ComboBox
        public void CargarCombo(string sSQL, ComboBox cbo, string texto, string valor)
        {
            DataTable otabla = this.ObtenerDatos(sSQL);

            if (otabla != null)
            {
                DataRow dr = otabla.NewRow();
                dr[0] = -1;
                dr[1] = "Seleccionar...";
                otabla.Rows.InsertAt(dr, 0);
                cbo.DataSource = null;
                cbo.DataSource = otabla;
                cbo.DisplayMember = texto;
                cbo.ValueMember = valor;
            }
            else
            {
                cbo.DataSource = null;
                cbo.Items.Insert(0, "no hay");
                cbo.SelectedIndex = 0;
            }

        }

        //Metodo para validar una direccion de e-mail
        public static bool ValidarEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public void IniciarTransaccion()
        {
            trans = OCNX.BeginTransaction();
        }

        public void EjercuarTransaccion()
        {
            trans.Commit();
        }

        public void DeshacerTransaccion()
        {
            trans.Rollback();
        }



    }
}

