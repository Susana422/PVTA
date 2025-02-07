﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
namespace DTM
{
    partial class frmInformes
    {

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
                // Dispose(disposing);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRestablecer = new DevExpress.XtraBars.BarButtonItem();
            this.bbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrimero = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAnterior = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUltimo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSiguiente = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblTipo = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbImpresoras = new DevExpress.XtraEditors.LookUpEdit();
            this.lblImpresora = new DevExpress.XtraEditors.LabelControl();
            this.lblQuitarSecuencia = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbPredeterminadoCorreoElectronico = new DevExpress.XtraEditors.CheckEdit();
            this.cbInformeSecuencia = new DevExpress.XtraEditors.LookUpEdit();
            this.lblInformeSecuencia = new DevExpress.XtraEditors.LabelControl();
            this.txtCopias = new DevExpress.XtraEditors.TextEdit();
            this.lblCopias = new DevExpress.XtraEditors.LabelControl();
            this.cbAlmacen = new DevExpress.XtraEditors.CheckEdit();
            this.btnEditarInforme = new DevExpress.XtraEditors.SimpleButton();
            this.cbPredeterminado = new DevExpress.XtraEditors.CheckEdit();
            this.cbTiposInforme = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTipoInforme = new DevExpress.XtraEditors.LabelControl();
            this.btnInforme = new DevExpress.XtraEditors.SimpleButton();
            this.txtInforme = new DevExpress.XtraEditors.TextEdit();
            this.lblInforme = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.cbTipos = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpresoras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminadoCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInformeSecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposInforme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInforme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 39, 35, 39);
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRestablecer,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 385;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(668, 79);
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
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
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
            this.bbiGuardarNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarNuevo_ItemClick);
            // 
            // bbiEliminar
            // 
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminar_ItemClick);
            // 
            // bbiRestablecer
            // 
            this.bbiRestablecer.Id = 1;
            this.bbiRestablecer.Name = "bbiRestablecer";
            // 
            // bbiBuscar
            // 
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageOptions.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiBuscar_ItemClick);
            // 
            // bbiPrimero
            // 
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageOptions.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiPrimero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrimero_ItemClick);
            // 
            // bbiAnterior
            // 
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageOptions.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAnterior_ItemClick);
            // 
            // bbiUltimo
            // 
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiUltimo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUltimo_ItemClick);
            // 
            // bbiSiguiente
            // 
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiSiguiente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSiguiente_ItemClick);
            // 
            // bbiNuevo
            // 
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevo_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.searchRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiEliminar);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Opciones";
            // 
            // searchRibbonPageGroup
            // 
            this.searchRibbonPageGroup.AllowTextClipping = false;
            this.searchRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiBuscar);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiPrimero);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiAnterior);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiSiguiente);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiUltimo);
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Navegación";
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(399, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(7, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(14, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(491, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(14, 21);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(24, 17);
            this.lblTipo.TabIndex = 44;
            this.lblTipo.Text = "Tipo";
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(133, 289);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(112, 21);
            this.cbActivo.TabIndex = 8;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(559, 297);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(399, 297);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbImpresoras);
            this.panel1.Controls.Add(this.lblImpresora);
            this.panel1.Controls.Add(this.lblQuitarSecuencia);
            this.panel1.Controls.Add(this.cbPredeterminadoCorreoElectronico);
            this.panel1.Controls.Add(this.cbInformeSecuencia);
            this.panel1.Controls.Add(this.lblInformeSecuencia);
            this.panel1.Controls.Add(this.txtCopias);
            this.panel1.Controls.Add(this.lblCopias);
            this.panel1.Controls.Add(this.cbAlmacen);
            this.panel1.Controls.Add(this.btnEditarInforme);
            this.panel1.Controls.Add(this.cbPredeterminado);
            this.panel1.Controls.Add(this.cbTiposInforme);
            this.panel1.Controls.Add(this.lblTipoInforme);
            this.panel1.Controls.Add(this.btnInforme);
            this.panel1.Controls.Add(this.txtInforme);
            this.panel1.Controls.Add(this.lblInforme);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.cbTipos);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 354);
            this.panel1.TabIndex = 53;
            // 
            // cbImpresoras
            // 
            this.cbImpresoras.Location = new System.Drawing.Point(133, 255);
            this.cbImpresoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbImpresoras.MenuManager = this.mainRibbonControl;
            this.cbImpresoras.Name = "cbImpresoras";
            this.cbImpresoras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImpresoras.Size = new System.Drawing.Size(259, 24);
            this.cbImpresoras.TabIndex = 62;
            // 
            // lblImpresora
            // 
            this.lblImpresora.Location = new System.Drawing.Point(14, 259);
            this.lblImpresora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblImpresora.Name = "lblImpresora";
            this.lblImpresora.Size = new System.Drawing.Size(59, 17);
            this.lblImpresora.TabIndex = 63;
            this.lblImpresora.Text = "Impresora";
            // 
            // lblQuitarSecuencia
            // 
            this.lblQuitarSecuencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitarSecuencia.Location = new System.Drawing.Point(399, 191);
            this.lblQuitarSecuencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblQuitarSecuencia.Name = "lblQuitarSecuencia";
            this.lblQuitarSecuencia.Size = new System.Drawing.Size(102, 17);
            this.lblQuitarSecuencia.TabIndex = 61;
            this.lblQuitarSecuencia.Text = "Quitar secuencia";
            // 
            // cbPredeterminadoCorreoElectronico
            // 
            this.cbPredeterminadoCorreoElectronico.Location = new System.Drawing.Point(399, 222);
            this.cbPredeterminadoCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPredeterminadoCorreoElectronico.MenuManager = this.mainRibbonControl;
            this.cbPredeterminadoCorreoElectronico.Name = "cbPredeterminadoCorreoElectronico";
            this.cbPredeterminadoCorreoElectronico.Properties.Caption = "Predeterminado correo electrónico";
            this.cbPredeterminadoCorreoElectronico.Size = new System.Drawing.Size(225, 21);
            this.cbPredeterminadoCorreoElectronico.TabIndex = 59;
            // 
            // cbInformeSecuencia
            // 
            this.cbInformeSecuencia.Location = new System.Drawing.Point(133, 187);
            this.cbInformeSecuencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInformeSecuencia.MenuManager = this.mainRibbonControl;
            this.cbInformeSecuencia.Name = "cbInformeSecuencia";
            this.cbInformeSecuencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbInformeSecuencia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbInformeSecuencia.Size = new System.Drawing.Size(259, 24);
            this.cbInformeSecuencia.TabIndex = 60;
            // 
            // lblInformeSecuencia
            // 
            this.lblInformeSecuencia.Location = new System.Drawing.Point(14, 191);
            this.lblInformeSecuencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInformeSecuencia.Name = "lblInformeSecuencia";
            this.lblInformeSecuencia.Size = new System.Drawing.Size(64, 17);
            this.lblInformeSecuencia.TabIndex = 0;
            this.lblInformeSecuencia.Text = "Secuencia";
            // 
            // txtCopias
            // 
            this.txtCopias.Location = new System.Drawing.Point(133, 221);
            this.txtCopias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCopias.MenuManager = this.mainRibbonControl;
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(117, 24);
            this.txtCopias.TabIndex = 5;
            // 
            // lblCopias
            // 
            this.lblCopias.Location = new System.Drawing.Point(14, 225);
            this.lblCopias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(41, 17);
            this.lblCopias.TabIndex = 58;
            this.lblCopias.Text = "Copias";
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.Location = new System.Drawing.Point(252, 289);
            this.cbAlmacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlmacen.MenuManager = this.mainRibbonControl;
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Properties.Caption = "Almacén";
            this.cbAlmacen.Size = new System.Drawing.Size(127, 21);
            this.cbAlmacen.TabIndex = 7;
            // 
            // btnEditarInforme
            // 
            this.btnEditarInforme.Location = new System.Drawing.Point(472, 153);
            this.btnEditarInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarInforme.Name = "btnEditarInforme";
            this.btnEditarInforme.Size = new System.Drawing.Size(152, 26);
            this.btnEditarInforme.TabIndex = 0;
            this.btnEditarInforme.TabStop = false;
            this.btnEditarInforme.Text = "Editar informe";
            // 
            // cbPredeterminado
            // 
            this.cbPredeterminado.Location = new System.Drawing.Point(265, 222);
            this.cbPredeterminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPredeterminado.MenuManager = this.mainRibbonControl;
            this.cbPredeterminado.Name = "cbPredeterminado";
            this.cbPredeterminado.Properties.Caption = "Predeterminado";
            this.cbPredeterminado.Size = new System.Drawing.Size(127, 21);
            this.cbPredeterminado.TabIndex = 6;
            // 
            // cbTiposInforme
            // 
            this.cbTiposInforme.Location = new System.Drawing.Point(133, 153);
            this.cbTiposInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTiposInforme.MenuManager = this.mainRibbonControl;
            this.cbTiposInforme.Name = "cbTiposInforme";
            this.cbTiposInforme.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposInforme.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTiposInforme.Size = new System.Drawing.Size(259, 24);
            this.cbTiposInforme.TabIndex = 4;
            // 
            // lblTipoInforme
            // 
            this.lblTipoInforme.Location = new System.Drawing.Point(14, 157);
            this.lblTipoInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTipoInforme.Name = "lblTipoInforme";
            this.lblTipoInforme.Size = new System.Drawing.Size(72, 17);
            this.lblTipoInforme.TabIndex = 57;
            this.lblTipoInforme.Text = "Tipo informe";
            // 
            // btnInforme
            // 
            this.btnInforme.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnInforme.Location = new System.Drawing.Point(584, 119);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(40, 26);
            this.btnInforme.TabIndex = 3;
            // 
            // txtInforme
            // 
            this.txtInforme.Enabled = false;
            this.txtInforme.Location = new System.Drawing.Point(133, 119);
            this.txtInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInforme.MenuManager = this.mainRibbonControl;
            this.txtInforme.Name = "txtInforme";
            this.txtInforme.Properties.MaxLength = 254;
            this.txtInforme.Size = new System.Drawing.Size(491, 24);
            this.txtInforme.TabIndex = 0;
            this.txtInforme.TabStop = false;
            // 
            // lblInforme
            // 
            this.lblInforme.Location = new System.Drawing.Point(14, 123);
            this.lblInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(45, 17);
            this.lblInforme.TabIndex = 55;
            this.lblInforme.Text = "Informe";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 85);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.MenuManager = this.mainRibbonControl;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 254;
            this.txtDescripcion.Size = new System.Drawing.Size(491, 24);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(14, 89);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(71, 17);
            this.lblDescripcion.TabIndex = 53;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cbTipos
            // 
            this.cbTipos.Location = new System.Drawing.Point(133, 17);
            this.cbTipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipos.MenuManager = this.mainRibbonControl;
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tipo", "Tipo", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbTipos.Size = new System.Drawing.Size(259, 24);
            this.cbTipos.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(668, 405);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(668, 405);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 484);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmInformes";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbImpresoras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminadoCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInformeSecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAlmacen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPredeterminado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposInforme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInforme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}