using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTab;
using Microsoft.VisualBasic;
using Padding = System.Windows.Forms.Padding;

namespace DTM
{
    partial class frmEntradaMercancia
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
         this.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRecargar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimir = new DevExpress.XtraBars.BarSubItem();
            this.bbiNuevoSocio = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopiar = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemMapaRelaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPDF = new DevExpress.XtraBars.BarSubItem();
            this.bbiCorreoPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiCerrar = new DevExpress.XtraBars.BarStaticItem();
            this.bbiPagar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.lblNoDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblNumeroDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblSocio = new DevExpress.XtraEditors.LabelControl();
            this.lblReferencia = new DevExpress.XtraEditors.LabelControl();
            this.txtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.lblIdentificadorExterno = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.txtNumeroDocumento = new DevExpress.XtraEditors.TextEdit();
            this.txtComentario = new DevExpress.XtraEditors.MemoEdit();
            this.lblComentario = new DevExpress.XtraEditors.LabelControl();
            this.cbVendedores = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVendedores = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnArticuloID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUnidadesMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnCantidadEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTipoEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTiposEmpaques = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnTipoTara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidadPaquete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAlmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbAlmacenes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRecargar,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.bbiImprimir,
            this.bbiNuevoSocio,
            this.bbiCopiar,
            this.barButtonItemMapaRelaciones,
            this.bbiPDF,
            this.bbiCorreoPDF,
            this.bbiCancelar,
            this.bbiCerrar,
            this.bbiPagar,
            this.bbiGuardarImprimir});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 16;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 257;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(994, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiGuardarCerrar
            // 
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar pedido";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            this.bbiGuardarCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarCerrar_ItemClick);
            // 
            // bbiGuardarNuevo
            // 
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            // 
            // bbiRecargar
            // 
            this.bbiRecargar.Caption = "Recargar";
            this.bbiRecargar.Id = 1;
            this.bbiRecargar.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRecargar.Name = "bbiRecargar";
            // 
            // bbiBuscar
            // 
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageOptions.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiPrimero
            // 
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageOptions.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiAnterior
            // 
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageOptions.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiSiguiente
            // 
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "AddItem";
            this.bbiNuevo.Name = "bbiNuevo";
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 4;
            this.bbiImprimir.ImageOptions.ImageUri.Uri = "Print";
            this.bbiImprimir.Name = "bbiImprimir";
            // 
            // bbiNuevoSocio
            // 
            this.bbiNuevoSocio.Caption = "Nuevo socio";
            this.bbiNuevoSocio.Id = 5;
            this.bbiNuevoSocio.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevoSocio.Name = "bbiNuevoSocio";
            // 
            // bbiCopiar
            // 
            this.bbiCopiar.Caption = "Copiar";
            this.bbiCopiar.Id = 7;
            this.bbiCopiar.ImageOptions.ImageUri.Uri = "Replace";
            this.bbiCopiar.Name = "bbiCopiar";
            // 
            // barButtonItemMapaRelaciones
            // 
            this.barButtonItemMapaRelaciones.Caption = "Mapa de relaciones";
            this.barButtonItemMapaRelaciones.Id = 8;
            this.barButtonItemMapaRelaciones.ImageOptions.ImageUri.Uri = "SendToBack";
            this.barButtonItemMapaRelaciones.Name = "barButtonItemMapaRelaciones";
            // 
            // bbiPDF
            // 
            this.bbiPDF.Caption = "PDF";
            this.bbiPDF.Id = 10;
            this.bbiPDF.ImageOptions.ImageUri.Uri = "ExportToPDF";
            this.bbiPDF.Name = "bbiPDF";
            // 
            // bbiCorreoPDF
            // 
            this.bbiCorreoPDF.Caption = "Enviar";
            this.bbiCorreoPDF.Id = 11;
            this.bbiCorreoPDF.ImageOptions.ImageUri.Uri = "SendPDF";
            this.bbiCorreoPDF.Name = "bbiCorreoPDF";
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 12;
            this.bbiCancelar.ImageOptions.ImageUri.Uri = "Cancel";
            this.bbiCancelar.Name = "bbiCancelar";
            // 
            // bbiCerrar
            // 
            this.bbiCerrar.Caption = "Cerrar";
            this.bbiCerrar.Id = 13;
            this.bbiCerrar.ImageOptions.ImageUri.Uri = "Close";
            this.bbiCerrar.Name = "bbiCerrar";
            // 
            // bbiPagar
            // 
            this.bbiPagar.Caption = "Pagar";
            this.bbiPagar.Id = 14;
            this.bbiPagar.ImageOptions.ImageUri.Uri = "Currency";
            this.bbiPagar.Name = "bbiPagar";
            // 
            // bbiGuardarImprimir
            // 
            this.bbiGuardarImprimir.Caption = "Guardar e imprimir";
            this.bbiGuardarImprimir.Id = 15;
            this.bbiGuardarImprimir.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarImprimir.Name = "bbiGuardarImprimir";
            this.bbiGuardarImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarImprimir_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarImprimir);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Opciones";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(428, 309, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(994, 741);
            this.layoutControl1.TabIndex = 59;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 5);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageGeneral;
            this.xtraTabControl1.Size = new System.Drawing.Size(984, 731);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageGeneral});
            // 
            // xtraTabPageGeneral
            // 
            this.xtraTabPageGeneral.Controls.Add(this.lblNoDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.lblNumeroDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.lblSocio);
            this.xtraTabPageGeneral.Controls.Add(this.lblReferencia);
            this.xtraTabPageGeneral.Controls.Add(this.txtReferencia);
            this.xtraTabPageGeneral.Controls.Add(this.lblIdentificadorExterno);
            this.xtraTabPageGeneral.Controls.Add(this.separatorControl1);
            this.xtraTabPageGeneral.Controls.Add(this.pictureBox1);
            this.xtraTabPageGeneral.Controls.Add(this.txtArticulo);
            this.xtraTabPageGeneral.Controls.Add(this.txtNumeroDocumento);
            this.xtraTabPageGeneral.Controls.Add(this.txtComentario);
            this.xtraTabPageGeneral.Controls.Add(this.lblComentario);
            this.xtraTabPageGeneral.Controls.Add(this.cbVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.lblVendedores);
            this.xtraTabPageGeneral.Controls.Add(this.gcPartidas);
            this.xtraTabPageGeneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPageGeneral.Name = "xtraTabPageGeneral";
            this.xtraTabPageGeneral.Size = new System.Drawing.Size(982, 706);
            this.xtraTabPageGeneral.Text = "General";
            // 
            // lblNoDocumento
            // 
            this.lblNoDocumento.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoDocumento.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblNoDocumento.Appearance.Options.UseFont = true;
            this.lblNoDocumento.Appearance.Options.UseForeColor = true;
            this.lblNoDocumento.Location = new System.Drawing.Point(12, 9);
            this.lblNoDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNoDocumento.Name = "lblNoDocumento";
            this.lblNoDocumento.Size = new System.Drawing.Size(71, 13);
            this.lblNoDocumento.TabIndex = 124;
            this.lblNoDocumento.Text = "N° de pedido";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(600, 21);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(79, 17);
            this.lblNumeroDocumento.TabIndex = 123;
            this.lblNumeroDocumento.Text = "N° de pedido";
            // 
            // lblSocio
            // 
            this.lblSocio.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSocio.Appearance.Options.UseFont = true;
            this.lblSocio.Location = new System.Drawing.Point(12, 31);
            this.lblSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(100, 13);
            this.lblSocio.TabIndex = 122;
            this.lblSocio.Text = "Socio de negocios";
            // 
            // lblReferencia
            // 
            this.lblReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReferencia.Location = new System.Drawing.Point(12, 603);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(65, 17);
            this.lblReferencia.TabIndex = 121;
            this.lblReferencia.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReferencia.Location = new System.Drawing.Point(131, 599);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Properties.MaxLength = 100;
            this.txtReferencia.Size = new System.Drawing.Size(231, 24);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.TabStop = false;
            // 
            // lblIdentificadorExterno
            // 
            this.lblIdentificadorExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdentificadorExterno.Location = new System.Drawing.Point(12, 642);
            this.lblIdentificadorExterno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblIdentificadorExterno.Name = "lblIdentificadorExterno";
            this.lblIdentificadorExterno.Size = new System.Drawing.Size(7, 17);
            this.lblIdentificadorExterno.TabIndex = 119;
            this.lblIdentificadorExterno.Text = "0";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.Location = new System.Drawing.Point(12, 46);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.separatorControl1.Size = new System.Drawing.Size(936, 23);
            this.separatorControl1.TabIndex = 112;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticulo.Location = new System.Drawing.Point(48, 69);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(902, 24);
            this.txtArticulo.TabIndex = 1;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(719, 17);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(231, 24);
            this.txtNumeroDocumento.TabIndex = 0;
            this.txtNumeroDocumento.TabStop = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentario.Location = new System.Drawing.Point(719, 566);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComentario.MenuManager = this.mainRibbonControl;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(231, 93);
            this.txtComentario.TabIndex = 0;
            this.txtComentario.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentario.Location = new System.Drawing.Point(600, 570);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(71, 17);
            this.lblComentario.TabIndex = 84;
            this.lblComentario.Text = "Comentario";
            // 
            // cbVendedores
            // 
            this.cbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVendedores.Location = new System.Drawing.Point(131, 566);
            this.cbVendedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVendedores.MenuManager = this.mainRibbonControl;
            this.cbVendedores.Name = "cbVendedores";
            this.cbVendedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVendedores.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 16, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbVendedores.Size = new System.Drawing.Size(231, 24);
            this.cbVendedores.TabIndex = 0;
            this.cbVendedores.TabStop = false;
            // 
            // lblVendedores
            // 
            this.lblVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVendedores.Location = new System.Drawing.Point(12, 568);
            this.lblVendedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(61, 17);
            this.lblVendedores.TabIndex = 82;
            this.lblVendedores.Text = "Vendedor";
            // 
            // gcPartidas
            // 
            this.gcPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPartidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPartidas.Location = new System.Drawing.Point(12, 106);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAlmacenes,
            this.cbTiposEmpaques,
            this.cbUnidadesMedida});
            this.gcPartidas.Size = new System.Drawing.Size(936, 452);
            this.gcPartidas.TabIndex = 1;
            this.gcPartidas.TabStop = false;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPartidas});
            // 
            // gvPartidas
            // 
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnArticuloID,
            this.gridColumnCantidad,
            this.gridColumnUnidadMedida,
            this.gridColumnCantidadEmpaque,
            this.gridColumnTipoEmpaque,
            this.gridColumnTipoTara,
            this.gridColumnCantidadPaquete,
            this.gridColumnArticulo,
            this.gridColumnCodigoBarras,
            this.gridColumnAlmacen,
            this.gridColumnComentario});
            this.gvPartidas.DetailHeight = 458;
            this.gvPartidas.FixedLineWidth = 3;
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsCustomization.AllowSort = false;
            this.gvPartidas.OptionsEditForm.PopupEditFormWidth = 622;
            this.gvPartidas.OptionsView.ShowGroupPanel = false;
            this.gvPartidas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvPartidas_RowStyle);
            this.gvPartidas.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvPartidas_CellValueChanged);
            // 
            // gridColumnArticuloID
            // 
            this.gridColumnArticuloID.Caption = "Artículo ID";
            this.gridColumnArticuloID.FieldName = "articulo_id";
            this.gridColumnArticuloID.MinWidth = 23;
            this.gridColumnArticuloID.Name = "gridColumnArticuloID";
            this.gridColumnArticuloID.Width = 87;
            // 
            // gridColumnCantidad
            // 
            this.gridColumnCantidad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumnCantidad.AppearanceCell.Options.UseFont = true;
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MaxWidth = 152;
            this.gridColumnCantidad.MinWidth = 35;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.OptionsColumn.FixedWidth = true;
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 0;
            this.gridColumnCantidad.Width = 70;
            // 
            // gridColumnUnidadMedida
            // 
            this.gridColumnUnidadMedida.Caption = "UdM";
            this.gridColumnUnidadMedida.ColumnEdit = this.cbUnidadesMedida;
            this.gridColumnUnidadMedida.FieldName = "unidad_medida_id";
            this.gridColumnUnidadMedida.MaxWidth = 93;
            this.gridColumnUnidadMedida.MinWidth = 23;
            this.gridColumnUnidadMedida.Name = "gridColumnUnidadMedida";
            this.gridColumnUnidadMedida.OptionsColumn.AllowEdit = false;
            this.gridColumnUnidadMedida.Visible = true;
            this.gridColumnUnidadMedida.VisibleIndex = 1;
            this.gridColumnUnidadMedida.Width = 93;
            // 
            // cbUnidadesMedida
            // 
            this.cbUnidadesMedida.AutoHeight = false;
            this.cbUnidadesMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadesMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            // 
            // gridColumnCantidadEmpaque
            // 
            this.gridColumnCantidadEmpaque.Caption = "C/E";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatString = "n2";
            this.gridColumnCantidadEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadEmpaque.FieldName = "cantidad_empaque";
            this.gridColumnCantidadEmpaque.MinWidth = 23;
            this.gridColumnCantidadEmpaque.Name = "gridColumnCantidadEmpaque";
            this.gridColumnCantidadEmpaque.Visible = true;
            this.gridColumnCantidadEmpaque.VisibleIndex = 2;
            this.gridColumnCantidadEmpaque.Width = 40;
            // 
            // gridColumnTipoEmpaque
            // 
            this.gridColumnTipoEmpaque.Caption = "Tipo empaque";
            this.gridColumnTipoEmpaque.ColumnEdit = this.cbTiposEmpaques;
            this.gridColumnTipoEmpaque.FieldName = "tipo_empaque_id";
            this.gridColumnTipoEmpaque.MinWidth = 23;
            this.gridColumnTipoEmpaque.Name = "gridColumnTipoEmpaque";
            this.gridColumnTipoEmpaque.Visible = true;
            this.gridColumnTipoEmpaque.VisibleIndex = 3;
            this.gridColumnTipoEmpaque.Width = 103;
            // 
            // cbTiposEmpaques
            // 
            this.cbTiposEmpaques.AutoHeight = false;
            this.cbTiposEmpaques.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposEmpaques.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTiposEmpaques.Name = "cbTiposEmpaques";
            // 
            // gridColumnTipoTara
            // 
            this.gridColumnTipoTara.Caption = "Tara";
            this.gridColumnTipoTara.ColumnEdit = this.cbTiposEmpaques;
            this.gridColumnTipoTara.FieldName = "tipo_tara_id";
            this.gridColumnTipoTara.MinWidth = 23;
            this.gridColumnTipoTara.Name = "gridColumnTipoTara";
            this.gridColumnTipoTara.Visible = true;
            this.gridColumnTipoTara.VisibleIndex = 4;
            this.gridColumnTipoTara.Width = 103;
            // 
            // gridColumnCantidadPaquete
            // 
            this.gridColumnCantidadPaquete.Caption = "Cant/Paq";
            this.gridColumnCantidadPaquete.FieldName = "cantidad_paquete";
            this.gridColumnCantidadPaquete.MaxWidth = 70;
            this.gridColumnCantidadPaquete.MinWidth = 40;
            this.gridColumnCantidadPaquete.Name = "gridColumnCantidadPaquete";
            this.gridColumnCantidadPaquete.OptionsColumn.AllowEdit = false;
            this.gridColumnCantidadPaquete.Visible = true;
            this.gridColumnCantidadPaquete.VisibleIndex = 5;
            this.gridColumnCantidadPaquete.Width = 54;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumnArticulo.AppearanceCell.Options.UseFont = true;
            this.gridColumnArticulo.Caption = "Artículo";
            this.gridColumnArticulo.FieldName = "nombre";
            this.gridColumnArticulo.MinWidth = 117;
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.OptionsColumn.AllowEdit = false;
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 6;
            this.gridColumnArticulo.Width = 159;
            // 
            // gridColumnCodigoBarras
            // 
            this.gridColumnCodigoBarras.Caption = "Código de barras";
            this.gridColumnCodigoBarras.FieldName = "codigo_barras";
            this.gridColumnCodigoBarras.MinWidth = 93;
            this.gridColumnCodigoBarras.Name = "gridColumnCodigoBarras";
            this.gridColumnCodigoBarras.OptionsColumn.AllowEdit = false;
            this.gridColumnCodigoBarras.Width = 99;
            // 
            // gridColumnAlmacen
            // 
            this.gridColumnAlmacen.Caption = "Almacén";
            this.gridColumnAlmacen.ColumnEdit = this.cbAlmacenes;
            this.gridColumnAlmacen.FieldName = "almacen_id";
            this.gridColumnAlmacen.MinWidth = 23;
            this.gridColumnAlmacen.Name = "gridColumnAlmacen";
            this.gridColumnAlmacen.OptionsColumn.AllowEdit = false;
            this.gridColumnAlmacen.Visible = true;
            this.gridColumnAlmacen.VisibleIndex = 7;
            this.gridColumnAlmacen.Width = 63;
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.AutoHeight = false;
            this.cbAlmacenes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAlmacenes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código", 16, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbAlmacenes.Name = "cbAlmacenes";
            // 
            // gridColumnComentario
            // 
            this.gridColumnComentario.Caption = "Comentario";
            this.gridColumnComentario.FieldName = "comentario";
            this.gridColumnComentario.MinWidth = 23;
            this.gridColumnComentario.Name = "gridColumnComentario";
            this.gridColumnComentario.Visible = true;
            this.gridColumnComentario.VisibleIndex = 8;
            this.gridColumnComentario.Width = 84;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(994, 741);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(986, 733);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmEntradaMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 820);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEntradaMercancia";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de mercancía";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageGeneral.ResumeLayout(false);
            this.xtraTabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComentario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVendedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadesMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposEmpaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}