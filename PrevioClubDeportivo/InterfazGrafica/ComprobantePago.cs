using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmComprobantePago : Form
    {
        // Propiedades para almacenar los datos recibidos de frmCobrarCuota
        private string nombre;
        private string apellido;
        private decimal importe;
        private string tipo;
        private string actividad;
        private int nroSocio;
        private DateTime vencimiento;
        private int nroComprobante;
        private bool estaCerrando = false;

        public frmComprobantePago()
        {
            InitializeComponent();
            // Constructor vacío para el diseñador
            MessageBox.Show("Advertencia: frmComprobantePago abierto sin datos. Use el constructor con parámetros para mostrar un comprobante válido.");
        }

        public frmComprobantePago(string nombre, string apellido, decimal importe, string tipo,
                                 string actividad, int nroSocio, DateTime vencimiento, int nroComprobante)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.importe = importe;
            this.tipo = tipo;
            this.actividad = actividad;
            this.nroSocio = nroSocio;
            this.vencimiento = vencimiento;
            this.nroComprobante = nroComprobante;

            // Depuración: Verificar los datos recibidos
            Console.WriteLine($"frmComprobantePago - Nombre: {nombre}, Apellido: {apellido}, Importe: {importe}, Tipo: {tipo}, Actividad: {actividad}, NroSocio: {nroSocio}, Vencimiento: {vencimiento:dd/MM/yyyy}, NroComprobante: {nroComprobante}");

            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            try
            {
                txtNombre.Text = nombre ?? "";
                txtApellido.Text = apellido ?? "";
                txtImporte.Text = importe != 0 ? importe.ToString("C2") : "";
                txtTipo.Text = tipo ?? "";
                txtActividad.Text = actividad ?? "";
                txtNroSocio.Text = nroSocio != 0 ? nroSocio.ToString() : "";
                dtpVencimiento.Value = vencimiento != default ? vencimiento : DateTime.Now;
                txtNroComprobante.Text = nroComprobante != 0 ? nroComprobante.ToString() : "";

                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtImporte.ReadOnly = true;
                txtTipo.ReadOnly = true;
                txtActividad.ReadOnly = true;
                txtNroSocio.ReadOnly = true;
                dtpVencimiento.Enabled = false;
                txtNroComprobante.ReadOnly = true;

                btnImprimir.Click += btnImprimir_Click;
                btnCerrar.Click += btnCerrar_Click;
                txtImporte.TextChanged += txtImporte_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar frmComprobantePago: {ex.Message}");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || importe == 0 ||
                string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(actividad) || nroSocio == 0 || nroComprobante == 0)
            {
                MessageBox.Show("No hay datos válidos para imprimir el comprobante. Asegúrese de que todos los campos estén completos.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintComprobante);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc
            };
            previewDialog.ShowDialog();

            try
            {
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}");
            }
        }

        private void PrintComprobante(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            float yPos = 50;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;

            string title = "Comprobante de Pago - Club Deportivo";
            e.Graphics.DrawString(title, titleFont, Brushes.Black, leftMargin, yPos);
            yPos += titleFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawString($"Número de Comprobante: {nroComprobante}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Fecha de Emisión: {DateTime.Now:dd/MM/yyyy}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Socio: {nombre} {apellido}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Número de Socio: {nroSocio}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Tipo de Cuota: {tipo}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Actividad: {actividad}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Importe: {importe:C2}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString($"Vencimiento: {vencimiento:dd/MM/yyyy}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += regularFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 20;

            e.Graphics.DrawString("Gracias por su pago.", regularFont, Brushes.Black, leftMargin, yPos);

            e.HasMorePages = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                this.Hide();
            }
        }

        private bool ConfirmarSalida()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return (respuesta == DialogResult.Yes);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!estaCerrando && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (ConfirmarSalida())
                {
                    estaCerrando = true;
                    this.Hide();
                }
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            // Manejador vacío
        }
    }
}