
namespace DashBOARD_venta_de_casas
{
    partial class DashBoardAdmi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.btUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btCasas = new Guna.UI2.WinForms.Guna2Button();
            this.imagenSlide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 570);
            this.panel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 18;
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btSalir);
            this.guna2CustomGradientPanel1.Controls.Add(this.btEstadisticas);
            this.guna2CustomGradientPanel1.Controls.Add(this.btUsuarios);
            this.guna2CustomGradientPanel1.Controls.Add(this.btCasas);
            this.guna2CustomGradientPanel1.Controls.Add(this.imagenSlide);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(96, 551);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(108, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(788, 570);
            this.panelContenedor.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DashBOARD_venta_de_casas.Properties.Resources.departamento;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 92);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Transparent;
            this.btSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btSalir.BorderRadius = 24;
            this.btSalir.BorderThickness = 1;
            this.btSalir.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btSalir.Checked = true;
            this.btSalir.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btSalir.CheckedState.FillColor = System.Drawing.Color.White;
            this.btSalir.CheckedState.Image = global::DashBOARD_venta_de_casas.Properties.Resources.exitN;
            this.btSalir.CheckedState.Parent = this.btSalir;
            this.btSalir.CustomImages.Parent = this.btSalir;
            this.btSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.HoverState.Parent = this.btSalir;
            this.btSalir.Image = global::DashBOARD_venta_de_casas.Properties.Resources.salir1;
            this.btSalir.Location = new System.Drawing.Point(20, 484);
            this.btSalir.Name = "btSalir";
            this.btSalir.ShadowDecoration.Parent = this.btSalir;
            this.btSalir.Size = new System.Drawing.Size(59, 49);
            this.btSalir.TabIndex = 4;
            this.btSalir.UseTransparentBackground = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEstadisticas
            // 
            this.btEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btEstadisticas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btEstadisticas.BorderRadius = 24;
            this.btEstadisticas.BorderThickness = 1;
            this.btEstadisticas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btEstadisticas.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btEstadisticas.CheckedState.FillColor = System.Drawing.Color.White;
            this.btEstadisticas.CheckedState.Image = global::DashBOARD_venta_de_casas.Properties.Resources.graficosN;
            this.btEstadisticas.CheckedState.Parent = this.btEstadisticas;
            this.btEstadisticas.CustomImages.Parent = this.btEstadisticas;
            this.btEstadisticas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btEstadisticas.HoverState.Parent = this.btEstadisticas;
            this.btEstadisticas.Image = global::DashBOARD_venta_de_casas.Properties.Resources.graficos;
            this.btEstadisticas.Location = new System.Drawing.Point(37, 301);
            this.btEstadisticas.Name = "btEstadisticas";
            this.btEstadisticas.ShadowDecoration.Parent = this.btEstadisticas;
            this.btEstadisticas.Size = new System.Drawing.Size(59, 52);
            this.btEstadisticas.TabIndex = 2;
            this.btEstadisticas.UseTransparentBackground = true;
            this.btEstadisticas.CheckedChanged += new System.EventHandler(this.btCasas_CheckedChanged);
            this.btEstadisticas.Click += new System.EventHandler(this.btEstadisticas_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btUsuarios.BorderRadius = 24;
            this.btUsuarios.BorderThickness = 1;
            this.btUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btUsuarios.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btUsuarios.CheckedState.FillColor = System.Drawing.Color.White;
            this.btUsuarios.CheckedState.Image = global::DashBOARD_venta_de_casas.Properties.Resources.userNG;
            this.btUsuarios.CheckedState.Parent = this.btUsuarios;
            this.btUsuarios.CustomImages.Parent = this.btUsuarios;
            this.btUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btUsuarios.ForeColor = System.Drawing.Color.White;
            this.btUsuarios.HoverState.Parent = this.btUsuarios;
            this.btUsuarios.Image = global::DashBOARD_venta_de_casas.Properties.Resources.users;
            this.btUsuarios.Location = new System.Drawing.Point(37, 222);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.ShadowDecoration.Parent = this.btUsuarios;
            this.btUsuarios.Size = new System.Drawing.Size(59, 52);
            this.btUsuarios.TabIndex = 1;
            this.btUsuarios.UseTransparentBackground = true;
            this.btUsuarios.CheckedChanged += new System.EventHandler(this.btCasas_CheckedChanged);
            // 
            // btCasas
            // 
            this.btCasas.BackColor = System.Drawing.Color.Transparent;
            this.btCasas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btCasas.BorderRadius = 24;
            this.btCasas.BorderThickness = 1;
            this.btCasas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCasas.Checked = true;
            this.btCasas.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btCasas.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCasas.CheckedState.Image = global::DashBOARD_venta_de_casas.Properties.Resources.homeadmiNegro;
            this.btCasas.CheckedState.Parent = this.btCasas;
            this.btCasas.CustomImages.Parent = this.btCasas;
            this.btCasas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btCasas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCasas.ForeColor = System.Drawing.Color.White;
            this.btCasas.HoverState.Parent = this.btCasas;
            this.btCasas.Image = global::DashBOARD_venta_de_casas.Properties.Resources.homeadmi;
            this.btCasas.Location = new System.Drawing.Point(34, 143);
            this.btCasas.Name = "btCasas";
            this.btCasas.ShadowDecoration.Parent = this.btCasas;
            this.btCasas.Size = new System.Drawing.Size(59, 52);
            this.btCasas.TabIndex = 0;
            this.btCasas.UseTransparentBackground = true;
            this.btCasas.CheckedChanged += new System.EventHandler(this.btCasas_CheckedChanged);
            this.btCasas.Click += new System.EventHandler(this.btCasas_Click);
            // 
            // imagenSlide
            // 
            this.imagenSlide.BackColor = System.Drawing.Color.Transparent;
            this.imagenSlide.Image = global::DashBOARD_venta_de_casas.Properties.Resources.undeboardd;
            this.imagenSlide.Location = new System.Drawing.Point(61, 114);
            this.imagenSlide.Name = "imagenSlide";
            this.imagenSlide.Size = new System.Drawing.Size(52, 106);
            this.imagenSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenSlide.TabIndex = 0;
            this.imagenSlide.TabStop = false;
            // 
            // DashBoardAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 570);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardAdmi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admi";
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btCasas;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox imagenSlide;
        private Guna.UI2.WinForms.Guna2Button btSalir;
        private Guna.UI2.WinForms.Guna2Button btEstadisticas;
        private Guna.UI2.WinForms.Guna2Button btUsuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

