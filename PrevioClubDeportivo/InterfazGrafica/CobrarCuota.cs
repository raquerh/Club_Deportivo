using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PrevioClubDeportivo.InterfazGrafica
{
    public partial class frmCobrarCuota : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=Proyecto;Uid=root;Pwd=6274;";
        private bool esAptoValido;

        public frmCobrarCuota()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            connection = new MySqlConnection(connectionString);
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtNroComprobante.Enabled = false;
            txtImporte.Enabled = false;

            dtpFecha.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now.AddMonths(1);

            dtpFecha.CustomFormat = "dd/MM/yy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpVencimiento.CustomFormat = "dd/MM/yy";
            dtpVencimiento.Format = DateTimePickerFormat.Custom;

            cbActividad.Items.AddRange(new string[] { "Yoga", "Boxeo", "Pilates", "Spinning", "Musculacion", "Cardio" });
            cbActividad.Enabled = false;

            cbCuotas.Items.Add("1");
            cbCuotas.SelectedIndex = 0;

            esAptoValido = false;

            txtNroSocio.KeyPress += txtNroSocio_KeyPress;
            rbMensual.CheckedChanged += rbMensual_CheckedChanged;
            rbDiaria.CheckedChanged += rbDiaria_CheckedChanged;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            rbQr.CheckedChanged += rbQr_CheckedChanged;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            btnCancelar.Click += btnCancelar_Click;
            btnCobrar.Click += btnCobrar_Click;
        }

        private void txtNroSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtNroSocio.Text))
                {
                    try
                    {
                        if (!int.TryParse(txtNroSocio.Text, out int numeroSocio))
                        {
                            MessageBox.Show("El número de socio debe ser un valor numérico válido.");
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            esAptoValido = false;
                            return;
                        }

                        connection.Open();
                        string query = "SELECT p.nombre, p.apellido, af.esApto, af.vtoAptoFisico " +
                                      "FROM Personas p " +
                                      "JOIN Socios s ON p.idPersona = s.idPersona " +
                                      "LEFT JOIN AptoFisico af ON s.numeroSocio = af.numeroSocio " +
                                      "WHERE s.numeroSocio = @numeroSocio";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNombre.Text = reader["nombre"].ToString();
                            txtApellido.Text = reader["apellido"].ToString();

                            if (reader["esApto"] != DBNull.Value)
                            {
                                string esApto = reader["esApto"].ToString();
                                DateTime vtoApto = Convert.ToDateTime(reader["vtoAptoFisico"]);
                                if (esApto == "Apto" && vtoApto >= DateTime.Now)
                                {
                                    esAptoValido = true;
                                }
                                else
                                {
                                    esAptoValido = false;
                                    MessageBox.Show("El socio no está apto físicamente o el apto físico ha vencido.");
                                }
                            }
                            else
                            {
                                esAptoValido = false;
                                MessageBox.Show("El socio no tiene un apto físico registrado.");
                            }
                        }
                        else
                        {
                            txtNombre.Text = "";
                            txtApellido.Text = "";
                            esAptoValido = false;
                            MessageBox.Show("Socio no encontrado.");
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        esAptoValido = false;
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                            connection.Close();
                    }
                }
                else
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    esAptoValido = false;
                    MessageBox.Show("Por favor, ingrese un número de socio.");
                }
            }
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMensual.Checked)
            {
                cbActividad.Enabled = false;
                cbActividad.Items.Clear();
                cbActividad.Items.Add("LIBRE");
                cbActividad.SelectedIndex = 0;
                txtImporte.Text = "20000";
            }
        }

        private void rbDiaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiaria.Checked)
            {
                cbActividad.Enabled = true;
                cbActividad.Items.Clear();
                cbActividad.Items.AddRange(new string[] { "Yoga", "Boxeo", "Pilates", "Spinning", "Musculacion", "Cardio" });
                cbActividad.SelectedIndex = -1;
                txtImporte.Text = "10000";
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                cbCuotas.Items.Clear();
                cbCuotas.Items.Add("1");
                cbCuotas.SelectedIndex = 0;
            }
        }

        private void rbQr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQr.Checked)
            {
                cbCuotas.Items.Clear();
                cbCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                cbCuotas.SelectedIndex = 0;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                cbCuotas.Items.Clear();
                cbCuotas.Items.AddRange(new string[] { "1", "3", "6" });
                cbCuotas.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            // 1. Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtNroSocio.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de socio.");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El socio no es válido. Verifique el número de socio.");
                return;
            }
            if (!esAptoValido)
            {
                MessageBox.Show("No se puede registrar el pago porque el socio no está apto físicamente.");
                return;
            }
            if (!rbMensual.Checked && !rbDiaria.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de pago (Mensual o Diaria).");
                return;
            }
            if (cbActividad.SelectedIndex == -1 || cbActividad.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una actividad.");
                return;
            }
            if (string.IsNullOrEmpty(txtImporte.Text) || !decimal.TryParse(txtImporte.Text, out decimal importe))
            {
                MessageBox.Show("El importe no es válido.");
                return;
            }
            if (!rbEfectivo.Checked && !rbQr.Checked && !rbTarjeta.Checked)
            {
                MessageBox.Show("Debe seleccionar un método de pago (Efectivo, QR o Tarjeta).");
                return;
            }
            if (cbCuotas.SelectedIndex == -1 || cbCuotas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el número de cuotas.");
                return;
            }

            try
            {
                connection.Open();

                // 2. Verificar si ya existe un pago duplicado
                string checkPagoQuery;
                MySqlCommand checkCmd;
                int numeroSocio = int.Parse(txtNroSocio.Text);
                DateTime fechaPago = dtpFecha.Value;

                if (rbMensual.Checked)
                {
                    checkPagoQuery = "SELECT COUNT(*) FROM Pagos " +
                                    "WHERE numeroSocio = @numeroSocio " +
                                    "AND tipo = 'Mensual' " +
                                    "AND YEAR(fecha) = @year " +
                                    "AND MONTH(fecha) = @month";
                    checkCmd = new MySqlCommand(checkPagoQuery, connection);
                    checkCmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                    checkCmd.Parameters.AddWithValue("@year", fechaPago.Year);
                    checkCmd.Parameters.AddWithValue("@month", fechaPago.Month);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("El socio ya tiene una cuota mensual paga para este mes.");
                        return;
                    }
                }
                else // rbDiaria.Checked
                {
                    checkPagoQuery = "SELECT COUNT(*) FROM Pagos " +
                                    "WHERE numeroSocio = @numeroSocio " +
                                    "AND tipo = 'Diaria' " +
                                    "AND actividad = @actividad " +
                                    "AND DATE(fecha) = @fecha";
                    checkCmd = new MySqlCommand(checkPagoQuery, connection);
                    checkCmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                    checkCmd.Parameters.AddWithValue("@actividad", cbActividad.SelectedItem.ToString());
                    checkCmd.Parameters.AddWithValue("@fecha", fechaPago.Date);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show($"El socio ya tiene una cuota diaria paga para la actividad {cbActividad.SelectedItem} en esta fecha.");
                        return;
                    }
                }

                // 3. Preparar datos para el comprobante
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string tipo = rbMensual.Checked ? "Mensual" : "Diaria";
                string actividad = cbActividad.SelectedItem.ToString();
                DateTime vencimiento = dtpVencimiento.Value;

                // Depuración: Verificar los datos antes de insertar
                Console.WriteLine($"Nombre: {nombre}, Apellido: {apellido}, Importe: {importe}, Tipo: {tipo}, Actividad: {actividad}, NroSocio: {numeroSocio}, Vencimiento: {vencimiento:dd/MM/yyyy}");

                // 4. Insertar en la tabla Pagos
                string insertPagoQuery = "INSERT INTO Pagos (numeroSocio, tipo, actividad, importe, metodo_pago, cuotas, fecha, vencimiento) " +
                                        "VALUES (@numeroSocio, @tipo, @actividad, @importe, @metodoPago, @cuotas, @fecha, @vencimiento);" +
                                        "SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(insertPagoQuery, connection);
                cmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@actividad", actividad);
                cmd.Parameters.AddWithValue("@importe", importe);
                cmd.Parameters.AddWithValue("@metodoPago", rbEfectivo.Checked ? "Efectivo" : rbQr.Checked ? "QR" : "Tarjeta");
                cmd.Parameters.AddWithValue("@cuotas", int.Parse(cbCuotas.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@fecha", fechaPago);
                cmd.Parameters.AddWithValue("@vencimiento", vencimiento);

                int nroComprobante = Convert.ToInt32(cmd.ExecuteScalar());
                txtNroComprobante.Text = nroComprobante.ToString();

                // 5. Actualizar la tabla Socios
                string updateSocioQuery = "UPDATE Socios SET tipoSocio = @tipoSocio, fechaPago = @fechaPago, estadoCuota = @estadoCuota WHERE numeroSocio = @numeroSocio";
                MySqlCommand updateCmd = new MySqlCommand(updateSocioQuery, connection);
                updateCmd.Parameters.AddWithValue("@tipoSocio", rbMensual.Checked ? "Activo" : "Adherente");
                updateCmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                updateCmd.Parameters.AddWithValue("@estadoCuota", "Al día");
                updateCmd.Parameters.AddWithValue("@numeroSocio", numeroSocio);
                updateCmd.ExecuteNonQuery();

                // 6. Mostrar mensaje de éxito
                MessageBox.Show("Pago Registrado");

                // 7. Abrir formulario de comprobante de pago con los datos
                frmComprobantePago comprobante = new frmComprobantePago(
                    nombre,
                    apellido,
                    importe,
                    tipo,
                    actividad,
                    numeroSocio,
                    vencimiento,
                    nroComprobante
                );
                comprobante.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el pago: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (ConfirmarSalida())
            {
                Application.Exit();
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

        private bool estaCerrando = false;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!estaCerrando && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                if (ConfirmarSalida())
                {
                    estaCerrando = true;
                    Application.Exit();
                }
            }
            else
            {
                base.OnFormClosing(e);
            }
        }
    }
}