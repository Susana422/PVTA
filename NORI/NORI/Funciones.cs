using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using NORI.API;
using NORI.HuellaDigital;
using NORI.HuellaDigital.Class;
using NoriSDK;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORI
{
    public static class Funciones
    {
        public static bool huella = false;
        public static bool cred = false;
        public static AppData Data;
        public static bool Autenticar(Usuario usuario = null)
        {
            if (usuario.IsNullOrEmpty())
            {
                usuario = Program.Nori.UsuarioAutenticado;
            }
            if (Program.Nori.Estacion.lector_huella)
            {
                //HuellaDigital.frmHuellaDigitalVerificar frmHuellaDigitalVerificar = new HuellaDigital.frmHuellaDigitalVerificar();
                //frmHuellaDigitalVerificar.huella_digital = usuario.huella_digital;
                //((Form)(object)frmHuellaDigitalVerificar).ShowInTaskbar = false;
                //((Control)(object)frmHuellaDigitalVerificar).Width = 237;
                //((Control)(object)frmHuellaDigitalVerificar).Text = "Autenticar";
                //((Form)(object)frmHuellaDigitalVerificar).ControlBox = false;
                //((Form)(object)frmHuellaDigitalVerificar).TopMost = true;
                //((Form)(object)frmHuellaDigitalVerificar).ShowDialog();
                //if (((Form)(object)frmHuellaDigitalVerificar).DialogResult != DialogResult.OK)
                //{
                //    return false;
                //}
            }
            else
            {
                frmAutenticar frmAutenticar2 = new frmAutenticar();
                frmAutenticar2.usuario = usuario;
                ((Form)(object)frmAutenticar2).ShowDialog();
                if (((Form)(object)frmAutenticar2).DialogResult != DialogResult.OK)
                {
                    return false;
                }
            }
            return true;
        }


        public static void Desbloquear()
        {

            if (huella == true)
            {
                //HuellaDigital.frmHuellaDigitalVerificar frmHuellaDigitalVerificar = new HuellaDigital.frmHuellaDigitalVerificar();
                //frmHuellaDigitalVerificar.huella_digital = Program.Nori.UsuarioAutenticado.huella_digital;
                //((Form)(object)frmHuellaDigitalVerificar).ShowInTaskbar = false;
                //((Control)(object)frmHuellaDigitalVerificar).Width = 237;
                //((Control)(object)frmHuellaDigitalVerificar).Text = "Desbloquear";
                //((Form)(object)frmHuellaDigitalVerificar).ControlBox = false;
                //((Form)(object)frmHuellaDigitalVerificar).TopMost = true;
                //frmHuellaDigital
                if (Data == null)
                {
                    Data = new AppData();
                    Data.OnChange += delegate { ExchangeData(false); };
                }
                AutenticarHuellaDigital autenticarHuellaDigital = new AutenticarHuellaDigital(Data);
                autenticarHuellaDigital.usuario = Program.Nori.UsuarioAutenticado;
                ((Form)(object)autenticarHuellaDigital).ShowDialog();
                if (((Form)(object)autenticarHuellaDigital).DialogResult == DialogResult.OK)
                {
                    Funciones.huella = false;
                    Funciones.cred = false;
                    Desbloquear();

                }
            }
            if (cred == true)
            {
                frmAutenticar frmAutenticar2 = new frmAutenticar();
                frmAutenticar2.usuario = Program.Nori.UsuarioAutenticado;
                ((Form)(object)frmAutenticar2).ShowDialog();
                if (((Form)(object)frmAutenticar2).DialogResult == DialogResult.OK)
                {
                    Funciones.huella = false;
                    Funciones.cred = false;
                    Desbloquear();
                }
            }
        }
        public static void ExchangeData(bool read)
        {
        }

        public static void CerrarSesion()
        {
            try
            {
                for (int num = Application.OpenForms.Count - 1; num >= 0; num--)
                {
                    if (Application.OpenForms[num].Name != "frmAcceder")
                    {
                        Application.OpenForms[num].Close();
                    }
                }
            }
            catch
            {
            }
            if (Application.OpenForms.Count == 1)
            {
                Application.OpenForms[0].Show();
            }
        }

        public static void MatarProcesos()
        {
            List<Process> list = Process.GetProcessesByName("Nori").ToList();
            list.ForEach(delegate (Process x)
            {
                x.Kill();
            });
        }

        public static bool AccederConHuella(Usuario usuario)
        {
            try
            {
                usuario = (from x in Usuario.Usuarios()
                           where x.usuario == usuario.usuario
                           select x).First();
                if (!usuario.huella_digital.IsNullOrEmpty())
                {
                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static IEnumerable<Control> ObtenerControles(this Control root)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(root);
            while (stack.Any())
            {
                Control next = stack.Pop();
                foreach (Control child in next.Controls)
                {
                    if (child.Name.Length > 0)
                    {
                        stack.Push(child);
                    }
                }
                yield return next;
            }
        }

        public static IEnumerable<GridColumn> ObtenerColumnas(this GridControl root)
        {
            try
            {
                GridView val = (GridView)root.MainView;
                return ((IEnumerable<GridColumn>)((ColumnView)val).Columns).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static bool ImprimirInformePredeterminado(string tipo, int parametro, int copias = 1)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Imprimiendo...");
                Informe informe = (from x in Informe.Informes()
                                   where x.tipo == tipo && x.activo == true && x.predeterminado == true
                                   select x).First();
                copias *= informe.copias;
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe.informe, true);
                val.Parameters["id"].Value = parametro;
                val.Parameters["id"].Visible = false;
                if (tipo == "CX" || tipo == "CZ")
                {
                    int usuario_creacion_id = (from x in Flujo.Flujos()
                                               where x.id == parametro
                                               select x.usuario_creacion_id).First();
                    val.Parameters["id"].Value = usuario_creacion_id;
                    val.Parameters["id"].Visible = false;
                    val.Parameters["movimiento_inicial"].Value = (from x in Flujo.Flujos()
                                                                  where x.codigo == "INACA" && x.usuario_creacion_id == usuario_creacion_id && x.id < parametro
                                                                  orderby x.id descending
                                                                  select x.id).First();
                    val.Parameters["movimiento_inicial"].Visible = false;
                    val.Parameters["movimiento_final"].Value = parametro;
                    val.Parameters["movimiento_final"].Visible = false;
                }
                val.ShowPrintMarginsWarning = false;
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);
                string text = null;
                text = ((!informe.tipo_informe.Equals('T')) ? Program.Nori.Estacion.impresora_documentos : Program.Nori.Estacion.impresora_tickets);
                if (!informe.impresora.IsNullOrEmpty())
                {
                    text = informe.impresora;
                }
                if (informe.almacen)
                {
                    List<int> list = (from x in Documento.Partida.Partidas()
                                      where x.documento_id == parametro
                                      select x.almacen_id).Distinct().ToList();
                    foreach (int item in list)
                    {
                        val.Parameters["id"].Value = parametro;
                        val.Parameters["id"].Visible = false;
                        val.Parameters["almacen_id"].Value = item;
                        val.Parameters["almacen_id"].Visible = false;
                        val.CreateDocument();
                        Almacen almacen = Almacen.Obtener(item);
                        string text2 = text;
                        if (almacen.impresora.IsNullOrEmpty())
                        {
                            continue;
                        }
                        text2 = almacen.impresora;
                        if (copias == 1)
                        {
                            ((PrintToolBase)val2).Print(text2);
                            continue;
                        }
                        for (short num = 0; num < copias; num++)
                        {
                            ((PrintToolBase)val2).Print(text2);
                        }
                    }
                }
                else if (copias == 1)
                {
                    ((PrintToolBase)val2).Print(text);
                }
                else
                {
                    for (short num2 = 0; num2 < copias; num2++)
                    {
                        ((PrintToolBase)val2).Print(text);
                    }
                }
                if (informe.informe_sequencia_id != 0)
                {
                    ImprimirInforme(informe.informe_sequencia_id, parametro);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString().Replace("Nori", "DTM"));
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static bool ImprimirInforme(int id, int parametro, bool documento = false)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Imprimiendo...");
                Informe informe = Informe.Obtener(id);
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe.informe, true);
                val.Parameters["id"].Value = parametro;
                val.Parameters["id"].Visible = false;
                val.ShowPrintMarginsWarning = false;
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);
                string text = null;
                text = ((!informe.tipo_informe.Equals('T')) ? Program.Nori.Estacion.impresora_documentos : Program.Nori.Estacion.impresora_tickets);
                if (!informe.impresora.IsNullOrEmpty())
                {
                    text = informe.impresora;
                }
                if (informe.almacen)
                {
                    List<int> list = (from x in Documento.Partida.Partidas()
                                      where x.documento_id == parametro
                                      select x.almacen_id).Distinct().ToList();
                    foreach (int item in list)
                    {
                        val.Parameters["id"].Value = parametro;
                        val.Parameters["id"].Visible = false;
                        val.Parameters["almacen_id"].Value = item;
                        val.Parameters["almacen_id"].Visible = false;
                        val.CreateDocument();
                        Almacen almacen = Almacen.Obtener(item);
                        string text2 = text;
                        if (!almacen.impresora.IsNullOrEmpty())
                        {
                            text2 = almacen.impresora;
                            ((PrintToolBase)val2).Print(text2);
                        }
                    }
                }
                else
                {
                    ((PrintToolBase)val2).Print(text);
                }
                if (documento)
                {
                    Documento.Obtener(parametro).Impreso();
                }
                if (informe.informe_sequencia_id != 0)
                {
                    ImprimirInforme(informe.informe_sequencia_id, parametro);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static bool ImprimirInforme(string informe, int parametro)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Imprimiendo...");
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe, true);
                val.Parameters["id"].Value = parametro;
                val.Parameters["id"].Visible = false;
                val.ShowPrintMarginsWarning = false;
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);
                ((PrintToolBase)val2).Print();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static bool ImprimirInforme(int id, Dictionary<string, object> parametros)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Imprimiendo...");
                Informe informe = Informe.Obtener(id);
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe.informe, true);
                foreach (KeyValuePair<string, object> parametro in parametros)
                {
                    val.Parameters[parametro.Key].Value = parametro.Value;
                    val.Parameters[parametro.Key].Visible = false;
                }
                val.ShowPrintMarginsWarning = false;
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);
                string text = null;
                if (informe.tipo_informe.Equals('T'))
                {
                    text = Program.Nori.Estacion.impresora_tickets;
                }
                else
                {
                    text = Program.Nori.Estacion.impresora_documentos;
                }
                if (!informe.impresora.IsNullOrEmpty())
                {
                    text = informe.impresora;
                }
                ((PrintToolBase)val2).Print();
                if (informe.informe_sequencia_id != 0)
                {
                    ImprimirInforme(informe.informe_sequencia_id, parametros);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static bool ImprimirInforme2(int id, Dictionary<string, object> parametros)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Imprimiendo...");

                Informe informe = Informe.Obtener(id);
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe.informe, true);

                // Establecer los parámetros en el informe
                foreach (KeyValuePair<string, object> parametro in parametros)
                {
                    val.Parameters[parametro.Key].Value = parametro.Value;
                    val.Parameters[parametro.Key].Visible = false;
                }

                val.ShowPrintMarginsWarning = false;

                // Crear el ReportPrintTool
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);

                string impresora = null;

                // Determinar la impresora a utilizar (tickets o documentos)
                if (informe.tipo_informe.Equals('T'))
                {
                    impresora = Program.Nori.Estacion.impresora_tickets;
                }
                else
                {
                    impresora = Program.Nori.Estacion.impresora_documentos;
                }

                // Si hay una impresora definida en el informe, usarla
                if (!informe.impresora.IsNullOrEmpty())
                {
                    impresora = informe.impresora;
                }

                // SI la impresora está definida, establecerla en el ReportPrintTool
                if (!string.IsNullOrEmpty(impresora))
                {
                    val2.PrintingSystem.PageSettings.PrinterName = impresora;

                    // Asegúrate de aplicar estos cambios antes de imprimir
                    // Reiniciar la impresora predeterminada del sistema
            
                }

                // Verificación adicional: mostrar la impresora seleccionada
                MessageBox.Show("Impresora seleccionada: " + val2.PrintingSystem.PageSettings.PrinterName);

                // Imprimir el informe
                val2.Print();

                // Si hay una secuencia de impresión, imprimir de nuevo
                if (informe.informe_sequencia_id != 0)
                {
                    ImprimirInforme(informe.informe_sequencia_id, parametros);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
        public static string PDFInforme(int id, int parametro, string nombre_archivo = null)
        {
            try
            {
                string text = Program.Nori.Configuracion.directorio_documentos + "\\" + (nombre_archivo.IsNullOrEmpty() ? Utilidades.CadenaAleatoria(10) : nombre_archivo) + ".pdf";
                Informe informe = Informe.Obtener(id);
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe.informe, true);
                val.Parameters["id"].Value = parametro;
                val.Parameters["id"].Visible = false;
                PdfExportOptions pdf = val.ExportOptions.Pdf;
                pdf.ConvertImagesToJpeg = false;
                pdf.ImageQuality = (PdfJpegImageQuality)50;
                if (informe.almacen && informe.tipo == "PE")
                {
                    List<int> list = (from x in Documento.Partida.Partidas()
                                      where x.documento_id == parametro
                                      select x.almacen_id).Distinct().ToList();
                    foreach (int item in list)
                    {
                        val.Parameters["almacen_id"].Value = item;
                        val.Parameters["almacen_id"].Visible = false;
                        val.ExportToPdf(text, pdf);
                    }
                }
                else
                {
                    val.ExportToPdf(text, pdf);
                }
                return text;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string PDFInforme(string rutaInforme, string rutaPDF)
        {
            try
            {
                XtraReport val = XtraReport.FromFile("C: \\Users\\Z\\Documents\\Visual Studio 2015\\RepoNori\\Cfdi32.repx", true);
                PdfExportOptions pdf = val.ExportOptions.Pdf;
                pdf.ConvertImagesToJpeg = false;
                pdf.ImageQuality = (PdfJpegImageQuality)50;
                val.ExportToPdf(rutaPDF, pdf);
                return rutaPDF;
            }
            catch
            {
                return null;
            }
        }

        public static bool PrevisualizarInforme(string informe)
        {
            try
            {
                XtraReport val = XtraReport.FromFile(Program.Nori.Configuracion.directorio_informes + "\\" + informe, true);
                ReportPrintTool val2 = new ReportPrintTool((IReport)(object)val);
                ((PrintTool)val2).ShowPreview();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ConectarSucursal(string codigo)
        {
            try
            {
                Sucursal sucursal = Program.sucursales.Where((Sucursal x) => x.codigo == codigo).First();
                if (sucursal.id != 0)
                {
                    SqlConnectionStringBuilder conexion = Program.Nori.Conexion;
                    Program.Nori.Conexion.DataSource = sucursal.servidor;
                    Program.Nori.Conexion.InitialCatalog = sucursal.bd;
                    if (sucursal.contraseña.IsNullOrEmpty())
                    {
                        Program.Nori.Conexion.IntegratedSecurity = false;
                    }
                    Program.Nori.Conexion.UserID = sucursal.usuario;
                    Program.Nori.Conexion.Password = sucursal.contraseña;
                    Program.Nori.Conexion.ConnectTimeout = 30;
                    if (Program.Nori.Conectar())
                    {
                        if (Program.Nori.Autenticar(Usuario.Obtener(Program.Nori.UsuarioAutenticado.usuario), api: true))
                        {
                            MessageBox.Show("Conexión realizada correctamente.");
                            return true;
                        }
                        MessageBox.Show($"El usuario ({Program.Nori.UsuarioAutenticado.usuario}) no existe en la sucursal seleccionada.");
                    }
                    Program.Nori.Conexion = conexion;
                    Program.Nori.Conectar();
                    MessageBox.Show($"No fue posible establecer una conexión con la sucursal {sucursal.nombre}");
                    return false;
                }
                MessageBox.Show($"No fue posible establecer una conexión (Sucursal no encontrada).");
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<Image> CargarImagen(string ruta)
        {
            if (ruta != null)
            {
                if (ruta.Length > 0)
                {
                    try
                    {
                        ruta = Program.Nori.Configuracion.directorio_imagenes + "\\" + ruta;
                        FileWebRequest request = (FileWebRequest)WebRequest.Create(ruta);
                        FileWebResponse response = (FileWebResponse)(await request.GetResponseAsync());
                        Stream stream = response.GetResponseStream();
                        return Image.FromStream(stream);
                    }
                    catch
                    {
                        return null;
                    }
                }
            }

            return null;
        }

        public static bool TimbrarDocumento(Documento documento, string rfc = null, int documento_electronico_sustitucion_id = 0)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Generando CFDI...");
                bool flag = Program.CFDI.Timbrar(documento, rfc, documento_electronico_sustitucion_id);
                if (flag)
                {
                    EnviarCFDiAsync(documento.id);
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Timbrar documento", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static bool CancelarTimbreDocumentoElectronico(DocumentoElectronico documento_electronico)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Cancelando CFDI...");
                return Program.CFDI.Cancelar(documento_electronico);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Cancelar documento", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static string CancelarCFDi(string uuid, string rfc_receptor, double total, string motivo, string sustitucion)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Cancelando CFDI...");
                return Program.CFDI.Cancelar(uuid, rfc_receptor, total, motivo, sustitucion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Cancelar documento", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return "No fue posible cancelar el documento.";
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static async Task EnviarCFDiAsync(int id, bool pago = false)
        {
            try
            {
                Usuario.CorreoElectronico correo_electronico = Usuario.CorreoElectronico.CorreosElectronicos().First();
                var documento = (pago ? (from x in Pago.Pagos()
                                         where x.id == id
                                         select new
                                         {
                                             id = x.id,
                                             socio_id = x.socio_id,
                                             clase = "PR"
                                         }).First() : (from x in Documento.Documentos()
                                                       where x.id == id
                                                       select new { x.id, x.socio_id, x.clase }).First());
                if (!documento.clase.Equals("FA") && !documento.clase.Equals("NC") && !documento.clase.Equals("PR"))
                {
                    return;
                }
                var socio = (from x in Socio.Socios()
                             where x.id == documento.socio_id
                             select new { x.nombre, x.rfc, x.correo }).First();
                SmtpClient cliente = new SmtpClient();
                string[] destinatarios = socio.correo.Replace(" ", string.Empty).Split(';');
                string mensajeCuerpo = string.IsNullOrEmpty(correo_electronico.mensaje)
                    ? $"Te informamos que {Program.Nori.Empresa.nombre_fiscal} ha generado un Comprobante Fiscal Digital, el cual encontrarás adjunto en este correo en su formato XML y PDF"
                    : correo_electronico.mensaje;

                string asunto = $"{Program.Nori.Empresa.nombre_fiscal} - Le ha enviado un comprobante fiscal digital ({Documento.Clase.Clases().First(x => x.clase == documento.clase).nombre})";

                // Crear el objeto MailMessage
                MailMessage mensaje = new MailMessage();
                mensaje.Body = mensajeCuerpo;
                mensaje.From = new MailAddress(correo_electronico.usuario);
                mensaje.To.Add(destinatarios[0]);
                mensaje.Subject = asunto;

                cliente.Port = correo_electronico.puerto;
                cliente.Host = correo_electronico.servidor;
                cliente.EnableSsl = correo_electronico.ssl;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(correo_electronico.usuario, correo_electronico.contraseña);
                if (correo_electronico.remitente.Length > 0)
                {
                    mensaje.From = new MailAddress(correo_electronico.usuario, correo_electronico.remitente);
                }
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.SubjectEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = false;
                mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mensaje.CC.Add(correo_electronico.usuario);
                string[] array = destinatarios;
                foreach (string destinatario in array)
                {
                    mensaje.CC.Add(destinatario);
                }
                DocumentoElectronico documento_electronico = DocumentoElectronico.ObtenerPorDocumento(documento.id);
                if (documento_electronico.id != 0 && documento_electronico.estado.Equals('A'))
                {
                    mensaje.Attachments.Add(new Attachment(PDFInforme((from x in Informe.Informes()
                                                                       where x.tipo == documento.clase && x.activo == true && x.predeterminado_correo_electronico == true
                                                                       select x.id).First(), documento.id, documento_electronico.folio_fiscal)));
                    mensaje.Attachments.Add(new Attachment($"{Program.Nori.Configuracion.directorio_xml}\\{documento_electronico.folio_fiscal}.xml"));
                }
                if (mensaje.Attachments.Count >= 2)
                {
                    if (!pago)
                    {
                        Documento _documento = Documento.Obtener(id);
                        _documento.Enviado();
                    }
                    await cliente.SendMailAsync(mensaje);
                }
            }
            catch
            {
            }
        }

        public static async Task EnviarDocumentoAsync(int id, string correo = null)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Enviando correo electrónico...");
                Usuario.CorreoElectronico correo_electronico = Usuario.CorreoElectronico.Obtener(1);
                Documento documento = Documento.Obtener(id);
                var socio = (from x in Socio.Socios()
                             where x.id == documento.socio_id
                             select new { x.nombre, x.rfc, x.correo }).First();
                SmtpClient cliente = new SmtpClient();
                string[] destinatarios = ((correo != null) ? correo.Replace(" ", string.Empty).Split(';') : socio.correo.Replace(" ", string.Empty).Split(';'));
                MailMessage mensaje = new MailMessage(body: correo_electronico.mensaje.IsNullOrEmpty() ? string.Format("Número de documento: ", documento.numero_documento) : correo_electronico.mensaje, from: correo_electronico.usuario, to: destinatarios[0], subject: string.Format("Comprobante de tu transacción ({1}) realizada en {0}", Program.Nori.Empresa.nombre_fiscal, (from x in Documento.Clase.Clases()
                                                                                                                                                                                                                                                                                                                                                                                      where x.clase == documento.clase
                                                                                                                                                                                                                                                                                                                                                                                      select x).First().nombre));
                cliente.Port = correo_electronico.puerto;
                cliente.Host = correo_electronico.servidor;
                cliente.EnableSsl = correo_electronico.ssl;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(correo_electronico.usuario, correo_electronico.contraseña);
                if (correo_electronico.remitente.Length > 0)
                {
                    mensaje.From = new MailAddress(correo_electronico.usuario, correo_electronico.remitente);
                }
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.SubjectEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = false;
                mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mensaje.CC.Add(correo_electronico.usuario);
                string[] array = destinatarios;
                foreach (string destinatario in array)
                {
                    mensaje.CC.Add(destinatario);
                }
                mensaje.Attachments.Add(new Attachment(PDFInforme((from x in Informe.Informes()
                                                                   where x.tipo == documento.clase && x.activo == true && x.predeterminado_correo_electronico == true
                                                                   select x.id).First(), documento.id, documento.numero_documento.ToString())));
                if (mensaje.Attachments.Count >= 2)
                {
                    documento.Enviado();
                    await cliente.SendMailAsync(mensaje);
                }
            }
            catch
            {
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static async Task EnviarSeguimientoAsync(string id, string numero_documento, string total, string estado_seguimiento, string nombre, string rfc, string direccion_envio, string correo)
        {
            try
            {
                Usuario.CorreoElectronico correo_electronico = Usuario.CorreoElectronico.Obtener(1);
                SmtpClient cliente = new SmtpClient();
                string[] destinatarios = correo.Replace(" ", string.Empty).Split(';');
                string html7 = File.ReadAllText("seguimiento.html");
                html7 = html7.Replace("{id}", id);
                html7 = html7.Replace("{numero_documento}", numero_documento);
                html7 = html7.Replace("{total}", total);
                html7 = html7.Replace("{estado_seguimiento}", estado_seguimiento);
                html7 = html7.Replace("{nombre}", nombre);
                html7 = html7.Replace("{rfc}", rfc);
                MailMessage mensaje = new MailMessage(body: html7.Replace("{direccion_envio}", direccion_envio), from: correo_electronico.usuario, to: destinatarios[0], subject: $"{Program.Nori.Empresa.nombre_fiscal} - Actualización del estado de su pedido ({estado_seguimiento})");
                cliente.Port = correo_electronico.puerto;
                cliente.Host = correo_electronico.servidor;
                cliente.EnableSsl = correo_electronico.ssl;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(correo_electronico.usuario, correo_electronico.contraseña);
                if (correo_electronico.remitente.Length > 0)
                {
                    mensaje.From = new MailAddress(correo_electronico.usuario, correo_electronico.remitente);
                }
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string[] array = destinatarios;
                foreach (string destinatario in array)
                {
                    mensaje.CC.Add(destinatario);
                }
                await cliente.SendMailAsync(mensaje);
            }
            catch
            {
            }
        }

        public static async Task EnviarLogisticaAsync(int documento_id)
        {
            try
            {
                Usuario.CorreoElectronico correo_electronico = Usuario.CorreoElectronico.Obtener(1);
                SmtpClient cliente = new SmtpClient();
                string correo = (from x in Usuario.Usuarios()
                                 where x.rol == 'L'
                                 select x.correo).First();
                string[] destinatarios = correo.Replace(" ", string.Empty).Split(';');
                var documento = (from x in Documento.Documentos()
                                 where x.id == documento_id
                                 select new { x.id, x.numero_documento, x.clase, x.serie_id, x.almacen_id, x.almacen_destino_id, x.fecha_creacion, x.total, x.comentario, x.usuario_creacion_id }).First();
                string clase = (from x in Documento.Clase.Clases()
                                where x.clase == documento.clase
                                select x.nombre).First();
                string serie = (from x in Serie.Series()
                                where x.id == documento.serie_id
                                select x.nombre).First();
                string almacen_origen = (from x in Almacen.Almacenes()
                                         where x.id == documento.almacen_id
                                         select x.nombre).First();
                string almacen_destino = (from x in Almacen.Almacenes()
                                          where x.id == documento.almacen_destino_id
                                          select x.nombre).First();
                string usuario = (from x in Usuario.Usuarios()
                                  where x.id == documento.usuario_creacion_id
                                  select x.nombre).First();
                MailMessage mensaje = new MailMessage(body: string.Format("<strong>{0}:</strong> {1} {2} \n <strong>Fecha:</strong> {3} \n <strong>Almacénes:</strong> De {4} a {5} \n <strong>Usuario:</strong> {6} \n <strong>Total:</strong> {7} \n <strong>Comentarios:</strong> {8} ", clase, serie, documento.numero_documento, documento.fecha_creacion.ToShortDateString(), almacen_origen, almacen_destino, usuario, documento.total.ToString("c2"), documento.comentario), from: correo_electronico.usuario, to: destinatarios[0], subject: $"{Program.Nori.Empresa.nombre_fiscal} - Nueva actividad de logística detectada | {clase} ({serie} {documento.numero_documento})");
                cliente.Port = correo_electronico.puerto;
                cliente.Host = correo_electronico.servidor;
                cliente.EnableSsl = correo_electronico.ssl;
                cliente.Timeout = 10000;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(correo_electronico.usuario, correo_electronico.contraseña);
                if (correo_electronico.remitente.Length > 0)
                {
                    mensaje.From = new MailAddress(correo_electronico.usuario, correo_electronico.remitente);
                }
                mensaje.BodyEncoding = Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                string[] array = destinatarios;
                foreach (string destinatario in array)
                {
                    mensaje.CC.Add(destinatario);
                }
                await cliente.SendMailAsync(mensaje);
            }
            catch
            {
            }
        }

        public static bool TimbrarDocumento(Pago pago, int documento_electronico_sustitucion_id = 0)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Generando CFDI...");
                bool flag = Program.CFDI.Timbrar(pago, documento_electronico_sustitucion_id);
                if (flag)
                {
                    EnviarCFDiAsync(pago.id, pago: true);
                }
                return flag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Timbrar pago", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static string ObtenerEstado(DocumentoElectronico documento_electronico)
        {
            try
            {
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Obteniendo estado CFDI...");
                return Program.CFDI.ObtenerEstado(documento_electronico);
            }
            catch (Exception ex)
            {
                return ex.Message.ToString().Replace("Nori", "DTM");
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static async void TimbrarDocumentoAsync(Pago pago)
        {
            try
            {
                await Task.Run(() => Program.CFDI.Timbrar(pago));
            }
            catch
            {
            }
        }

        public static void FacturarEntregas()
        {
            try
            {
                List<int> series = (from x in Serie.Series()
                                    where x.activo == true && x.facturar_automaticamente == true && x.serie_facturacion_id != 0 && x.clase == "EN"
                                    select x.id).ToList();
                int num = (from x in Documento.Documentos()
                           where x.socio_id != Program.Nori.UsuarioAutenticado.socio_id && x.clase == "EN" && x.estado == 'A' && x.cancelado == false && series.Contains(x.serie_id) && x.importe_aplicado == 0m
                           select x.id).Count();
                if (MessageBox.Show($"¿Actualmente hay {num} entregas a crédito pendientes de facturar, desea continuar?", "Facturar entregas", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
                SplashScreenManager.Default.SetWaitFormDescription("Generando facturas de entregas...");
                foreach (int item in series)
                {
                    Documento.FacturarEntregas(item, socio_predeterminado: false, credito: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Facturar entregas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static void AbrirTecladoTactil()
        {
            try
            {
                string path = "C:\\Program Files\\Common Files\\Microsoft Shared\\ink";
                string fileName = Path.Combine(path, "TabTip.exe");
                Process process = Process.Start(fileName);
            }
            catch
            {
            }
        }

        public static void AbrirArchivo(string archivo)
        {
            try
            {
                Process.Start(archivo);
            }
            catch (Exception ex)
            {
            }
        }

        public static async void TransmitirRecibir()
        {
            SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Por favor espere");
            SplashScreenManager.Default.SetWaitFormDescription("Transmitiendo...");
            try
            {
                if (!Program.Nori.Configuracion.api_url.IsNullOrEmpty())
                {
                    Transmitir transmitir = new Transmitir();
                    SplashScreenManager.Default.SetWaitFormDescription("Recibiendo...");
                    Recibir recibir = new Recibir();
                    SplashScreenManager.Default.SetWaitFormDescription("Recibiendo artículos...");
                    await recibir.Articulos();
                    SplashScreenManager.Default.SetWaitFormDescription("Recibiendo descuentos...");
                    await recibir.Descuentos();
                    SplashScreenManager.Default.SetWaitFormDescription("Transmitiendo socios...");
                    await transmitir.Socios();
                    SplashScreenManager.Default.SetWaitFormDescription("Transmitiendo documentos...");
                    await transmitir.Documentos();
                    SplashScreenManager.Default.SetWaitFormDescription("Recibiendo socios...");
                    await recibir.Socios();
                }
                else
                {
                    MessageBox.Show("No esta configurada la URL para el API.");
                }
            }
            catch (Exception ex2)
            {
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Transmitir/Recibir", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }

        public static void Cargando(string titulo, string descripcion)
        {
            SplashScreenManager.ShowForm(Form.ActiveForm, typeof(DemoWaitForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption(titulo);
            SplashScreenManager.Default.SetWaitFormDescription(descripcion);
        }

        public static void DescartarCargando()
        {
            SplashScreenManager.CloseForm(false);
        }

        public static bool ServidorDisponible(string servidor)
        {
            int num = servidor.IndexOf("\\");
            if (num > 0)
            {
                servidor = servidor.Substring(0, num);
            }
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(servidor);
            if (pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }

        public static string DigitosAleatorios(int length)
        {
            Random random = new Random();
            string text = string.Empty;
            for (int i = 0; i < length; i++)
            {
                text += random.Next(10);
            }
            return text;
        }

        public static void NoriDynamic()
        {
            if (!File.Exists("NoriDynamic.cs"))
            {
                return;
            }
            string text = File.ReadAllText("NoriDynamic.cs");
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters parametros = new CompilerParameters();
            List<AssemblyName> list = Assembly.GetExecutingAssembly().GetReferencedAssemblies().ToList();
            parametros.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location);
            list.ForEach(delegate (AssemblyName x)
            {
                parametros.ReferencedAssemblies.Add(x.Name + ".dll");
            });
            parametros.GenerateInMemory = true;
            parametros.GenerateExecutable = false;
            parametros.OutputAssembly = "NoriDynamic.dll";
            CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(parametros, text);
            if (compilerResults.Errors.HasErrors)
            {
                string text2 = "";
                text2 = compilerResults.Errors.Count + " Errores:";
                for (int i = 0; i < compilerResults.Errors.Count; i++)
                {
                    text2 = text2 + "\r\nLinea: " + compilerResults.Errors[i].Line + " - " + compilerResults.Errors[i].ErrorText;
                }
                MessageBox.Show(text2, "Compilador DTM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Assembly compiledAssembly = compilerResults.CompiledAssembly;
            Program.ObjetoDinamico = compiledAssembly.CreateInstance("Nori.NoriDynamic");
            if (Program.ObjetoDinamico == null)
            {
                MessageBox.Show("No se pudo cargar la clase.");
                return;
            }
            try
            {
                Program.ObjetoDinamico.GetType().InvokeMember("DynamicCode", BindingFlags.InvokeMethod, null, Program.ObjetoDinamico, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"), "Compilador DTM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public static void MetodoDinamico(object[] parametros, string metodo = "DynamicMethod")
        {
            try
            {
                if (Program.ObjetoDinamico != null)
                {
                    Program.ObjetoDinamico.GetType().InvokeMember(metodo, BindingFlags.InvokeMethod, null, Program.ObjetoDinamico, parametros);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        public static void MetodoDinamico(this object obj, string metodo = "DynamicMethod")
        {
            MetodoDinamico(new object[1] { obj }, metodo);
        }
    }

}
