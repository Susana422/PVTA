﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;

namespace DTM
{
    partial class frmVehiculos
    {

        protected override void Dispose(bool disposing)
        {
            try
            {
                components.Dispose();
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
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.lblPeso = new DevExpress.XtraEditors.LabelControl();
            this.txtAseguradora = new DevExpress.XtraEditors.TextEdit();
            this.lblAseguradora = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroPoliza = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroPoliza = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroPermisoSCT = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroPermisoSCT = new DevExpress.XtraEditors.LabelControl();
            this.txtPermisoSCT = new DevExpress.XtraEditors.TextEdit();
            this.lblPermisoSCT = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroPlacas = new DevExpress.XtraEditors.TextEdit();
            this.lblNumeroPlacas = new DevExpress.XtraEditors.LabelControl();
            this.txtConfiguracionVehicular = new DevExpress.XtraEditors.TextEdit();
            this.lblConfiguracionVehicular = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.lblModelo = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAseguradora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPermisoSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermisoSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPlacas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfiguracionVehicular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
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
            this.bbiRestablecer,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.OptionsMenuMinWidth = 257;
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(666, 79);
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
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
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
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(7, 17);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(14, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 17);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 51);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MenuManager = this.mainRibbonControl;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 100;
            this.txtNombre.Size = new System.Drawing.Size(492, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(14, 21);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 17);
            this.lblCodigo.TabIndex = 44;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.MenuManager = this.mainRibbonControl;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.MaxLength = 8;
            this.txtCodigo.Size = new System.Drawing.Size(255, 24);
            this.txtCodigo.TabIndex = 0;
            // 
            // cbActivo
            // 
            this.cbActivo.Location = new System.Drawing.Point(14, 240);
            this.cbActivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(140, 21);
            this.cbActivo.TabIndex = 9;
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.Location = new System.Drawing.Point(558, 243);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(66, 17);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            // 
            // lblUltimaActualizacion
            // 
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(399, 243);
            this.lblUltimaActualizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(123, 17);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.txtAseguradora);
            this.panel1.Controls.Add(this.lblAseguradora);
            this.panel1.Controls.Add(this.txtNumeroPoliza);
            this.panel1.Controls.Add(this.lblNumeroPoliza);
            this.panel1.Controls.Add(this.txtNumeroPermisoSCT);
            this.panel1.Controls.Add(this.lblNumeroPermisoSCT);
            this.panel1.Controls.Add(this.txtPermisoSCT);
            this.panel1.Controls.Add(this.lblPermisoSCT);
            this.panel1.Controls.Add(this.txtNumeroPlacas);
            this.panel1.Controls.Add(this.lblNumeroPlacas);
            this.panel1.Controls.Add(this.txtConfiguracionVehicular);
            this.panel1.Controls.Add(this.lblConfiguracionVehicular);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 270);
            this.panel1.TabIndex = 53;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(133, 185);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPeso.MenuManager = this.mainRibbonControl;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Mask.EditMask = "n";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeso.Properties.MaxLength = 100;
            this.txtPeso.Size = new System.Drawing.Size(176, 24);
            this.txtPeso.TabIndex = 66;
            // 
            // lblPeso
            // 
            this.lblPeso.Location = new System.Drawing.Point(14, 189);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(55, 17);
            this.lblPeso.TabIndex = 67;
            this.lblPeso.Text = "Peso (Kg)";
            // 
            // txtAseguradora
            // 
            this.txtAseguradora.Location = new System.Drawing.Point(399, 153);
            this.txtAseguradora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAseguradora.MenuManager = this.mainRibbonControl;
            this.txtAseguradora.Name = "txtAseguradora";
            this.txtAseguradora.Properties.MaxLength = 100;
            this.txtAseguradora.Size = new System.Drawing.Size(226, 24);
            this.txtAseguradora.TabIndex = 8;
            // 
            // lblAseguradora
            // 
            this.lblAseguradora.Location = new System.Drawing.Point(316, 157);
            this.lblAseguradora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAseguradora.Name = "lblAseguradora";
            this.lblAseguradora.Size = new System.Drawing.Size(77, 17);
            this.lblAseguradora.TabIndex = 65;
            this.lblAseguradora.Text = "Aseguradora";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(133, 153);
            this.txtNumeroPoliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroPoliza.MenuManager = this.mainRibbonControl;
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Properties.MaxLength = 100;
            this.txtNumeroPoliza.Size = new System.Drawing.Size(176, 24);
            this.txtNumeroPoliza.TabIndex = 7;
            // 
            // lblNumeroPoliza
            // 
            this.lblNumeroPoliza.Location = new System.Drawing.Point(14, 157);
            this.lblNumeroPoliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroPoliza.Name = "lblNumeroPoliza";
            this.lblNumeroPoliza.Size = new System.Drawing.Size(54, 17);
            this.lblNumeroPoliza.TabIndex = 63;
            this.lblNumeroPoliza.Text = "No Póliza";
            // 
            // txtNumeroPermisoSCT
            // 
            this.txtNumeroPermisoSCT.Location = new System.Drawing.Point(303, 119);
            this.txtNumeroPermisoSCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroPermisoSCT.MenuManager = this.mainRibbonControl;
            this.txtNumeroPermisoSCT.Name = "txtNumeroPermisoSCT";
            this.txtNumeroPermisoSCT.Properties.MaxLength = 100;
            this.txtNumeroPermisoSCT.Size = new System.Drawing.Size(320, 24);
            this.txtNumeroPermisoSCT.TabIndex = 6;
            // 
            // lblNumeroPermisoSCT
            // 
            this.lblNumeroPermisoSCT.Location = new System.Drawing.Point(233, 123);
            this.lblNumeroPermisoSCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroPermisoSCT.Name = "lblNumeroPermisoSCT";
            this.lblNumeroPermisoSCT.Size = new System.Drawing.Size(67, 17);
            this.lblNumeroPermisoSCT.TabIndex = 61;
            this.lblNumeroPermisoSCT.Text = "No permiso";
            // 
            // txtPermisoSCT
            // 
            this.txtPermisoSCT.Location = new System.Drawing.Point(133, 119);
            this.txtPermisoSCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPermisoSCT.MenuManager = this.mainRibbonControl;
            this.txtPermisoSCT.Name = "txtPermisoSCT";
            this.txtPermisoSCT.Properties.MaxLength = 100;
            this.txtPermisoSCT.Size = new System.Drawing.Size(86, 24);
            this.txtPermisoSCT.TabIndex = 5;
            // 
            // lblPermisoSCT
            // 
            this.lblPermisoSCT.Location = new System.Drawing.Point(14, 123);
            this.lblPermisoSCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPermisoSCT.Name = "lblPermisoSCT";
            this.lblPermisoSCT.Size = new System.Drawing.Size(70, 17);
            this.lblPermisoSCT.TabIndex = 59;
            this.lblPermisoSCT.Text = "Permiso SCT";
            // 
            // txtNumeroPlacas
            // 
            this.txtNumeroPlacas.Location = new System.Drawing.Point(474, 85);
            this.txtNumeroPlacas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroPlacas.MenuManager = this.mainRibbonControl;
            this.txtNumeroPlacas.Name = "txtNumeroPlacas";
            this.txtNumeroPlacas.Properties.MaxLength = 100;
            this.txtNumeroPlacas.Size = new System.Drawing.Size(151, 24);
            this.txtNumeroPlacas.TabIndex = 4;
            // 
            // lblNumeroPlacas
            // 
            this.lblNumeroPlacas.Location = new System.Drawing.Point(399, 89);
            this.lblNumeroPlacas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNumeroPlacas.Name = "lblNumeroPlacas";
            this.lblNumeroPlacas.Size = new System.Drawing.Size(72, 17);
            this.lblNumeroPlacas.TabIndex = 57;
            this.lblNumeroPlacas.Text = "Num. Placas";
            // 
            // txtConfiguracionVehicular
            // 
            this.txtConfiguracionVehicular.Location = new System.Drawing.Point(303, 85);
            this.txtConfiguracionVehicular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfiguracionVehicular.MenuManager = this.mainRibbonControl;
            this.txtConfiguracionVehicular.Name = "txtConfiguracionVehicular";
            this.txtConfiguracionVehicular.Properties.MaxLength = 100;
            this.txtConfiguracionVehicular.Size = new System.Drawing.Size(86, 24);
            this.txtConfiguracionVehicular.TabIndex = 3;
            // 
            // lblConfiguracionVehicular
            // 
            this.lblConfiguracionVehicular.Location = new System.Drawing.Point(233, 89);
            this.lblConfiguracionVehicular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblConfiguracionVehicular.Name = "lblConfiguracionVehicular";
            this.lblConfiguracionVehicular.Size = new System.Drawing.Size(72, 17);
            this.lblConfiguracionVehicular.TabIndex = 55;
            this.lblConfiguracionVehicular.Text = "Conf. Vehic.";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(133, 85);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.MenuManager = this.mainRibbonControl;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.MaxLength = 100;
            this.txtModelo.Size = new System.Drawing.Size(86, 24);
            this.txtModelo.TabIndex = 2;
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(14, 89);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(46, 17);
            this.lblModelo.TabIndex = 53;
            this.lblModelo.Text = "Modelo";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(666, 332);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(666, 332);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 411);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmVehiculos";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbActivo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAseguradora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPermisoSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPermisoSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPlacas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfiguracionVehicular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}