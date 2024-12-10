using System;
using System.Collections.Generic;
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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using NoriSDK;


namespace NORI
{
    partial class frmEventosControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventosControles));
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGuardarNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
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
            this.lblControl = new DevExpress.XtraEditors.LabelControl();
            this.lblFormulario = new DevExpress.XtraEditors.LabelControl();
            this.cbActivo = new DevExpress.XtraEditors.CheckEdit();
            this.lblFechaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.lblUltimaActualizacion = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtControlDestino = new DevExpress.XtraEditors.TextEdit();
            this.txtControl = new DevExpress.XtraEditors.TextEdit();
            this.txtFormulario = new DevExpress.XtraEditors.TextEdit();
            this.cbControlDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.lblControlDestino = new DevExpress.XtraEditors.LabelControl();
            this.cbControles = new DevExpress.XtraEditors.LookUpEdit();
            this.cbFormularios = new DevExpress.XtraEditors.LookUpEdit();
            this.txtQuery = new DevExpress.XtraEditors.MemoEdit();
            this.lblQuery = new DevExpress.XtraEditors.LabelControl();
            this.cbEventos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEvento = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)this.mainRibbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbActivo.Properties).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtControlDestino.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtControl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtFormulario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbControlDestino.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbControles.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbFormularios.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtQuery.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cbEventos.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
            base.SuspendLayout();
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[13]
            {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiGuardarCerrar,
            this.bbiGuardarNuevo,
            this.bbiEliminar,
            this.bbiRefresh,
            this.bbiBuscar,
            this.bbiPrimero,
            this.bbiAnterior,
            this.bbiUltimo,
            this.bbiSiguiente,
            this.bbiNuevo,
            this.mainRibbonControl.SearchEditItem
            });
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 2;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[1] { this.mainRibbonPage });
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(573, 89);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 2;
            this.bbiGuardar.ImageOptions.ImageUri.Uri = "Save";
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardar_ItemClick);
            this.bbiGuardarCerrar.Caption = "Guardar y cerrar";
            this.bbiGuardarCerrar.Id = 3;
            this.bbiGuardarCerrar.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiGuardarCerrar.Name = "bbiGuardarCerrar";
            this.bbiGuardarCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardarCerrar_ItemClick);
            this.bbiGuardarNuevo.Caption = "Guardar y nuevo";
            this.bbiGuardarNuevo.Id = 4;
            this.bbiGuardarNuevo.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiGuardarNuevo.Name = "bbiGuardarNuevo";
            this.bbiGuardarNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiGuardarNuevo_ItemClick);
            this.bbiEliminar.Caption = "Eliminar";
            this.bbiEliminar.Id = 6;
            this.bbiEliminar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiEliminar.Name = "bbiEliminar";
            this.bbiRefresh.Caption = "Actualizar";
            this.bbiRefresh.Id = 1;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiRefresh_ItemClick);
            this.bbiBuscar.Caption = "Buscar";
            this.bbiBuscar.Id = 4;
            this.bbiBuscar.ImageOptions.ImageUri.Uri = "Find";
            this.bbiBuscar.Name = "bbiBuscar";
            this.bbiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiBuscar_ItemClick);
            this.bbiPrimero.Caption = "Primero";
            this.bbiPrimero.Id = 5;
            this.bbiPrimero.ImageOptions.ImageUri.Uri = "First";
            this.bbiPrimero.Name = "bbiPrimero";
            this.bbiPrimero.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiPrimero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiPrimero_ItemClick);
            this.bbiAnterior.Caption = "Anterior";
            this.bbiAnterior.Id = 6;
            this.bbiAnterior.ImageOptions.ImageUri.Uri = "Prev";
            this.bbiAnterior.Name = "bbiAnterior";
            this.bbiAnterior.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiAnterior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiAnterior_ItemClick);
            this.bbiUltimo.Caption = "Último";
            this.bbiUltimo.Id = 7;
            this.bbiUltimo.ImageOptions.ImageUri.Uri = "Last";
            this.bbiUltimo.Name = "bbiUltimo";
            this.bbiUltimo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiUltimo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiUltimo_ItemClick);
            this.bbiSiguiente.Caption = "Siguiente";
            this.bbiSiguiente.Id = 8;
            this.bbiSiguiente.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.bbiSiguiente.ImageOptions.ImageUri.Uri = "Next";
            this.bbiSiguiente.Name = "bbiSiguiente";
            this.bbiSiguiente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bbiSiguiente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiSiguiente_ItemClick);
            this.bbiNuevo.Caption = "Nuevo";
            this.bbiNuevo.Id = 1;
            this.bbiNuevo.ImageOptions.ImageUri.Uri = "Add";
            this.bbiNuevo.Name = "bbiNuevo";
            this.bbiNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiNuevo_ItemClick);
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[2] { this.mainRibbonPageGroup, this.searchRibbonPageGroup });
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ARCHIVO";
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarCerrar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiGuardarNuevo);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Opciones";
            this.searchRibbonPageGroup.AllowTextClipping = false;
            this.searchRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiRefresh);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiBuscar);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiPrimero);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiAnterior);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiSiguiente);
            this.searchRibbonPageGroup.ItemLinks.Add(this.bbiUltimo);
            this.searchRibbonPageGroup.Name = "searchRibbonPageGroup";
            this.searchRibbonPageGroup.Text = "Navegación";
            this.lblID.Location = new System.Drawing.Point(479, 250);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(6, 13);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "0";
            this.lblControl.Location = new System.Drawing.Point(12, 42);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(68, 13);
            this.lblControl.TabIndex = 46;
            this.lblControl.Text = "Control origen";
            this.lblFormulario.Location = new System.Drawing.Point(12, 16);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(50, 13);
            this.lblFormulario.TabIndex = 44;
            this.lblFormulario.Text = "Formulario";
            this.cbActivo.Location = new System.Drawing.Point(12, 269);
            this.cbActivo.MenuManager = this.mainRibbonControl;
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Properties.Caption = "Activo";
            this.cbActivo.Size = new System.Drawing.Size(120, 20);
            this.cbActivo.TabIndex = 5;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(479, 272);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(56, 13);
            this.lblFechaActualizacion.TabIndex = 51;
            this.lblFechaActualizacion.Text = "01/01/0001";
            this.lblUltimaActualizacion.Location = new System.Drawing.Point(342, 272);
            this.lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            this.lblUltimaActualizacion.Size = new System.Drawing.Size(94, 13);
            this.lblUltimaActualizacion.TabIndex = 50;
            this.lblUltimaActualizacion.Text = "Última Actualización";
            this.panel1.Controls.Add(this.txtControlDestino);
            this.panel1.Controls.Add(this.txtControl);
            this.panel1.Controls.Add(this.txtFormulario);
            this.panel1.Controls.Add(this.cbControlDestino);
            this.panel1.Controls.Add(this.lblControlDestino);
            this.panel1.Controls.Add(this.cbControles);
            this.panel1.Controls.Add(this.cbFormularios);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.lblQuery);
            this.panel1.Controls.Add(this.cbEventos);
            this.panel1.Controls.Add(this.lblEvento);
            this.panel1.Controls.Add(this.lblFechaActualizacion);
            this.panel1.Controls.Add(this.lblUltimaActualizacion);
            this.panel1.Controls.Add(this.lblFormulario);
            this.panel1.Controls.Add(this.cbActivo);
            this.panel1.Controls.Add(this.lblControl);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 301);
            this.panel1.TabIndex = 53;
            this.txtControlDestino.Location = new System.Drawing.Point(342, 65);
            this.txtControlDestino.MenuManager = this.mainRibbonControl;
            this.txtControlDestino.Name = "txtControlDestino";
            this.txtControlDestino.Properties.MaxLength = 20;
            this.txtControlDestino.Size = new System.Drawing.Size(193, 20);
            this.txtControlDestino.TabIndex = 2;
            this.txtControl.Location = new System.Drawing.Point(342, 39);
            this.txtControl.MenuManager = this.mainRibbonControl;
            this.txtControl.Name = "txtControl";
            this.txtControl.Properties.MaxLength = 50;
            this.txtControl.Size = new System.Drawing.Size(193, 20);
            this.txtControl.TabIndex = 1;
            this.txtFormulario.Location = new System.Drawing.Point(342, 13);
            this.txtFormulario.MenuManager = this.mainRibbonControl;
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Properties.MaxLength = 50;
            this.txtFormulario.Size = new System.Drawing.Size(193, 20);
            this.txtFormulario.TabIndex = 0;
            this.cbControlDestino.Location = new System.Drawing.Point(114, 65);
            this.cbControlDestino.MenuManager = this.mainRibbonControl;
            this.cbControlDestino.Name = "cbControlDestino";
            this.cbControlDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbControlDestino.Size = new System.Drawing.Size(219, 20);
            this.cbControlDestino.TabIndex = 3;
            this.cbControlDestino.TabStop = false;
            this.cbControlDestino.TextChanged += new System.EventHandler(cbControlDestino_TextChanged);
            this.lblControlDestino.Location = new System.Drawing.Point(12, 68);
            this.lblControlDestino.Name = "lblControlDestino";
            this.lblControlDestino.Size = new System.Drawing.Size(73, 13);
            this.lblControlDestino.TabIndex = 60;
            this.lblControlDestino.Text = "Control destino";
            this.cbControles.Location = new System.Drawing.Point(114, 39);
            this.cbControles.MenuManager = this.mainRibbonControl;
            this.cbControles.Name = "cbControles";
            this.cbControles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbControles.Size = new System.Drawing.Size(219, 20);
            this.cbControles.TabIndex = 1;
            this.cbControles.TabStop = false;
            this.cbControles.TextChanged += new System.EventHandler(cbControles_TextChanged);
            this.cbFormularios.Location = new System.Drawing.Point(114, 13);
            this.cbFormularios.MenuManager = this.mainRibbonControl;
            this.cbFormularios.Name = "cbFormularios";
            this.cbFormularios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbFormularios.Size = new System.Drawing.Size(219, 20);
            this.cbFormularios.TabIndex = 0;
            this.cbFormularios.TabStop = false;
            this.cbFormularios.TextChanged += new System.EventHandler(cbFormularios_TextChanged);
            this.txtQuery.Location = new System.Drawing.Point(114, 118);
            this.txtQuery.MenuManager = this.mainRibbonControl;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(421, 126);
            this.txtQuery.TabIndex = 4;
            this.lblQuery.Location = new System.Drawing.Point(12, 118);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(42, 13);
            this.lblQuery.TabIndex = 56;
            this.lblQuery.Text = "Consulta";
            this.cbEventos.Location = new System.Drawing.Point(114, 91);
            this.cbEventos.MenuManager = this.mainRibbonControl;
            this.cbEventos.Name = "cbEventos";
            this.cbEventos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
            {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            });
            this.cbEventos.Properties.Items.AddRange(new object[7] { "Click", "DoubleClick", "TextChanged", "Enter", "GetFocus", "LostFocus", "EditValueChanged" });
            this.cbEventos.Size = new System.Drawing.Size(219, 20);
            this.cbEventos.TabIndex = 3;
            this.lblEvento.Location = new System.Drawing.Point(12, 94);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(34, 13);
            this.lblEvento.TabIndex = 53;
            this.lblEvento.Text = "Evento";
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 89);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(92, 301, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(573, 311);
            this.layoutControl1.TabIndex = 57;
            this.layoutControl1.Text = "layoutControl1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(573, 311);
            this.layoutControlGroup1.TextVisible = false;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(573, 400);
            base.Controls.Add(this.layoutControl1);
            base.Controls.Add(this.mainRibbonControl);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("frmEventosControles.IconOptions.Icon");
            base.MaximizeBox = false;
            base.Name = "frmEventosControles";
            this.Ribbon = this.mainRibbonControl;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos de controles";
            base.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)this.mainRibbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbActivo.Properties).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtControlDestino.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtControl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtFormulario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbControlDestino.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbControles.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbFormularios.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.txtQuery.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cbEventos.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}