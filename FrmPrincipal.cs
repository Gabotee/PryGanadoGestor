using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            // Ocultar Paneles SubMenu
            panelSubMenuProduccion.Visible = false;
            panelSubMenuListado.Visible = false;
            panelSubMenuEstadisticas.Visible = false;
            panelSubMenuInsumos.Visible = false;
            panelSubMenuAdministracion.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelSubMenuProduccion.Visible == true)
            {
                panelSubMenuProduccion.Visible = false;
            }

            if (panelSubMenuListado.Visible == true)
            {
                panelSubMenuListado.Visible = false;
            }

            if(panelSubMenuEstadisticas.Visible == true)
            {
                panelSubMenuEstadisticas.Visible = false;
            }

            if(panelSubMenuInsumos.Visible == true)
            {
                panelSubMenuInsumos.Visible = false;
            }

            if(panelSubMenuAdministracion.Visible == true)
            {
                panelSubMenuAdministracion.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private Form FormularioActivo = null;
        private void AbrirFromulariosHijos(Form FormularioHijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                FormularioActivo = FormularioHijo;
                FormularioHijo.TopLevel = false;
                FormularioHijo.FormBorderStyle = FormBorderStyle.None;
                FormularioHijo.Dock = DockStyle.Fill;
                panelFormularioHijo.Controls.Add(FormularioHijo);
                panelFormularioHijo.Tag = FormularioHijo;
                panelFormularioHijo.BringToFront();
                FormularioHijo.Show();
            }
        }

        private void AbrirFromulariosHijoss(Form Form)
        {
            while (panelFormularioHijo.Controls.Count > 0)
            {
                panelFormularioHijo.Controls.RemoveAt(0);
            }
            Form formularioHijo = Form;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }

        private void cmdProduccion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuProduccion);
        }

        private void cmdRegistroOrdeñe_Click(object sender, EventArgs e)
        {
            AbrirFromulariosHijoss(new FrmRegistroOrdeñe());
            OcultarSubMenu();
        }

        private void cmdRegistroExtraccion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void cmdListarGanado_Click(object sender, EventArgs e)
        {
            AbrirFromulariosHijoss(new FrmListar());
            OcultarSubMenu();
        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuListado);
        }

        private void cmdEstadisticas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEstadisticas);
        }

        private void cmdInsumos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuInsumos);
        }

        private void cmdAdministracion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuAdministracion);
        }
    }
}
