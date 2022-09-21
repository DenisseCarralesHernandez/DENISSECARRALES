using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AppTest
{
    class AccionesComunes
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "¡ ¡ AVISO ! !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void LlenarCombo(string consulta, ComboBox combo, string Id, string Nombre)
        {
            /*
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 combo.Items.Add(dt.Rows[i].ItemArray[0].ToString());
             }*/
            combo.ValueMember = Id;
            combo.DisplayMember = Nombre;
            DataTable dt=new DataTable();


            //TAREA
            //Agregar metodo estatico a la clase previamente creada que permita agregar 
            //un elemento TODOS con id 0 a cualquier combo y mostrar funcionamiento en 
            //formulario existente

            dt = Conexion.EjecutaSeleccion(consulta);
            dt.Rows.Add(0, "Todos");
            DataView data = new DataView(dt);
            data.Sort = "Id ASC";
            dt = data.ToTable();


            if (dt == null)
            {
                return;
            }
            //combo.Items.Clear();
            combo.DataSource = dt;
        }
    }
}
