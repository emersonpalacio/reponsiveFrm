using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reponsiveFrm
{
    public partial class Form1 : Form
    {
        //conexion con mi base de datos.
        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=ReponsiveComercial;Integrated Security=True");
        SqlCommand cmd;// para ejecurar sentencias
        SqlDataReader dr; // para leer filas

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graficoCategorias();
        }

        ArrayList Categoria = new ArrayList();
        ArrayList CateProducto = new ArrayList();

        private void graficoCategorias()
        {
            //el nombre es  de unestro procedimiento almacenado.
            cmd = new SqlCommand("caterProductoXcategoria ", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;//procedimiento de tipo almacenado
            Conexion.Open();//abrimos la conexion
            dr = cmd.ExecuteReader(); //dr sera igual executeReader
            while (dr.Read())
            {
                //gerString no trae informacion y la convirte a string, el numero es la columna
                Categoria.Add(dr.GetString(0));
                CateProducto.Add(dr.GetInt32(1));
            }
            //reprensenta el eje x,y
            productoXcategoriaChart.Series[0].Points.DataBindXY(Categoria,CateProducto);
            dr.Close();
            Conexion.Close();
        }


    }
}
