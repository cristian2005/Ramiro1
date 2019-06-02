using Bunifu.Framework.UI;
using System.Drawing;
using System.Windows.Forms;

namespace Ramiro
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.menuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblmodulo = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelmodulos = new System.Windows.Forms.FlowLayoutPanel();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.pbmove = new System.Windows.Forms.PictureBox();
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmove)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.menuTop.Controls.Add(this.Restaurar);
            this.menuTop.Controls.Add(this.Minimizar);
            this.menuTop.Controls.Add(this.Maximizar);
            this.menuTop.Controls.Add(this.Salir);
            this.menuTop.Controls.Add(this.lblnombre);
            this.menuTop.Controls.Add(this.lblmodulo);
            this.menuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebar.SetDecoration(this.menuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.menuTop, BunifuAnimatorNS.DecorationType.None);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Margin = new System.Windows.Forms.Padding(2);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(971, 65);
            this.menuTop.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(898, 24);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 9;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(862, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 8;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(898, 24);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 7;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(934, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 6;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // lblnombre
            // 
            this.AnimacionSidebarBack.SetDecoration(this.lblnombre, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblnombre, BunifuAnimatorNS.DecorationType.None);
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(73, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(186, 45);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Ramiro Ramirez Ramirez-";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmodulo
            // 
            this.lblmodulo.AutoSize = true;
            this.AnimacionSidebarBack.SetDecoration(this.lblmodulo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.lblmodulo, BunifuAnimatorNS.DecorationType.None);
            this.lblmodulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodulo.ForeColor = System.Drawing.Color.White;
            this.lblmodulo.Location = new System.Drawing.Point(265, 20);
            this.lblmodulo.Name = "lblmodulo";
            this.lblmodulo.Size = new System.Drawing.Size(118, 20);
            this.lblmodulo.TabIndex = 3;
            this.lblmodulo.Text = "DASHBOARD";
            this.lblmodulo.Click += new System.EventHandler(this.lblmodulo_Click);
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 2;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.menuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation5;
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 65);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 558);
            this.SidebarWrapper.TabIndex = 2;
            // 
            // Sidebar
            // 
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.panelmodulos);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(292, 558);
            this.Sidebar.TabIndex = 0;
            // 
            // panelmodulos
            // 
            this.panelmodulos.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.panelmodulos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.panelmodulos, BunifuAnimatorNS.DecorationType.None);
            this.panelmodulos.Location = new System.Drawing.Point(11, 89);
            this.panelmodulos.Margin = new System.Windows.Forms.Padding(2);
            this.panelmodulos.Name = "panelmodulos";
            this.panelmodulos.Size = new System.Drawing.Size(277, 460);
            this.panelmodulos.TabIndex = 0;
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPOPSA-INFOTEP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.Wrapper.Location = new System.Drawing.Point(298, 65);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(673, 558);
            this.Wrapper.TabIndex = 2;
            // 
            // pbmove
            // 
            this.AnimacionSidebarBack.SetDecoration(this.pbmove, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pbmove, BunifuAnimatorNS.DecorationType.None);
            this.pbmove.Location = new System.Drawing.Point(0, 0);
            this.pbmove.Name = "pbmove";
            this.pbmove.Size = new System.Drawing.Size(100, 50);
            this.pbmove.TabIndex = 0;
            this.pbmove.TabStop = false;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation6;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(971, 623);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.menuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmove)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        #region Generar Modulos

        /// <summary>
        /// Inicializa los modulos y lo agrega al panel de modulo
        /// </summary>
        /// <param name="boton"></param>
        /// <param name="nombre_modulo"></param>
        public void InicializarModulos(BunifuFlatButton boton, string nombre_modulo)
        {
            boton.Activecolor = System.Drawing.Color.Transparent;
            boton.BackColor = System.Drawing.Color.Transparent;
            boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            boton.BorderRadius = 0;
            boton.ButtonText = nombre_modulo;
            boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarBack.SetDecoration(boton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(boton, BunifuAnimatorNS.DecorationType.None);
            boton.DisabledColor = System.Drawing.Color.Gray;
            boton.Iconcolor = System.Drawing.Color.Transparent;
            boton.Iconimage = Get_Icono_Modulo(nombre_modulo);
            boton.Iconimage_right = null;
            boton.Iconimage_right_Selected = null;
            boton.Iconimage_Selected = null;
            boton.IconMarginLeft = 0;
            boton.IconMarginRight = 0;
            boton.IconRightVisible = true;
            boton.IconRightZoom = 0D;
            boton.IconVisible = true;
            boton.IconZoom = 50D;
            boton.IsTab = false;
            boton.Margin = new System.Windows.Forms.Padding(5);
            boton.Name = nombre_modulo;
            boton.Normalcolor = System.Drawing.Color.Transparent;
            boton.OnHovercolor = System.Drawing.Color.Transparent;
            boton.OnHoverTextColor = System.Drawing.Color.White;
            boton.selected = false;
            boton.Size = new System.Drawing.Size(237, 50);
            boton.TabIndex = 15;
            boton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            boton.Text = nombre_modulo;
            boton.TextAlign = ContentAlignment.MiddleCenter;
            boton.Textcolor = System.Drawing.Color.LightGray;
            boton.Click += new System.EventHandler(btn_modulos_click);

            pbmove = new PictureBox();
            this.pbmove.BackColor = (nombre_modulo == "DASHBOARD") ? Color.White : Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.pbmove, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.pbmove, BunifuAnimatorNS.DecorationType.None);
            this.pbmove.Name = "pb" + nombre_modulo;
            this.pbmove.Size = new System.Drawing.Size(10, 50);
            this.pbmove.TabStop = false;

            panelmodulos.Controls.Add(pbmove);
            pbmove.Location = new Point(boton.Location.X, boton.Location.Y);
            this.panelmodulos.Controls.Add(boton);


        }
        #endregion

        private System.Windows.Forms.Panel menuTop;
        private System.Windows.Forms.Label lblmodulo;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.PictureBox Salir;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.FlowLayoutPanel panelmodulos;
        private System.Windows.Forms.PictureBox pbmove;
    }
}

