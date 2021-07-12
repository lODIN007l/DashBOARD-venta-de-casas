
namespace DashBOARD_venta_de_casas
{
    partial class PantallPrincipal
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btCodigo = new Guna.UI2.WinForms.Guna2Button();
            this.btVentaP = new Guna.UI2.WinForms.Guna2Button();
            this.btP2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btP1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btTin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btBUbi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tblViviendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new IngresoPropiedadesVenta.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLateral.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblViviendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.panelLateral.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(318, 741);
            this.panelLateral.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.btCodigo);
            this.guna2CustomGradientPanel1.Controls.Add(this.btVentaP);
            this.guna2CustomGradientPanel1.Controls.Add(this.btP2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btP1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.btTin);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.btBUbi);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(141)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(72)))), ((int)(((byte)(144)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 43);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(289, 655);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // btCodigo
            // 
            this.btCodigo.BackColor = System.Drawing.Color.Transparent;
            this.btCodigo.BorderRadius = 20;
            this.btCodigo.CheckedState.Parent = this.btCodigo;
            this.btCodigo.CustomImages.Parent = this.btCodigo;
            this.btCodigo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(57)))));
            this.btCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCodigo.ForeColor = System.Drawing.Color.White;
            this.btCodigo.HoverState.Parent = this.btCodigo;
            this.btCodigo.Location = new System.Drawing.Point(18, 424);
            this.btCodigo.Name = "btCodigo";
            this.btCodigo.ShadowDecoration.Parent = this.btCodigo;
            this.btCodigo.Size = new System.Drawing.Size(256, 50);
            this.btCodigo.TabIndex = 10;
            this.btCodigo.Text = "Busqueda por Codigo";
            this.btCodigo.Click += new System.EventHandler(this.btCodigo_Click);
            // 
            // btVentaP
            // 
            this.btVentaP.BackColor = System.Drawing.Color.Transparent;
            this.btVentaP.BorderRadius = 20;
            this.btVentaP.CheckedState.Parent = this.btVentaP;
            this.btVentaP.CustomImages.Parent = this.btVentaP;
            this.btVentaP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(57)))));
            this.btVentaP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVentaP.ForeColor = System.Drawing.Color.White;
            this.btVentaP.HoverState.Parent = this.btVentaP;
            this.btVentaP.Location = new System.Drawing.Point(18, 354);
            this.btVentaP.Name = "btVentaP";
            this.btVentaP.ShadowDecoration.Parent = this.btVentaP;
            this.btVentaP.Size = new System.Drawing.Size(256, 50);
            this.btVentaP.TabIndex = 9;
            this.btVentaP.Text = "Publicar Propiedad en venta ";
            this.btVentaP.Click += new System.EventHandler(this.btVentaP_Click);
            // 
            // btP2
            // 
            this.btP2.BackColor = System.Drawing.Color.Transparent;
            this.btP2.BorderRadius = 10;
            this.btP2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btP2.FocusedColor = System.Drawing.Color.Empty;
            this.btP2.FocusedState.Parent = this.btP2;
            this.btP2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btP2.FormattingEnabled = true;
            this.btP2.HoverState.Parent = this.btP2;
            this.btP2.ItemHeight = 30;
            this.btP2.Items.AddRange(new object[] {
            "50",
            "500",
            "5000",
            "50000",
            "500000"});
            this.btP2.ItemsAppearance.Parent = this.btP2;
            this.btP2.Location = new System.Drawing.Point(155, 296);
            this.btP2.Name = "btP2";
            this.btP2.ShadowDecoration.Parent = this.btP2;
            this.btP2.Size = new System.Drawing.Size(119, 36);
            this.btP2.TabIndex = 7;
            // 
            // btP1
            // 
            this.btP1.BackColor = System.Drawing.Color.Transparent;
            this.btP1.BorderRadius = 10;
            this.btP1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btP1.FocusedColor = System.Drawing.Color.Empty;
            this.btP1.FocusedState.Parent = this.btP1;
            this.btP1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btP1.FormattingEnabled = true;
            this.btP1.HoverState.Parent = this.btP1;
            this.btP1.ItemHeight = 30;
            this.btP1.Items.AddRange(new object[] {
            "0",
            "100",
            "10000",
            "100000"});
            this.btP1.ItemsAppearance.Parent = this.btP1;
            this.btP1.Location = new System.Drawing.Point(18, 296);
            this.btP1.Name = "btP1";
            this.btP1.ShadowDecoration.Parent = this.btP1;
            this.btP1.Size = new System.Drawing.Size(117, 36);
            this.btP1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // btTin
            // 
            this.btTin.BackColor = System.Drawing.Color.Transparent;
            this.btTin.BorderRadius = 15;
            this.btTin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btTin.FocusedColor = System.Drawing.Color.Empty;
            this.btTin.FocusedState.Parent = this.btTin;
            this.btTin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btTin.FormattingEnabled = true;
            this.btTin.HoverState.Parent = this.btTin;
            this.btTin.ItemHeight = 30;
            this.btTin.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Suit"});
            this.btTin.ItemsAppearance.Parent = this.btTin;
            this.btTin.Location = new System.Drawing.Point(18, 182);
            this.btTin.Name = "btTin";
            this.btTin.ShadowDecoration.Parent = this.btTin;
            this.btTin.Size = new System.Drawing.Size(256, 36);
            this.btTin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Inmueble";
            // 
            // btBUbi
            // 
            this.btBUbi.BackColor = System.Drawing.Color.Transparent;
            this.btBUbi.BorderRadius = 15;
            this.btBUbi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblViviendasBindingSource, "Ubicacion", true));
            this.btBUbi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btBUbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btBUbi.FocusedColor = System.Drawing.Color.Empty;
            this.btBUbi.FocusedState.Parent = this.btBUbi;
            this.btBUbi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btBUbi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.btBUbi.FormattingEnabled = true;
            this.btBUbi.HoverState.Parent = this.btBUbi;
            this.btBUbi.ItemHeight = 30;
            this.btBUbi.Items.AddRange(new object[] {
            "Aguarico (Orellana, EC)",
            "Alausí (ChimborazEC)",
            "Alfredo Baquerizo (Guayas,EC)",
            "Ambato (Tungurahua, EC)",
            "Antonio Ante (Imbabura, EC)",
            "Arajuno (Pastaza, EC)",
            "Archidona (Napo, EC)",
            "Arenillas (El Oro, EC)",
            "Atacames (Esmeraldas, EC)",
            "Atahualpa (El Oro, EC)",
            "Azogues (Cañar, EC)",
            "Baba (Los Ríos, EC)",
            "Babahoyo (Los Ríos, EC)",
            "Balao (Guayas, EC)",
            "Balsas (El Oro, EC)",
            "Balzar (Guayas, EC)",
            "Baños (Tungurahua, EC)",
            "Biblián (Cañar, EC)",
            "Bolívar (Carchi, EC)",
            "Bolívar (Manabí, EC)",
            "Buena Fe (Los Ríos, EC)",
            "Caluma (Bolívar, EC)",
            "Calvas (Loja, EC)",
            "Camilo Ponce Enríquez (Azuay, EC)",
            "Cañar (Cañar, EC)",
            "Carlos Julio Arosemena Tola (Napo, EC)",
            "Cascales (Sucumbíos, EC)",
            "Catamayo (Loja, EC)",
            "Cayambe (Pichincha, EC)",
            "Celica (Loja, EC)",
            "Centinela del Cóndor (Zamora Chinchipe, EC)",
            "Cevallos (Tungurahua, EC)",
            "Chaguarpamba (Loja, EC)",
            "Chambo (Chimborazo, EC)",
            "Chilla (El Oro, EC)",
            "Chillanes (Bolívar, EC)",
            "Chimbo (Bolívar, EC)",
            "Chinchipe (Zamora Chinchipe, EC)",
            "Chone (Manabí, EC)",
            "Chordeleg (Azuay, EC)",
            "Chunchi (Chimborazo, EC)",
            "Colimes (Guayas, EC)",
            "Colta (Chimborazo, EC)",
            "Cotacachi (Imbabura, EC)",
            "Cuenca (Azuay, EC)",
            "Cumandá (Chimborazo, EC)",
            "Cuyabeno (Sucumbíos, EC)",
            "Daule (Guayas, EC)",
            "Déleg (Cañar, EC)",
            "Durán (Guayas, EC)",
            "Echeandía (Bolívar, EC)",
            "El Carmen (Manabí, EC)",
            "El Chaco (Napo, EC)",
            "El Empalme (Guayas, EC)",
            "El Guabo (El Oro, EC)",
            "El Pan (Azuay, EC)",
            "El Pangui (Zamora Chinchipe, EC)",
            "El Tambo (Cañar, EC)",
            "El Triunfo (Guayas, EC)",
            "Eloy Alfaro (Esmeraldas, EC)",
            "Esmeraldas (Esmeraldas, EC)",
            "Espejo (Carchi, EC)",
            "Espíndola (Loja, EC)",
            "Flavio Alfaro (Manabí, EC)",
            "Francisco de Orellana (Orellana, EC)",
            "General Antonio Elizale (Guayas, EC)",
            "Girón (Azuay, EC)",
            "Gonzalo Pizarro (Sucumbíos, EC)",
            "Gonzanamá (Loja, EC)",
            "Guachapala (Azuay, EC)",
            "Gualaceo (Azuay, EC)",
            "Gualaquiza (Morona Santiago, EC)",
            "Guamote (Chimborazo, EC)",
            "Guano (Chimborazo, EC)",
            "Guaranda (Bolívar, EC)",
            "Guayaquil (Guayas, EC)",
            "Huaca (Carchi, EC)",
            "Huamboya (Morona Santiago, EC)",
            "Huaquillas (El Oro, EC)",
            "Ibarra (Imbabura, EC)",
            "Isabela (Galápagos, EC)",
            "Isidro Ayora (Guayas, EC)",
            "Jama (Manabí, EC)",
            "Jaramijó (Manabí, EC)",
            "Jipijapa (Manabí, EC)",
            "Junín (Manabí, EC)",
            "La Concordia (Santo Domingo de los Tsáchilas, EC)",
            "La Joya de los Sachas (Orellana, EC)",
            "La Libertad (Pichincha, EC)",
            "La Maná (Cotopaxi, EC)",
            "La Troncal (Cañar, EC)",
            "Lago Agrio (Sucumbíos, EC)",
            "Las Lajas (El Oro, EC)",
            "Las Naves (Bolívar, EC)",
            "Latacunga (Cotopaxi, EC)",
            "Limón Indanza (Morona Santiago, EC)",
            "Logroño (Morona Santiago, EC)",
            "Loja (Loja, EC)",
            "Lomas de Sargentillo (Guayas, EC)",
            "Loreto (Orellana, EC)",
            "Macará (Loja, EC)",
            "Machala (El Oro, EC)",
            "Manta (Manabí, EC)",
            "Marcabelí (El Oro, EC)",
            "Marcelino Maridueña (Guayas, EC)",
            "Mejía (Pichincha, EC)",
            "Mera (Pastaza, EC)",
            "Milagro (Guayas, EC)",
            "Mira (Carchi, EC)",
            "Mocache (Los Ríos, EC)",
            "Mocha (Tungurahua, EC)",
            "Montalvo (Los Ríos, EC)",
            "Montecristi (Manabí, EC)",
            "Montúfar (Carchi, EC)",
            "Morona (Morona Santiago, EC)",
            "Muisne (Esmeraldas, EC)",
            "Nabón (Azuay, EC)",
            "Nangaritza (Zamora Chinchipe, EC)",
            "Naranjal (Guayas, EC)",
            "Naranjito (Guayas, EC)",
            "Nobol (Guayas, EC)",
            "Olmedo (Loja, EC)",
            "Olmedo (Manabí, EC)",
            "Oña (Azuay, EC)",
            "Otavalo (Imbabura, EC)",
            "Pablo Sexto (Morona Santiago, EC)",
            "Paján (Manabí, EC)",
            "Palana (Zamora Chinchipe, EC)",
            "Palenque (Los Ríos, EC)",
            "Palestina (Guayas, EC)",
            "Pallatanga (Chimborazo, EC)",
            "Palora (Morona Santiago, EC)",
            "Paltas (Loja, EC)",
            "Pangua (Cotopaxi, EC)",
            "Paquisha (Zamora Chinchipe, EC)",
            "Pasaje (El Oro, EC)",
            "Pastaza (Pastaza, EC)",
            "Patate (Tungurahua, EC)",
            "Paute (Azuay, EC)",
            "Pedernales (Manabí, EC)",
            "Pedro Carbo (Guayas, EC)",
            "Pedro Moncayo (Pichincha, EC)",
            "Pedro Vicente Maldonado (Pichincha, EC)",
            "Penipe (Chimborazo, EC)",
            "Pichincha (Manabí, EC)",
            "Pimampiro (Imbabura, EC)",
            "Pindal (Loja, EC)",
            "Piñas (El Oro, EC)",
            "Playas (Guayas, EC)",
            "Portovelo (El Oro, EC)",
            "Portoviejo (Manabí, EC)",
            "Pucará (Azuay, EC)",
            "Puebloviejo (Los Ríos, EC)",
            "Puerto López (Manabí, EC)",
            "Puerto Quito (Pichincha, EC)",
            "Pujilí (Cotopaxi, EC)",
            "Putumayo (Sucumbíos, EC)",
            "Puyango (Loja, EC)",
            "Quero (Tungurahua, EC)",
            "Quevedo (Los Ríos, EC)",
            "Quijos (Napo, EC)",
            "Quilanga (Loja, EC)",
            "Quinindé (Esmeraldas, EC)",
            "Quinsaloma (Los Ríos, EC)",
            "Quito (Pichincha, EC)",
            "Riobamba (Chimborazo, EC)",
            "Rioverde (Esmeraldas, EC)",
            "Rocafuerte (Manabí, EC)",
            "Rumiñahui (Pichincha, EC)",
            "Salcedo (Cotopaxi, EC)",
            "Salinas (Pichincha, EC)",
            "Salitre (Guayas, EC)",
            "Samborondón (Guayas, EC)",
            "San Cristóbal (Galápagos, EC)",
            "San Fernando (Azuay, EC)",
            "San Juan Bosco (Morona Santiago, EC)",
            "San Lorenzo (Esmeraldas, EC)",
            "San Miguel (Bolívar, EC)",
            "San Miguel de Urcuquí (Imbabura, EC)",
            "San Miguel de los Bancos (Pichincha, EC)",
            "San Pedro de Pelileo (Tungurahua, EC)",
            "San Vicente (Manabí, EC)",
            "Santa Ana (Manabí, EC)",
            "Santa Clara (Pastaza, EC)",
            "Santa Cruz (Galápagos, EC)",
            "Santa Elena (Santa Elena, EC)",
            "Santa Isabel (Azuay, EC)",
            "Santa Lucía (Guayas, EC)",
            "Santa Rosa (El Oro, EC)",
            "Santiago de Méndez (Morona Santiago, EC)",
            "Santiago de Píllaro (Tungurahua, EC)",
            "Santo Domingo (Santo Domingo de los Tsáchilas, EC)",
            "Saquisilí (Cotopaxi, EC)",
            "Saraguro (Loja, EC)",
            "Sevilla de Oro (Azuay, EC)",
            "Shushufindi (Sucumbíos, EC)",
            "Sigchos (Cotopaxi, EC)",
            "Sígsig (Azuay, EC)",
            "Simón Bolívar (Guayas, EC)",
            "Sozoranga (Loja, EC)",
            "Sucre (Manabí, EC)",
            "Sucúa (Morona Santiago, EC)",
            "Sucumbíos (Sucumbíos, EC)",
            "Suscal (Cañar, EC)",
            "Taisha (Morona Santiago, EC)",
            "Tena (Napo, EC)",
            "Tisaleo (Tungurahua, EC)",
            "Tiwintza (Morona Santiago, EC)",
            "Tosagua (Manabí, EC)",
            "Tulcán (Carchi, EC)",
            "Urdaneta (Los Ríos, EC)",
            "Valencia (Los Ríos, EC)",
            "Ventanas (Los Ríos, EC)",
            "Vinces (Los Ríos, EC)",
            "Yacuambi (Zamora Chinchipe, EC)",
            "Yaguachi (Guayas, EC)",
            "Yantzaza (Zamora Chinchipe, EC)",
            "Zamora (Zamora Chinchipe, EC)",
            "Zapotillo (Loja, EC)",
            "Zaruma (El Oro, EC)"});
            this.btBUbi.ItemsAppearance.Parent = this.btBUbi;
            this.btBUbi.Location = new System.Drawing.Point(18, 87);
            this.btBUbi.Name = "btBUbi";
            this.btBUbi.ShadowDecoration.Parent = this.btBUbi;
            this.btBUbi.Size = new System.Drawing.Size(256, 36);
            this.btBUbi.TabIndex = 2;
            this.btBUbi.SelectedIndexChanged += new System.EventHandler(this.btBUbi_SelectedIndexChanged);
            // 
            // tblViviendasBindingSource
            // 
            this.tblViviendasBindingSource.DataMember = "TblViviendas";
            this.tblViviendasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(318, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(946, 741);
            this.panelCentral.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // PantallPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallPrincipal";
            this.panelLateral.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblViviendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2ComboBox btTin;
        public Guna.UI2.WinForms.Guna2ComboBox btBUbi;
        public Guna.UI2.WinForms.Guna2ComboBox btP2;
        public Guna.UI2.WinForms.Guna2ComboBox btP1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btVentaP;
        private Guna.UI2.WinForms.Guna2Button btCodigo;
        private System.Windows.Forms.BindingSource tblViviendasBindingSource;
        private IngresoPropiedadesVenta.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}