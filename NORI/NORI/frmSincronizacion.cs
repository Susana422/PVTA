using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using Microsoft.VisualBasic;
using NoriSAPB1SDK;
using NoriSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;



namespace NORI
{
    public partial class frmSincronizacion : RibbonForm
    {
        internal static NoriSAP NoriSAP;

        internal static List<Sucursal> sucursales;

        private string servidor_local = "";

        private bool solo_bajada = false;

        private bool solo_subida = false;

        private IContainer components = null;

        private RibbonControl ribbonControl1;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private PanelControl panelControl1;

        private LayoutControlItem layoutControlItem1;

        private BackgroundWorker bw;

        private Timer timer;

        private SplitContainerControl splitContainerControl1;

        private ListBox lbLogs;

        private GridControl gcSincronizacion;

        private GridView gvSincronizacion;

        private BarButtonItem bbiRestablecerErrores;

        private PopupMenu popupMenuSincronizacion;

        private BarButtonItem bbiEliminar;

        private BarButtonItem bbiAgregarBajada;

        private BarHeaderItem barHeaderItem1;

        private BarButtonItem bbiAregarSubida;

        public frmSincronizacion()
        {
            InitializeComponent();
            this.MetodoDinamico();
            sucursales = (from x in Sucursal.Sucursales()
                          where x.activo == true
                          select x).ToList();
            servidor_local = Program.Nori.Conexion.DataSource;
            if (sucursales.Count == 0)
            {
                MessageBox.Show("No hay sucursales activas.");
            }
        }

        private async void InicializarSAP()
        {
            try
            {
                if (Program.Nori.UsuarioAutenticado.rol != 'A' && Program.Nori.UsuarioAutenticado.rol != 'X')
                {
                    solo_bajada = true;
                }
                else
                {
                    if (MessageBox.Show("¿Desea iniciar la sincronización en modo de solo bajada?", ((Control)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        solo_bajada = true;
                    }
                    if (!solo_bajada && MessageBox.Show("¿Desea iniciar la sincronización en modo de solo subida?", ((Control)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        solo_subida = true;
                    }
                }
                NoriSAP = new NoriSAP(Configuracion.SAP.Obtener(), solo_bajada);
                bool conexion_sap = false;
                if (!solo_bajada)
                {
                    conexion_sap = await NoriSAP.Conectar();
                }
                if (!conexion_sap && !solo_bajada)
                {
                    MessageBox.Show(NoriSAP.ObtenerUltimoError().Message.ToString().Replace("Nori", "DTM"));
                }
                if (solo_bajada || conexion_sap)
                {
                    NoriSAP.ReportProgress = (EventHandler<NoriSAP.ProgressArgs>)Delegate.Combine(NoriSAP.ReportProgress, new EventHandler<NoriSAP.ProgressArgs>(bw_ReportProgress));
                    bw.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Imposible inicializar la sincronización, resvise su conexión y/o la configuración de las sucursales");
                }
            }
            catch (Exception ex3)
            {
                Exception ex2 = ex3;
                Exception ex = ex2;
                MessageBox.Show("Ocurrió un problema al iniciar la sincronización. " + ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        protected void bw_ReportProgress(object sender, NoriSAP.ProgressArgs e)
        {
            try
            {
                bw.ReportProgress(1, e.Message);
            }
            catch
            {
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                foreach (Sucursal sucursal in sucursales)
                {
                    try
                    {
                        Program.Nori.Conexion.DataSource = sucursal.servidor;
                        Program.Nori.Conexion.InitialCatalog = sucursal.bd;
                        if (sucursal.contraseña.IsNullOrEmpty())
                        {
                            Program.Nori.Conexion.IntegratedSecurity = true;
                        }
                        Program.Nori.Conexion.UserID = sucursal.usuario;
                        Program.Nori.Conexion.Password = sucursal.contraseña;
                        Program.Nori.Conexion.ConnectTimeout = 100;
                        if (Funciones.ServidorDisponible(sucursal.servidor))
                        {
                            if (Program.Nori.Conectar())
                            {
                                string mensaje = (solo_bajada ? " - BAJADA - " : "");
                                mensaje = (solo_subida ? " - SUBIDA - " : mensaje);
                                SafeInvoke(this, delegate
                                {
                                    ((Control)this).Text = "Sincronización (" + sucursal.nombre + ")" + mensaje;
                                });
                                if (solo_subida)
                                {
                                    sucursal.solo_subida = true;
                                    goto IL_0205;
                                }
                                if (!solo_bajada || !sucursal.solo_subida)
                                {
                                    goto IL_0205;
                                }
                            }
                            else
                            {
                                lbLogs.Items.Add("No se pudo conectar al servidor " + sucursal.servidor);
                            }
                        }
                        else
                        {
                            lbLogs.Items.Add("No se pudo conectar al servidor " + sucursal.servidor);
                        }
                        goto end_IL_002e;
                    IL_0205:
                        lbLogs.Items.Add(NoriSAP.Sincronizar(sucursal));
                    end_IL_002e:;
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                lbLogs.Items.Add(ex.Message.ToString().Replace("Nori", "DTM"));
                bw.RunWorkerAsync();
            }
        }

        public static void SafeInvoke(Control control, Action action)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    control.Invoke((MethodInvoker)delegate
                    {
                        action();
                    });
                }
                else
                {
                    action();
                }
            }
            catch
            {
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                Application.DoEvents();
                lbLogs.Items.Insert(0, e.UserState.ToString());
                Application.DoEvents();
            }
            catch
            {
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (!bw.IsBusy)
                {
                    if (Program.Nori.UsuarioAutenticado.VendedorForaneo())
                    {
                        timer.Stop();
                        timer.Enabled = false;
                        Close();
                    }
                    else
                    {
                        lbLogs.Items.Clear();
                        bw.RunWorkerAsync();
                    }
                }
            }
            catch
            {
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                gcSincronizacion.DataSource = Utilidades.EjecutarQuery("SELECT ID, Tabla, Registro, (CASE WHEN tabla = 'documentos' THEN (SELECT clase FROM documentos WHERE id = registro) WHEN tabla = 'socios' THEN (SELECT codigo FROM socios WHERE id = registro) ELSE '' END) Info, Error, Fecha FROM sincronizacion");
                gcSincronizacion.RefreshDataSource();
            }
            catch
            {
            }
        }

        private void frmSincronizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (bw.IsBusy)
                {
                    bw.CancelAsync();
                }
                NoriSAP = null;
                bw.Dispose();
                Dispose();
                GC.Collect();
                if (!Program.Nori.UsuarioAutenticado.VendedorForaneo())
                {
                    Program.Nori.UsuarioAutenticado.Desconectar();
                    Funciones.MatarProcesos();
                }
            }
            catch
            {
            }
        }

        private void frmSincronizacion_Load(object sender, EventArgs e)
        {
            try
            {
                if (Program.Nori.Configuracion.sap && MessageBox.Show("Desea iniciar la sincronización", ((Control)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InicializarSAP();
                }
                timer.Enabled = true;
                timer.Start();
            }
            catch
            {
            }
        }

        private void bbiRestablecerErrores_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Utilidades.EjecutarQuery("UPDATE sincronizacion SET error = ''");
            }
            catch
            {
            }
        }

        private void bbiAgregarBajada_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string text = Interaction.InputBox("Ingresa la tabla del registro que deseas descargar.", "Agregar bajada", "OINV");
                string text2 = Interaction.InputBox("Ingresa el registro que deseas descargar.", "Agregar bajada");
                if (text.Length > 0 && text2.Length > 0 && MessageBox.Show("¿Esta seguro de agregar el registro " + text2 + " de la tabla " + text + "?", ((Control)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sincronizacion.Manual manual = new Sincronizacion.Manual();
                    manual.tabla = text;
                    manual.registro = text2;
                    if (manual.Agregar())
                    {
                        MessageBox.Show("Se agregó el registro correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No fue posible agregar el registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void bbiEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string text = Interaction.InputBox("Ingresa ID del registro que deseas eliminar de la sincronización", "Eliminar registro");
                if (text.Length <= 0 || MessageBox.Show("¿Esta seguro de eliminar el registro " + text + "?", ((Control)this).Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                Sincronizacion sincronizacion = Sincronizacion.Obtener(int.Parse(text));
                if (sincronizacion.id != 0)
                {
                    if (sincronizacion.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No fue posible eliminar el registro.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros coincidentes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }

        private void bbiAregarSubida_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string text = Interaction.InputBox("Ingresa la tabla del registro que deseas cargar.", "Agregar subida", "documentos");
                string text2 = Interaction.InputBox("Ingresa el ID del registro que deseas cargar.", "Agregar subida");
                if (text.Length > 0 && text2.Length > 0 && MessageBox.Show("¿Esta seguro de agregar el registro " + text2 + " de la tabla " + text + "?", ((Control)this).Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sincronizacion sincronizacion = new Sincronizacion();
                    sincronizacion.tabla = text;
                    sincronizacion.registro = int.Parse(text2);
                    if (sincronizacion.Agregar())
                    {
                        MessageBox.Show("Se agregó el registro correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No fue posible agregar el registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Replace("Nori", "DTM"));
            }
        }
    }
}
