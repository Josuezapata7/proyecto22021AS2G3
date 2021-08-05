﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_reparto.Clases;

namespace sistema_reparto
{
    public partial class frmSubUbicacion : Form
    {


        /* Codigo para redondear mi panel */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        /* Varibles para cambiar color de mi Boton */
        Color colorHoverSubUbicacion = Color.FromArgb(80, 115, 119);
        Color colorNormalSubUbicacion = Color.FromArgb(59, 102, 107);


        public frmSubUbicacion()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Ocultando campos de mi form SubUbicacion*/
            pnlBordeSubUbicacion.Visible = false;
            lblRegistrarSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;
            lblModificarSubUbicacion.Visible = false;
            pnlBordeModificarSubUbicacion.Visible = false;
            lblDarBajaSubUbicacion.Visible = false;
            pnlBordeDarBajaSubUbicacion.Visible = false;
            pnlCampoIdSU.Visible = false;
            lbnIdSubUbicacion.Visible = false;
            txtIdSubUbicacion.Visible = false;
            pnlCampoNombreSU.Visible = false;
            lblNombreSubUbicacion.Visible = false;
            txtNombreSubUbicacion.Visible = false;
            pnlCampoSU.Visible = false;
            lblEstatusSubUbicacion.Visible = false;
            txtEstatusSubUbicacion.Visible = false;
            txtBuscarSubUbicacion.Visible = false;
            pnlBotonBuscarSU.Visible = false;
            dgvSubUbicacion.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlLLenarCamposSU.Visible = false;
            pnlModificarSU.Visible = false;
            pnlBotonGuardarSU.Visible = false;

        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal objCliente = new frmPrincipal();

            objCliente.Visible = true;
            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos objPuesto = new frmPuestos();

            objPuesto.Visible = true;
            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento objDepartamento = new frmDepartamento();

            objDepartamento.Visible = true;
            Visible = false;
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion objUbicacion = new frmUbicacion();

            objUbicacion.Visible = true;
            Visible = false;
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado objtipoEmpleado = new frmtipoEmpleado();

            objtipoEmpleado.Visible = true;
            Visible = false;
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado objtipoEmpleado = new frmtipoEmpleado();

            objtipoEmpleado.Visible = true;
            Visible = false;
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado objtipoEmpleado = new frmtipoEmpleado();

            objtipoEmpleado.Visible = true;
            Visible = false;
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void frmSubUbicacion_Load(object sender, EventArgs e)
        {

        }

        private void frmSubUbicacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblAbcSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeSubUbicacion.Visible = true;
            lblRegistrarSubUbicacion.Visible = true;
            lblModificarSubUbicacion.Visible = true;
            lblDarBajaSubUbicacion.Visible = true;
        }

        private void lblRegistrarSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla SubUbicacion */
            SubUbicacion subUbicacion = new SubUbicacion();
            funCargarTabla(null);

            /*Activando objetos a utilizar al momento de registrar*/
            pnlBordeRegistrarSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlLLenarCamposSU.Visible = true;
            pnlBotonGuardarSU.Visible = true;

            /*Bloqueando objetos que no utilizaremos*/
            pnlModificarSU.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlBordeModificarSubUbicacion.Visible = false;

            /*Inicio desabilitando y habilitando contenidos de mi form*/
            pnlCampoIdSU.Enabled = true;
            pnlCampoNombreSU.Enabled = true;
            txtBuscarSubUbicacion.Enabled = true;
            pnlBotonBuscarSU.Enabled = true;
            dgvSubUbicacion.Enabled = true;
            pnlLLenarCamposSU.Enabled = true;

            funVaciarCampos();

            pnlCampoSU.Enabled = true;

        }

    

    /* Inicio funcion para cargar mi tabla de SubUbicacion */
        private void funCargarTabla(string dato)
        {
            List<SubUbicacion> lista = new List<SubUbicacion>();
            SubUbicacion subUbicacion = new SubUbicacion();

            dgvSubUbicacion.DataSource = subUbicacion.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de SubUbicacion */

        private void lblModificarSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            funVaciarCampos();

            pnlBordeModificarSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlLLenarCamposSU.Visible = true;
            pnlModificarSU.Visible = true;


            pnlBotonGuardarSU.Visible = false;
            pnlActivarSU.Visible = false;
            pnlDarBajaSU.Visible = false;
            pnlLlenarCamposSUDB.Visible = false;
            pnlBordeDarBajaSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;

            /*Inicio desabilitando y habilitando contenidos de mi form*/
            pnlCampoIdSU.Enabled = false;
            pnlCampoNombreSU.Enabled = true;
            txtBuscarSubUbicacion.Enabled = true;
            pnlBotonBuscarSU.Enabled = true;
            dgvSubUbicacion.Enabled = true;
            pnlLLenarCamposSU.Enabled = true;

            pnlCampoSU.Visible = false;
        }

        private void lblDarBajaSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            funCargarTabla(null);
            funVaciarCampos();

            lblEstatusSubUbicacion.Visible = true;
            txtEstatusSubUbicacion.Visible = true;
            pnlCampoSU.Visible = true;
            pnlBordeDarBajaSubUbicacion.Visible = true;
            pnlBotonBuscarSU.Visible = true;
            txtBuscarSubUbicacion.Visible = true;
            dgvSubUbicacion.Visible = true;
            pnlCampoNombreSU.Visible = true;
            lblNombreSubUbicacion.Visible = true;
            txtNombreSubUbicacion.Visible = true;
            pnlCampoIdSU.Visible = true;
            lbnIdSubUbicacion.Visible = true;
            txtIdSubUbicacion.Visible = true;
            pnlLlenarCamposSUDB.Visible = true;


            pnlBordeModificarSubUbicacion.Visible = false;
            pnlBordeRegistrarSubUbicacion.Visible = false;
            pnlModificarSU.Visible = false;
            pnlBotonGuardarSU.Visible = false;
            pnlLLenarCamposSU.Visible = false;

            pnlCampoSU.Enabled = false;
            pnlCampoIdSU.Enabled = false;
            pnlCampoNombreSU.Enabled = false;
        }

        /* Inicio de funcion para vaciar mis campos de Puesto */
        public void funVaciarCampos()
        {
            txtIdSubUbicacion.Text = "";
            txtNombreSubUbicacion.Text = "";
            txtEstatusSubUbicacion.Text = "";
            txtBuscarSubUbicacion.Text = "";
        }

        private void dgvSubUbicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlBotonGuardarSU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un SubUbicacion */
            String EstatusSubUbicacion = "A";
            SubUbicacion subUbicacion = funObtenerTxt(EstatusSubUbicacion);
            subUbicacion.funInsertar();
            /* Final de ejecucion de funcion insertar un SubUbicacion */

            funCargarTabla(null);
            funVaciarCampos();
        }

        public SubUbicacion funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC SubUbicacion */
            String pCodigoSU = txtIdSubUbicacion.Text;
            String pNombreSU = txtNombreSubUbicacion.Text;
            /*Final obteniedo variables a usar con mi ABC SubUbicacion */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */
            SubUbicacion subUbicacion = new SubUbicacion(pCodigoSU, pNombreSU, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return subUbicacion;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalSubUbicacion;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverSubUbicacion;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalSubUbicacion;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverSubUbicacion;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalSubUbicacion;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverSubUbicacion;
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalSubUbicacion;
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverSubUbicacion;
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalSubUbicacion;
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverSubUbicacion;
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalSubUbicacion;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void btnSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorHoverSubUbicacion;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnSubUbicacion.BackColor = colorNormalSubUbicacion;
        }

        private void pnlModificarSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusSU = "A";
            String idSU = txtIdSubUbicacion.Text;
            SubUbicacion SU = funObtenerTxt(estatusSU);

            SU.funModificar(idSU);
            funCargarTabla(null);
            SU.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, idSU);
        }

        private void pnlLLenarCamposSU_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlLlenarCamposSUDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[0].Value.ToString();
            txtNombreSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[1].Value.ToString();
            txtEstatusSubUbicacion.Text = dgvSubUbicacion.CurrentRow.Cells[2].Value.ToString();

            SubUbicacion SU = new SubUbicacion();
            String pidSU = txtIdSubUbicacion.Text;
            String pestatusSU = SU.funBuscarEstatus(pidSU);

            if (pestatusSU == "A")
            {
                pnlActivarSU.Visible = false;
                pnlDarBajaSU.Visible = true;
            }
            else if (pestatusSU == "I")
            {
                pnlDarBajaSU.Visible = false;
                pnlActivarSU.Visible = true;
            }
        }

        private void pnlActivarSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdSU = txtIdSubUbicacion.Text;
            SubUbicacion subUbicacion = funObtenerTxt(estatus);

            subUbicacion.funActivarSubUbicacion();
            funCargarTabla(null);

            pnlDarBajaSU.Visible = true;
            pnlActivarSU.Visible = false;

            subUbicacion.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, pIdSU);
            /*funVaciarCampos();*/
        }

        private void pnlDarBajaSU_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdSU = txtIdSubUbicacion.Text;
            SubUbicacion SU = funObtenerTxt(estatus);

            SU.funDarBajaSubUbicacion();
            funCargarTabla(null);

            pnlActivarSU.Visible = true;
            pnlDarBajaSU.Visible = false;

            SU.funBuscarSetearTxt(txtIdSubUbicacion, txtNombreSubUbicacion, txtEstatusSubUbicacion, pIdSU);
            /*funVaciarCampos();*/
        }

        private void pnlBotonBuscarSU_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarSU = txtBuscarSubUbicacion.Text;
            funCargarTabla(buscarSU);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaSU.Visible = false;

            pnlActivarSU.Visible = false;
            /* Final Vaciando los campos */
        }
        /* Final de funcion para evitar el uso de recursivo de tantas variables */
    }
}