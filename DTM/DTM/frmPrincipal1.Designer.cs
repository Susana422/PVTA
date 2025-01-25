using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using SDK;

namespace DTM
{
    partial class frmPrincipal1
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
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelMenuPrincipal = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItemEstacion = new DevExpress.XtraBars.BarHeaderItem();
            this.bbiEventosControles = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseñadorInformes = new DevExpress.XtraBars.BarButtonItem();
            this.bbiConsultasPersonalizadas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSincronizacion = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEntradasAbiertas = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemAutorizaciones = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.bbiEtiquetas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransmitirRecibir = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDiseñadorEscritorios = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSucursales = new DevExpress.XtraBars.BarListItem();
            this.bbiParametrizacion = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHerramientas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.bwAutorizaciones = new System.ComponentModel.BackgroundWorker();
            this.timerAutorizaciones = new System.Windows.Forms.Timer(this.components);
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelMenuPrincipal.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelMenuPrincipal});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            this.dockManager1.ClosingPanel += new DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(this.dockManager1_ClosingPanel);
            // 
            // dockPanelMenuPrincipal
            // 
            this.dockPanelMenuPrincipal.Controls.Add(this.dockPanel1_Container);
            this.dockPanelMenuPrincipal.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelMenuPrincipal.FloatSize = new System.Drawing.Size(218, 200);
            this.dockPanelMenuPrincipal.ID = new System.Guid("40a367a0-a383-4b5c-ab0b-4a5cc56ae345");
            this.dockPanelMenuPrincipal.Location = new System.Drawing.Point(0, 90);
            this.dockPanelMenuPrincipal.Name = "dockPanelMenuPrincipal";
            this.dockPanelMenuPrincipal.Options.ShowCloseButton = false;
            this.dockPanelMenuPrincipal.OriginalSize = new System.Drawing.Size(327, 200);
            this.dockPanelMenuPrincipal.Size = new System.Drawing.Size(327, 686);
            this.dockPanelMenuPrincipal.Text = "Menú principal";
            this.dockPanelMenuPrincipal.Click += new System.EventHandler(this.dockPanelMenuPrincipal_Click);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.sidePanel2);
            this.dockPanel1_Container.Controls.Add(this.sidePanel1);
            this.dockPanel1_Container.Controls.Add(this.lblEmpresa);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(318, 656);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.sidePanel2.Appearance.Options.UseBackColor = true;
            this.sidePanel2.Controls.Add(this.label12);
            this.sidePanel2.Controls.Add(this.label11);
            this.sidePanel2.Controls.Add(this.label10);
            this.sidePanel2.Controls.Add(this.label9);
            this.sidePanel2.Controls.Add(this.pictureBox10);
            this.sidePanel2.Controls.Add(this.pictureBox9);
            this.sidePanel2.Controls.Add(this.pictureBox8);
            this.sidePanel2.Controls.Add(this.pictureBox7);
            this.sidePanel2.Controls.Add(this.pictureBox6);
            this.sidePanel2.Controls.Add(this.pictureBox5);
            this.sidePanel2.Controls.Add(this.pictureBox4);
            this.sidePanel2.Controls.Add(this.pictureBox3);
            this.sidePanel2.Controls.Add(this.label8);
            this.sidePanel2.Controls.Add(this.label7);
            this.sidePanel2.Controls.Add(this.label4);
            this.sidePanel2.Controls.Add(this.label5);
            this.sidePanel2.Controls.Add(this.label6);
            this.sidePanel2.Location = new System.Drawing.Point(8, 134);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(310, 206);
            this.sidePanel2.TabIndex = 6;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label12.Location = new System.Drawing.Point(226, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Zonas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label11.Location = new System.Drawing.Point(154, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Vendedores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label10.Location = new System.Drawing.Point(75, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Departamentos";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label9.Location = new System.Drawing.Point(3, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estaciones de Trabajo";
            // 
            // pictureBox10
            // 
            //this.pictureBox10.Image = global::componentResourceManager.Resources._4908359;
            this.pictureBox10.Location = new System.Drawing.Point(229, 104);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(59, 51);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            //this.pictureBox9.Image = global::componentResourceManager.Resources._1029023;
            this.pictureBox9.Location = new System.Drawing.Point(157, 104);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(59, 51);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            //this.pictureBox8.Image = global::componentResourceManager.Resources._18167390;
            this.pictureBox8.Location = new System.Drawing.Point(79, 104);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(59, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
           // this.pictureBox7.Image = global::componentResourceManager.Resources._15421949;
            this.pictureBox7.Location = new System.Drawing.Point(6, 104);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(59, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            //this.pictureBox6.Image = global::componentResourceManager.Resources._2043173;
            this.pictureBox6.Location = new System.Drawing.Point(235, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            //this.pictureBox5.Image = global::componentResourceManager.Resources._4581775;
            this.pictureBox5.Location = new System.Drawing.Point(157, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            //this.pictureBox4.Image = global::componentResourceManager.Resources._40726112;
            this.pictureBox4.Location = new System.Drawing.Point(78, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            //this.pictureBox3.Image = global::componentResourceManager.Resources._10109731;
            this.pictureBox3.Location = new System.Drawing.Point(6, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label8.Location = new System.Drawing.Point(242, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Usuarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label7.Location = new System.Drawing.Point(154, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Configuración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cierre del día";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label5.Location = new System.Drawing.Point(89, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gestion";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.pictureBox2);
            this.sidePanel1.Controls.Add(this.pictureBox1);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Location = new System.Drawing.Point(8, 29);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(162, 99);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // pictureBox2
            // 
            //this.pictureBox2.Image = global::componentResourceManager.Resources.png_transparent_avatar_user_computer_icons_software_developer_avatar_child_face_heroes_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(81, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = global::componentResourceManager.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cerrar Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label2.Location = new System.Drawing.Point(87, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bloquear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.Appearance.Options.UseFont = true;
            this.lblEmpresa.AutoEllipsis = true;
            this.lblEmpresa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmpresa.Location = new System.Drawing.Point(10, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(273, 23);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "CM internacional";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = "CERRAR SESIÓN";
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSalir,
            this.barHeaderItemEstacion,
            this.bbiEventosControles,
            this.bbiDiseñadorInformes,
            this.bbiConsultasPersonalizadas,
            this.bbiSincronizacion,
            this.bbiEntradasAbiertas,
            this.barEditItemAutorizaciones,
            this.bbiEtiquetas,
            this.bbiTransmitirRecibir,
            this.bbiDiseñadorEscritorios,
            this.bbiSucursales,
            this.bbiParametrizacion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 294;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHerramientas});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(1136, 90);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ApplicationButtonClick += new System.EventHandler(this.ribbonControl1_ApplicationButtonClick);
            // 
            // bbiSalir
            // 
            this.bbiSalir.Caption = "Salir";
            this.bbiSalir.Id = 5;
            this.bbiSalir.Name = "bbiSalir";
            // 
            // barHeaderItemEstacion
            // 
            this.barHeaderItemEstacion.Caption = "Estación";
            this.barHeaderItemEstacion.Description = "Estación de trabajo";
            this.barHeaderItemEstacion.Id = 8;
            this.barHeaderItemEstacion.Name = "barHeaderItemEstacion";
            // 
            // bbiEventosControles
            // 
            this.bbiEventosControles.Caption = "Eventos de controles";
            this.bbiEventosControles.Id = 9;
            this.bbiEventosControles.ImageOptions.ImageUri.Uri = "SendToBack";
            this.bbiEventosControles.Name = "bbiEventosControles";
            this.bbiEventosControles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEventosControles_ItemClick);
            // 
            // bbiDiseñadorInformes
            // 
            this.bbiDiseñadorInformes.Caption = "Diseñador de informes";
            this.bbiDiseñadorInformes.Id = 10;
            this.bbiDiseñadorInformes.ImageOptions.ImageUri.Uri = "Paste";
            this.bbiDiseñadorInformes.Name = "bbiDiseñadorInformes";
            this.bbiDiseñadorInformes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseñadorInformes_ItemClick);
            // 
            // bbiConsultasPersonalizadas
            // 
            this.bbiConsultasPersonalizadas.Caption = "Consultas personalizadas";
            this.bbiConsultasPersonalizadas.Id = 11;
            this.bbiConsultasPersonalizadas.ImageOptions.ImageUri.Uri = "CustomizeGrid";
            this.bbiConsultasPersonalizadas.Name = "bbiConsultasPersonalizadas";
            this.bbiConsultasPersonalizadas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConsultasPersonalizadas_ItemClick);
            // 
            // bbiSincronizacion
            // 
            this.bbiSincronizacion.Caption = "Sincronización";
            this.bbiSincronizacion.Id = 12;
            this.bbiSincronizacion.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiSincronizacion.Name = "bbiSincronizacion";
            this.bbiSincronizacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSincronizacion_ItemClick);
            // 
            // bbiEntradasAbiertas
            // 
            this.bbiEntradasAbiertas.Caption = "Facturar entregas";
            this.bbiEntradasAbiertas.Id = 13;
            this.bbiEntradasAbiertas.ImageOptions.ImageUri.Uri = "Replace";
            this.bbiEntradasAbiertas.Name = "bbiEntradasAbiertas";
            this.bbiEntradasAbiertas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntradasAbiertas_ItemClick);
            // 
            // barEditItemAutorizaciones
            // 
            this.barEditItemAutorizaciones.Caption = "Suscribir autorizaciones";
            this.barEditItemAutorizaciones.Edit = this.repositoryItemToggleSwitch1;
            this.barEditItemAutorizaciones.EditHeight = 24;
            this.barEditItemAutorizaciones.EditWidth = 70;
            this.barEditItemAutorizaciones.Id = 14;
            this.barEditItemAutorizaciones.Name = "barEditItemAutorizaciones";
            this.barEditItemAutorizaciones.EditValueChanged += new System.EventHandler(this.barEditItemAutorizaciones_EditValueChanged);
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "No";
            this.repositoryItemToggleSwitch1.OnText = "Si";
            // 
            // bbiEtiquetas
            // 
            this.bbiEtiquetas.Caption = "Etiquetas";
            this.bbiEtiquetas.Id = 1;
            this.bbiEtiquetas.ImageOptions.ImageUri.Uri = "WrapText";
            this.bbiEtiquetas.Name = "bbiEtiquetas";
            this.bbiEtiquetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEtiquetas_ItemClick);
            // 
            // bbiTransmitirRecibir
            // 
            this.bbiTransmitirRecibir.Caption = "Transmitir / Recibir";
            this.bbiTransmitirRecibir.Id = 3;
            this.bbiTransmitirRecibir.ImageOptions.ImageUri.Uri = "Recurrence";
            this.bbiTransmitirRecibir.Name = "bbiTransmitirRecibir";
            this.bbiTransmitirRecibir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTransmitirRecibir_ItemClick);
            // 
            // bbiDiseñadorEscritorios
            // 
            this.bbiDiseñadorEscritorios.Caption = "Diseñador de escritorios";
            this.bbiDiseñadorEscritorios.Id = 4;
            this.bbiDiseñadorEscritorios.ImageOptions.ImageUri.Uri = "Chart";
            this.bbiDiseñadorEscritorios.Name = "bbiDiseñadorEscritorios";
            this.bbiDiseñadorEscritorios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDiseñadorEscritorios_ItemClick);
            // 
            // bbiSucursales
            // 
            this.bbiSucursales.Caption = "Sucursales";
            this.bbiSucursales.Id = 6;
            this.bbiSucursales.Name = "bbiSucursales";
            this.bbiSucursales.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.bbiSucursales_ListItemClick);
            // 
            // bbiParametrizacion
            // 
            this.bbiParametrizacion.Caption = "Parametrizaciones del Formulario";
            this.bbiParametrizacion.Id = 7;
           // this.bbiParametrizacion.ImageOptions.Image = global::componentResourceManager.Resources.editar;
            this.bbiParametrizacion.Name = "bbiParametrizacion";
            // 
            // ribbonPageHerramientas
            // 
            this.ribbonPageHerramientas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHerramientas});
            this.ribbonPageHerramientas.Name = "ribbonPageHerramientas";
            this.ribbonPageHerramientas.Text = "HERRAMIENTAS";
            // 
            // ribbonPageGroupHerramientas
            // 
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiConsultasPersonalizadas);
            this.ribbonPageGroupHerramientas.ItemLinks.Add(this.bbiDiseñadorInformes);
            this.ribbonPageGroupHerramientas.Name = "ribbonPageGroupHerramientas";
            this.ribbonPageGroupHerramientas.Text = "Herramientas";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barHeaderItemEstacion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 776);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1136, 29);
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Inventario";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Artículos";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Almacenes";
            // 
            // timerAutorizaciones
            // 
            this.timerAutorizaciones.Enabled = true;
            this.timerAutorizaciones.Interval = 5000;
            this.timerAutorizaciones.Tick += new System.EventHandler(this.timerAutorizaciones_Tick);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element1";
            // 
            // frmPrincipal1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 805);
            this.Controls.Add(this.dockPanelMenuPrincipal);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            //this.IconOptions.Image = global::componentResourceManager.Resources.iconosol;
            this.KeyPreview = true;
            this.Name = "frmPrincipal1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "CM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelMenuPrincipal.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private BarButtonItem bbiParametrizacion;
        private SidePanel sidePanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private SidePanel sidePanel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}