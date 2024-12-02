﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using NoriSDK;


namespace NORI
{
    partial class frmEtiquetas
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiquetas));
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cbUsuarios = new DevExpress.XtraEditors.LookUpEdit();
            this.lblUsuario = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArticulo = new DevExpress.XtraEditors.TextEdit();
            this.gcPartidas = new DevExpress.XtraGrid.GridControl();
            this.gvPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnArticuloID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUnidadesMedida = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbGenero = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.cbImpreso = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipos = new DevExpress.XtraEditors.LookUpEdit();
            this.lblTipo = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.cbAlmacenes = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAlmacenes = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.lblOpciones = new DevExpress.XtraEditors.LabelControl();
            this.rgOpciones = new DevExpress.XtraEditors.RadioGroup();
            this.lblHasta = new DevExpress.XtraEditors.LabelControl();
            this.lblDesde = new DevExpress.XtraEditors.LabelControl();
            this.btnImportar = new DevExpress.XtraEditors.SimpleButton();
            this.deHasta = new DevExpress.XtraEditors.DateEdit();
            this.deDesde = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)this.mainRibbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.xtraTabControl1).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.cbUsuarios.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtArticulo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gcPartidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gvPartidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbUnidadesMedida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbGenero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbImpreso.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbTipos.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbAlmacenes.Properties).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.rgOpciones.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
            base.SuspendLayout();
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[12]
            {
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
            this.bbiNuevo
            });
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[1] { this.mainRibbonPage });
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(584, 79);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardar_ItemClick);
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            this.bbiGuardarCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardarCerrar_ItemClick);
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            this.bbiGuardarNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardarNuevo_ItemClick);
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiRestablecer.Id = 1;
            this.bbiRestablecer.Name = "bbiRestablecer";
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiBuscar_ItemClick);
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiPrimero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiPrimero_ItemClick);
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiAnterior_ItemClick);
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiUltimo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiUltimo_ItemClick);
            this.bbiSiguiente.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiSiguiente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiSiguiente_ItemClick);
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiNuevo_ItemClick);
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.mainRibbonPageGroup, this.searchRibbonPageGroup });
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarNuevo);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Opciones";
            this.searchRibbonPageGroup.AllowTextClipping = false;
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiBuscar);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiPrimero);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiAnterior);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiSiguiente);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiUltimo);
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.ShowCaptionButton = false;
            this.searchRibbonPageGroup.Text = "Navegación";
            this.layoutControl1.Controls.Add(this.xtraTabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 79);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 425);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(560, 401);
            this.xtraTabControl1.TabIndex = 5;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[2] { this.xtraTabPage1, this.xtraTabPage2 });
            this.xtraTabPage1.Controls.Add(this.lblID);
            this.xtraTabPage1.Controls.Add(this.btnImprimir);
            this.xtraTabPage1.Controls.Add(this.cbUsuarios);
            this.xtraTabPage1.Controls.Add(this.lblUsuario);
            this.xtraTabPage1.Controls.Add(this.pictureBox1);
            this.xtraTabPage1.Controls.Add(this.txtArticulo);
            this.xtraTabPage1.Controls.Add(this.gcPartidas);
            this.xtraTabPage1.Controls.Add(this.lblFechaActualizacion);
            this.xtraTabPage1.Controls.Add(this.lblUltimaActualizacion);
            this.xtraTabPage1.Controls.Add(this.cbImpreso);
            this.xtraTabPage1.Controls.Add(this.cbTipos);
            this.xtraTabPage1.Controls.Add(this.lblTipo);
            this.xtraTabPage1.Controls.Add(this.cbAlmacenes);
            this.xtraTabPage1.Controls.Add(this.lblAlmacenes);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(554, 373);
            this.xtraTabPage1.Text = "General";
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblID.Location = new System.Drawing.Point(350, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(6, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "0";
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.Image = (System.Drawing.Image)resources.GetObject("btnImprimir.Image");
            this.btnImprimir.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnImprimir.Location = new System.Drawing.Point(442, 57);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 23);
            this.btnImprimir.TabIndex = 132;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(btnImprimir_Click);
            this.cbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cbUsuarios.Location = new System.Drawing.Point(120, 60);
            this.cbUsuarios.MenuManager = this.mainRibbonControl;
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbUsuarios.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[3]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("usuario", "Usuario"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbUsuarios.Size = new System.Drawing.Size(224, 20);
            this.cbUsuarios.TabIndex = 123;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuario.Location = new System.Drawing.Point(13, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(36, 13);
            this.lblUsuario.TabIndex = 120;
            this.lblUsuario.Text = "Usuario";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            //this.pictureBox1.Image = Nori.Properties.Resources.barcode;
            this.pictureBox1.Location = new System.Drawing.Point(11, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            this.txtArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtArticulo.Location = new System.Drawing.Point(41, 86);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(502, 20);
            this.txtArticulo.TabIndex = 124;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(txtArticulo_KeyDown);
            this.gcPartidas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.gcPartidas.Location = new System.Drawing.Point(13, 113);
            this.gcPartidas.MainView = this.gvPartidas;
            this.gcPartidas.Name = "gcPartidas";
            this.gcPartidas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[2] { this.cbGenero, this.cbUnidadesMedida });
            this.gcPartidas.Size = new System.Drawing.Size(530, 226);
            this.gcPartidas.TabIndex = 130;
            this.gcPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gvPartidas });
            this.gvPartidas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[6] { this.gridColumnID, this.gridColumnArticuloID, this.gridColumnCantidad, this.gridColumnUnidadMedida, this.gridColumnSKU, this.gridColumnNombre });
            this.gvPartidas.GridControl = this.gcPartidas;
            this.gvPartidas.Name = "gvPartidas";
            this.gvPartidas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPartidas.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvPartidas.OptionsNavigation.AutoFocusNewRow = true;
            this.gvPartidas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvPartidas.OptionsView.ShowGroupPanel = false;
            this.gvPartidas.ShownEditor += new System.EventHandler(gvPartidas_ShownEditor);
            this.gvPartidas.KeyDown += new System.Windows.Forms.KeyEventHandler(gvPartidas_KeyDown);
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "id";
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnArticuloID.Caption = "gridColumnArticuloID";
            this.gridColumnArticuloID.FieldName = "articulo_id";
            this.gridColumnArticuloID.Name = "gridColumnArticuloID";
            this.gridColumnCantidad.Caption = "Cantidad";
            this.gridColumnCantidad.DisplayFormat.FormatString = "n0";
            this.gridColumnCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidad.FieldName = "cantidad";
            this.gridColumnCantidad.MaxWidth = 80;
            this.gridColumnCantidad.MinWidth = 80;
            this.gridColumnCantidad.Name = "gridColumnCantidad";
            this.gridColumnCantidad.Visible = true;
            this.gridColumnCantidad.VisibleIndex = 0;
            this.gridColumnCantidad.Width = 80;
            this.gridColumnUnidadMedida.Caption = "UdM";
            this.gridColumnUnidadMedida.ColumnEdit = this.cbUnidadesMedida;
            this.gridColumnUnidadMedida.FieldName = "unidad_medida_id";
            this.gridColumnUnidadMedida.Name = "gridColumnUnidadMedida";
            this.gridColumnUnidadMedida.Visible = true;
            this.gridColumnUnidadMedida.VisibleIndex = 1;
            this.cbUnidadesMedida.AutoHeight = false;
            this.cbUnidadesMedida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbUnidadesMedida.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[1]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbUnidadesMedida.Name = "cbUnidadesMedida";
            this.gridColumnSKU.Caption = "SKU";
            this.gridColumnSKU.FieldName = "sku";
            this.gridColumnSKU.MaxWidth = 120;
            this.gridColumnSKU.MinWidth = 120;
            this.gridColumnSKU.Name = "gridColumnSKU";
            this.gridColumnSKU.Visible = true;
            this.gridColumnSKU.VisibleIndex = 2;
            this.gridColumnSKU.Width = 120;
            this.gridColumnNombre.Caption = "Artículo";
            this.gridColumnNombre.FieldName = "nombre";
            this.gridColumnNombre.MinWidth = 260;
            this.gridColumnNombre.Name = "gridColumnNombre";
            this.gridColumnNombre.Visible = true;
            this.gridColumnNombre.VisibleIndex = 3;
            this.gridColumnNombre.Width = 260;
            this.cbGenero.AutoHeight = false;
            this.cbGenero.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbGenero.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("genero", "Genero"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbGenero.Name = "cbGenero";
            this.lblFechaActualizacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(487, 348);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(56, 13);
            this.lblFechaActualizacion.TabIndex = 129;
            this.lblFechaActualizacion.Text = "01/01/0001";
            this.lblUltimaActualizacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(350, 348);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(94, 13);
            this.lblUltimaActualizacion.TabIndex = 128;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            this.cbImpreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.cbImpreso.Location = new System.Drawing.Point(15, 345);
            this.cbImpreso.MenuManager = this.mainRibbonControl;
            this.cbImpreso.Name = "cbImpreso";
            this.cbImpreso.Properties.Caption = "Impreso";
            this.cbImpreso.Size = new System.Drawing.Size(76, 19);
            this.cbImpreso.TabIndex = 125;
            this.cbTipos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cbTipos.Location = new System.Drawing.Point(120, 34);
            this.cbTipos.MenuManager = this.mainRibbonControl;
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbTipos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[2]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbTipos.Size = new System.Drawing.Size(224, 20);
            this.cbTipos.TabIndex = 122;
            this.lblTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTipo.Location = new System.Drawing.Point(13, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(78, 13);
            this.lblTipo.TabIndex = 127;
            this.lblTipo.Text = "Tipo de etiqueta";
            this.lblTipo.Click += new System.EventHandler(lblTipo_Click);
            this.cbAlmacenes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cbAlmacenes.Location = new System.Drawing.Point(120, 8);
            this.cbAlmacenes.MenuManager = this.mainRibbonControl;
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbAlmacenes.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[3]
            {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre")
            });
            this.cbAlmacenes.Size = new System.Drawing.Size(224, 20);
            this.cbAlmacenes.TabIndex = 121;
            this.lblAlmacenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlmacenes.Location = new System.Drawing.Point(13, 9);
            this.lblAlmacenes.Name = "lblAlmacenes";
            this.lblAlmacenes.Size = new System.Drawing.Size(40, 13);
            this.lblAlmacenes.TabIndex = 126;
            this.lblAlmacenes.Text = "Almacén";
            this.lblAlmacenes.Click += new System.EventHandler(lblAlmacenes_Click);
            this.xtraTabPage2.Controls.Add(this.lblOpciones);
            this.xtraTabPage2.Controls.Add(this.rgOpciones);
            this.xtraTabPage2.Controls.Add(this.lblHasta);
            this.xtraTabPage2.Controls.Add(this.lblDesde);
            this.xtraTabPage2.Controls.Add(this.btnImportar);
            this.xtraTabPage2.Controls.Add(this.deHasta);
            this.xtraTabPage2.Controls.Add(this.deDesde);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(554, 373);
            this.xtraTabPage2.Text = "Importar";
            this.lblOpciones.Location = new System.Drawing.Point(15, 15);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(44, 13);
            this.lblOpciones.TabIndex = 140;
            this.lblOpciones.Text = "Opciones";
            this.rgOpciones.Location = new System.Drawing.Point(122, 15);
            this.rgOpciones.MenuManager = this.mainRibbonControl;
            this.rgOpciones.Name = "rgOpciones";
            this.rgOpciones.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[2]
            {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Artículos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Precios")
            });
            this.rgOpciones.Size = new System.Drawing.Size(125, 56);
            this.rgOpciones.TabIndex = 139;
            this.lblHasta.Location = new System.Drawing.Point(15, 106);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(28, 13);
            this.lblHasta.TabIndex = 134;
            this.lblHasta.Text = "Hasta";
            this.lblDesde.Location = new System.Drawing.Point(15, 80);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(30, 13);
            this.lblDesde.TabIndex = 135;
            this.lblDesde.Text = "Desde";
            this.btnImportar.Image = (System.Drawing.Image)resources.GetObject("btnImportar.Image");
            this.btnImportar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnImportar.Location = new System.Drawing.Point(122, 129);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(125, 23);
            this.btnImportar.TabIndex = 136;
            this.btnImportar.TabStop = false;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(btnImportar_Click);
            this.deHasta.EditValue = null;
            this.deHasta.Location = new System.Drawing.Point(122, 103);
            this.deHasta.MenuManager = this.mainRibbonControl;
            this.deHasta.Name = "deHasta";
            this.deHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deHasta.Properties.Mask.EditMask = "g";
            this.deHasta.Size = new System.Drawing.Size(125, 20);
            this.deHasta.TabIndex = 137;
            this.deHasta.TabStop = false;
            this.deDesde.EditValue = null;
            this.deDesde.Location = new System.Drawing.Point(122, 77);
            this.deDesde.MenuManager = this.mainRibbonControl;
            this.deDesde.Name = "deDesde";
            this.deDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.deDesde.Properties.Mask.EditMask = "g";
            this.deDesde.Size = new System.Drawing.Size(125, 20);
            this.deDesde.TabIndex = 138;
            this.deDesde.TabStop = false;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem2 });
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 425);
            this.layoutControlGroup1.TextVisible = false;
            this.layoutControlItem2.Control = this.xtraTabControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(564, 405);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(584, 504);
            base.Controls.Add(this.layoutControl1);
            base.Controls.Add(this.mainRibbonControl);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "frmEtiquetas";
            this.Ribbon = this.mainRibbonControl;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas";
            ((System.ComponentModel.ISupportInitialize)this.mainRibbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.xtraTabControl1).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.cbUsuarios.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtArticulo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gcPartidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gvPartidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbUnidadesMedida).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbGenero).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbImpreso.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbTipos.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbAlmacenes.Properties).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.rgOpciones.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deHasta.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.deDesde.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}