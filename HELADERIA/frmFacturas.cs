using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELADERIA
{
    public partial class frmFacturas : Form
    {
        Cliente cliente = new Cliente();
        //Lo instanciamos la clase para buscar el número de Pedido
        GestionarPedido buscarPedido = new GestionarPedido();
        //Para utilizar los atributos de un Pedido para la busque del número de un pedido
        int idCliente;
        GestionarCliente buscarCliente = new GestionarCliente();
        GestionarCliente gtrCliente = new GestionarCliente();
        Pedido pedidos = new Pedido();
        //Para validar total de la compra a que sea mayor a 5 y avilitar el # de factura y cod de control
        bool facturaAvilitada = false;

        int numeroFactura = 0003;
        public frmFacturas()
        {
            InitializeComponent();
        }

            public static class AllegedRC4
            {
                public static String encryptMessageRC4(String message, String key, Boolean unscripted)
                {
                    int[] state = new int[256];
                    int x = 0;
                    int y = 0;
                    int index1 = 0;
                    int index2 = 0;
                    int nmen;
                    String messageEncryption = "";

                    for (int i = 0; i <= 255; i++)
                    {
                        state[i] = i;
                    }

                    for (int i = 0; i <= 255; i++)
                    {
                        index2 = (((int)key[index1]) + state[i] + index2) % 256;
                        int aux = state[i];
                        state[i] = state[index2];
                        state[index2] = aux;
                        index1 = (index1 + 1) % key.Length;
                    }

                    for (int i = 0; i < message.Length; i++)
                    {
                        x = (x + 1) % 256;
                        y = (state[x] + y) % 256;
                        int aux = state[x];
                        state[x] = state[y];
                        state[y] = aux;
                        nmen = ((int)message[i]) ^ state[(state[x] + state[y]) % 256];
                        String nmenHex = nmen.ToString("X").ToUpper();
                        messageEncryption = messageEncryption + ((unscripted) ? "" : "-") + ((nmenHex.Length == 1) ? ("0" + nmenHex) : nmenHex);
                    }
                    return (unscripted) ? messageEncryption : messageEncryption.Substring(1, messageEncryption.Length - 1);
                }

            }

            public class Base64SIN
            {
                public static String convertBase64(int value)
                {
                    String[] dictionary = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d",
                                "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                                "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
                                "y", "z", "+", "/" };
                    int quotient = 1;
                    int remainder;
                    String word = "";
                    while (quotient > 0)
                    {
                        quotient = value / 64;
                        remainder = value % 64;
                        word = dictionary[remainder] + word;
                        value = quotient;
                    }
                    return word;
                }
            }

            public static class Verhoeff
            {
                // The multiplication table
                static int[,] d = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 2, 3, 4, 0, 6, 7, 8, 9, 5},
            {2, 3, 4, 0, 1, 7, 8, 9, 5, 6},
            {3, 4, 0, 1, 2, 8, 9, 5, 6, 7},
            {4, 0, 1, 2, 3, 9, 5, 6, 7, 8},
            {5, 9, 8, 7, 6, 0, 4, 3, 2, 1},
            {6, 5, 9, 8, 7, 1, 0, 4, 3, 2},
            {7, 6, 5, 9, 8, 2, 1, 0, 4, 3},
            {8, 7, 6, 5, 9, 3, 2, 1, 0, 4},
            {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}
        };

                // The permutation table
                static int[,] p = new int[,]
        {
            {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
            {1, 5, 7, 6, 2, 8, 3, 0, 9, 4},
            {5, 8, 0, 3, 7, 9, 6, 1, 4, 2},
            {8, 9, 1, 6, 0, 4, 3, 5, 2, 7},
            {9, 4, 5, 3, 1, 2, 6, 8, 7, 0},
            {4, 2, 8, 6, 5, 7, 3, 9, 0, 1},
            {2, 7, 9, 3, 8, 0, 6, 4, 1, 5},
            {7, 0, 4, 6, 9, 1, 3, 2, 5, 8}
        };

                // The inverse table
                static int[] inv = { 0, 4, 3, 2, 1, 5, 6, 7, 8, 9 };


                /// <summary>
                /// Validates that an entered number is Verhoeff compliant.
                /// NB: Make sure the check digit is the last one!
                /// </summary>
                /// <param name="num"></param>
                /// <returns>True if Verhoeff compliant, otherwise false</returns>
                public static bool validateVerhoeff(string num)
                {
                    int c = 0;
                    int[] myArray = StringToReversedIntArray(num);

                    for (int i = 0; i < myArray.Length; i++)
                    {
                        c = d[c, p[(i % 8), myArray[i]]];
                    }

                    return c == 0;

                }

                /// <summary>
                /// For a given number generates a Verhoeff digit
                /// Append this check digit to num
                /// </summary>
                /// <param name="num"></param>
                /// <returns>Verhoeff check digit as string</returns>
                public static string generateVerhoeff(string num)
                {
                    int c = 0;
                    int[] myArray = StringToReversedIntArray(num);

                    for (int i = 0; i < myArray.Length; i++)
                    {
                        c = d[c, p[((i + 1) % 8), myArray[i]]];
                    }

                    return inv[c].ToString();
                }


                /// <summary>
                /// Converts a string to a reversed integer array.
                /// </summary>
                /// <param name="num"></param>
                /// <returns>Reversed integer array</returns>
                private static int[] StringToReversedIntArray(string num)
                {
                    int[] myArray = new int[num.Length];

                    for (int i = 0; i < num.Length; i++)
                    {
                        try
                        {
                            myArray[i] = int.Parse(num.Substring(i, 1));
                        }
                        catch (FormatException e)
                        {
                            if (e.Source != null)
                                Console.WriteLine("FormatException source: {0}", e.Source);
                            throw;
                        }
                    }

                    Array.Reverse(myArray);
                    return myArray;
                }

            }

            public static class ControlCode
            {
                /// <summary>
                /// Genera codigo de control
                /// <see cref="http://jc-mouse.net/"/>
                /// <param name="authorizationNumber">Numero de autorizacion</param>        
                /// <param name="invoiceNumber">Numero de factura</param>        
                /// <param name="nitci">Número de Identificación Tributaria o Carnet de Identidad</param>        
                /// <param name="dateOfTransaction">fecha de transaccion de la forma AAAAMMDD</param>        
                /// <param name="transactionAmount">Monto de la transacción</param>        
                /// <param name="dosageKey">Llave de dosificación</param>        
                /// <returns>Codigo de Control generado de la forma 6A-DC-53-05-14</returns>
                /// </summary>
                public static String generateControlCode(String authorizationNumber, String invoiceNumber, String nitci,
                                   String dateOfTransaction, String transactionAmount, String dosageKey)
                {

                    //redondea monto de transaccion 
                    transactionAmount = roundUp(transactionAmount);
                    /* ========== PASO 1 ============= */
                    invoiceNumber = addVerhoeffDigit(invoiceNumber, 2);
                    nitci = addVerhoeffDigit(nitci, 2);
                    dateOfTransaction = addVerhoeffDigit(dateOfTransaction, 2);
                    transactionAmount = addVerhoeffDigit(transactionAmount, 2);
                    //se suman todos los valores obtenidos                  
                    Int64 sumOfVariables = 0;
                    try
                    {
                        sumOfVariables = Int64.Parse(invoiceNumber)
                                          + Int64.Parse(nitci)
                                          + Int64.Parse(dateOfTransaction)
                                          + Int64.Parse(transactionAmount);
                    }
                    catch (FormatException e)
                    {
                        if (e.Source != null)
                            Console.WriteLine("FormatException source: {0}", e.Source);
                        throw;
                    }

                    //A la suma total se añade 5 digitos Verhoeff
                    String sumOfVariables5Verhoeff = addVerhoeffDigit(sumOfVariables.ToString(), 5);

                    /* ========== PASO 2 ============= */
                    String fiveDigitsVerhoeff = sumOfVariables5Verhoeff.Substring(sumOfVariables5Verhoeff.Length - 5);
                    int[] numbers = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        numbers[i] = Int32.Parse(fiveDigitsVerhoeff[i].ToString()) + 1;
                    }

                    String string1 = dosageKey.Substring(0, numbers[0]);
                    String string2 = dosageKey.Substring(numbers[0], numbers[1]);
                    String string3 = dosageKey.Substring(numbers[0] + numbers[1], numbers[2]);
                    String string4 = dosageKey.Substring(numbers[0] + numbers[1] + numbers[2], numbers[3]);
                    String string5 = dosageKey.Substring(numbers[0] + numbers[1] + numbers[2] + numbers[3], numbers[4]);

                    String authorizationNumberDKey = authorizationNumber + string1;
                    String invoiceNumberdKey = invoiceNumber + string2;
                    String NITCIDKey = nitci + string3;
                    String dateOfTransactionDKey = dateOfTransaction + string4;
                    String transactionAmountDKey = transactionAmount + string5;

                    /* ========== PASO 3 ============= */
                    //se concatena cadenas de paso 2
                    String stringDKey = authorizationNumberDKey + invoiceNumberdKey + NITCIDKey + dateOfTransactionDKey + transactionAmountDKey;
                    //Llave para cifrado + 5 digitos Verhoeff generado en paso 2
                    String keyForEncryption = dosageKey + fiveDigitsVerhoeff;
                    //se aplica AllegedRC4
                    String allegedRC4String = AllegedRC4.encryptMessageRC4(stringDKey, keyForEncryption, true);

                    /* ========== PASO 4 ============= */
                    //se suman valores ascii
                    int totalAmount = 0;
                    int sp1 = 0;
                    int sp2 = 0;
                    int sp3 = 0;
                    int sp4 = 0;
                    int sp5 = 0;
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(allegedRC4String);
                    int tmp = 1;
                    for (int i = 0; i < asciiBytes.Length; i++)
                    {
                        totalAmount += asciiBytes[i];
                        switch (tmp)
                        {
                            case 1: sp1 += asciiBytes[i]; break;
                            case 2: sp2 += asciiBytes[i]; break;
                            case 3: sp3 += asciiBytes[i]; break;
                            case 4: sp4 += asciiBytes[i]; break;
                            case 5: sp5 += asciiBytes[i]; break;
                        }
                        tmp = (tmp < 5) ? tmp + 1 : 1;
                    }

                    /* ========== PASO 5 ============= */
                    //suma total * sumas parciales dividido entre resultados obtenidos 
                    //entre el dígito Verhoeff correspondiente más 1 (paso 2)
                    int tmp1 = totalAmount * sp1 / numbers[0];
                    int tmp2 = totalAmount * sp2 / numbers[1];
                    int tmp3 = totalAmount * sp3 / numbers[2];
                    int tmp4 = totalAmount * sp4 / numbers[3];
                    int tmp5 = totalAmount * sp5 / numbers[4];
                    //se suman todos los resultados
                    int sumProduct = tmp1 + tmp2 + tmp3 + tmp4 + tmp5;
                    //se obtiene base64
                    String base64SIN = Base64SIN.convertBase64(sumProduct);

                    /* ========== PASO 6 ============= */
                    //Aplicar el AllegedRC4 a la anterior expresión obtenida
                    return AllegedRC4.encryptMessageRC4(base64SIN, String.Concat(dosageKey, fiveDigitsVerhoeff), false);
                }

                /// <summary>
                /// Añade N digitos Verhoeff a una cadena de texto
                /// <param name="value">cadena donde se añadiran digitos Verhoeff</param>        
                /// <param name="max">cantidad de digitos a agregar</param>        
                /// <returns>cadena original + N digitos Verhoeff</returns>
                /// </summary>
                private static String addVerhoeffDigit(String value, int max)
                {
                    for (int i = 1; i <= max; i++)
                    {
                        value = String.Concat(value, Verhoeff.generateVerhoeff(value));
                    }
                    return value;
                }

                /// <summary>
                /// Transforma string a numero y redondea hacia arriba
                /// <param name="value">String numero de la forma 123 | 123.45 | 123,45 </param>        
                /// <returns>String con el numero redondeado sin decimales</returns>
                /// </summary>
                private static String roundUp(String value)
                {
                    char a = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    value = (a == ',') ? value.Replace(".", ",") : (a == '.') ? value.Replace(",", ".") : value;
                    decimal decimalVal = System.Convert.ToDecimal(value);
                    //redondea a 0 decimales                                    
                    return Math.Round(decimalVal, MidpointRounding.AwayFromZero).ToString();
                }
            }

        private void txtNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se perimite números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            return;
        }
        //Button para buscar el numero de pedido
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos de la consulta en el dataGri
            tblPedido.DataSource = buscarPedido.BuscarNroPedido(txtNumeroPedido.Text);
            tblPedido.Refresh();
            tblPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MySqlDataReader obtenerTotalPago = buscarPedido.PagoTotal(txtNumeroPedido.Text);

            if (obtenerTotalPago.HasRows && txtNumeroPedido.Text != null)
            {
                while (obtenerTotalPago.Read())
                {
                    lblTotal.Text = obtenerTotalPago.GetString(0);
                    if (Convert.ToInt32(lblTotal.Text.Length) <= 1)
                    {
                        
                    }
                    string auxTotal = lblTotal.Text;
                }
            }
            //Para VALIDAR la facturacion para luego sacar el numero de factura y codigo de control
            if (Convert.ToInt32(lblTotal.Text) < 5)
            {
                lblNumeroFactura.Text = null;
                lblCodigoControl.Text = null;
                facturaAvilitada = false;
            }
            else if (Convert.ToInt32(lblTotal.Text) >= 5)
            {
                facturaAvilitada = true;
                lblNumeroFactura.Text = numeroFactura.ToString();
            }
        }

        private void MostrarDatos_CarnetNIT()
        {
            MySqlDataReader obtenerCLiente = gtrCliente.BuscarCARNET_CARNETNIT(cliente);

            if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            {
                while (obtenerCLiente.Read())
                {
                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                    txtNombre.Text = obtenerCLiente.GetString(1);
                    txtApellidos.Text = obtenerCLiente.GetString(2);
                    txtNIT.Text = obtenerCLiente.GetString(4);
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
        }

        private void MostrarDatos_Carnet()
        {
            MySqlDataReader obtenerCLiente = gtrCliente.BuscarCarnet(cliente);

            if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            {
                while (obtenerCLiente.Read())
                {
                    idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
                    txtNombre.Text = obtenerCLiente.GetString(1);
                    txtApellidos.Text = obtenerCLiente.GetString(2);
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
        }

        private void VaciarCampos()
        {
            idCliente = 0;
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            if (txtCarnet.Text != "" && txtCarnet.Text.Length <= 7)
            {
                cliente.Carnet = Convert.ToInt32(txtCarnet.Text);
                MySqlDataReader consultar = gtrCliente.VerificarCarnet(cliente);
                if (consultar.HasRows)
                {
                    while (consultar.Read())
                    {
                        if (consultar.GetBoolean(0) == true && consultar.GetBoolean(1) == false)
                        {
                            MostrarDatos_Carnet();
                        }
                        else if (consultar.GetBoolean(0) == true && consultar.GetBoolean(1) == true)
                        {
                            MostrarDatos_CarnetNIT();
                        }
                    }
                }
            }
            else
            {
                VaciarCampos();
                txtNIT.Text = "";
            }
            string date = (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day).ToString();

            if (lblNumeroFactura.Text != null && txtCarnet.Text != null)
            {
            // public static String generateControlCode(String authorizationNumber, String invoiceNumber, String nitci,
            //String dateOfTransaction, String transactionAmount, String dosageKey)

                //String code = ControlCode.generateControlCode("20394872",
                //                                  lblNumeroFactura.Text,
                //                                  txtCarnet.Text,
                //                                  date,
                //                                  "2500",
                //                                  "9rCB7Sv4X29d)5k7N%3ab89p-3(5[A"
                //   );
                //lblCodigoControl.Text = code;                 
            }

        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.Show();
            this.Hide();
        }

        private void tblPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnVerForm_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        private void txtNIT_TextChanged(object sender, EventArgs e)
        {
            //if (txtNIT.Text != "" && txtNIT.Text.Length == 8)
            //{
            //    cliente.NIT = Convert.ToInt32(txtNIT.Text);
            //    MySqlDataReader obtenerCLiente = buscarCliente.BuscarCarnet(cliente);

            //    if (obtenerCLiente.HasRows && txtCarnet.Text != null)
            //    {
            //        while (obtenerCLiente.Read())
            //        {
            //            idCliente = Convert.ToInt32(obtenerCLiente.GetString(0));
            //            txtNombre.Text = obtenerCLiente.GetString(1);
            //            txtApellidos.Text = obtenerCLiente.GetString(2);
            //            txtCarnet.Text = obtenerCLiente.GetString(3);
            //            txtNIT.Text = obtenerCLiente.GetString(4);
            //        }
            //    }
            //    else
            //    {
            //        VaciarCampos();
            //    }
            //}
            //else
            //{
            //    VaciarCampos();
            //}
            //string date = (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day).ToString();
        }
    }
}
