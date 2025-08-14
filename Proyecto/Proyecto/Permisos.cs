using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica; 

namespace Proyecto
{
    public partial class Permisos : Form
    {
        
        private PermisosObtener permisosObtener;
        private PermisosAsignar permisosAsignar;

        public Permisos()
        {
            InitializeComponent();
            permisosObtener = new PermisosObtener();
            permisosAsignar = new PermisosAsignar();
        }

        
        private void Permisos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = permisosObtener.Obtener();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener permisos: " + ex.Message);
            }
        }

        // NO MODIFICAR ESTA PARTE
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
