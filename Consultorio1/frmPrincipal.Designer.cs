namespace Consultorio1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anot = new System.Windows.Forms.FlowLayoutPanel();
            this.dg = new System.Windows.Forms.DataGridView();
            this.cbDentista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(445, 348);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(42, 34);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Anotações";
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.Visible = false;
            this.CodigoPaciente.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 94;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 93;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 94;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "ColunaCodigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // anot
            // 
            this.anot.Location = new System.Drawing.Point(367, 395);
            this.anot.Name = "anot";
            this.anot.Size = new System.Drawing.Size(891, 260);
            this.anot.TabIndex = 15;
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Hora,
            this.Paciente,
            this.Status,
            this.CodigoPaciente});
            this.dg.Location = new System.Drawing.Point(12, 71);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(324, 606);
            this.dg.TabIndex = 11;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // cbDentista
            // 
            this.cbDentista.FormattingEnabled = true;
            this.cbDentista.Location = new System.Drawing.Point(126, 33);
            this.cbDentista.Name = "cbDentista";
            this.cbDentista.Size = new System.Drawing.Size(210, 21);
            this.cbDentista.TabIndex = 10;
            this.cbDentista.Click += new System.EventHandler(this.cbDentista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultas do Dia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDentista,
            this.menuPaciente,
            this.menuConsulta,
            this.usuarioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuDentista
            // 
            this.menuDentista.Name = "menuDentista";
            this.menuDentista.Size = new System.Drawing.Size(180, 22);
            this.menuDentista.Text = "Dentista";
            this.menuDentista.Click += new System.EventHandler(this.menuDentista_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(180, 22);
            this.menuPaciente.Text = "Paciente";
            this.menuPaciente.Click += new System.EventHandler(this.menuPaciente_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(180, 22);
            this.menuConsulta.Text = "Consulta";
            this.menuConsulta.Click += new System.EventHandler(this.menuConsulta_Click);
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentistas,
            this.menuAgPacientes,
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendasToolStripMenuItem.Image")));
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgDentistas
            // 
            this.menuAgDentistas.Name = "menuAgDentistas";
            this.menuAgDentistas.Size = new System.Drawing.Size(126, 22);
            this.menuAgDentistas.Text = "Dentistas";
            this.menuAgDentistas.Click += new System.EventHandler(this.menuAgDentistas_Click);
            // 
            // menuAgPacientes
            // 
            this.menuAgPacientes.Name = "menuAgPacientes";
            this.menuAgPacientes.Size = new System.Drawing.Size(126, 22);
            this.menuAgPacientes.Text = "Pacientes";
            this.menuAgPacientes.Click += new System.EventHandler(this.menuAgPacientes_Click);
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(126, 22);
            this.menuAgConsultas.Text = "Consultas";
            this.menuAgConsultas.Click += new System.EventHandler(this.menuAgConsultas_Click);
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = ((System.Drawing.Image)(resources.GetObject("MAjuda.Image")));
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(66, 20);
            this.MAjuda.Text = "Ajuda";
            this.MAjuda.Click += new System.EventHandler(this.MAjuda_Click);
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(115, 22);
            this.menuSuporte.Text = "Suporte";
            // 
            // MSair
            // 
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(54, 20);
            this.MSair.Text = "Sair";
            this.MSair.Click += new System.EventHandler(this.MSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(367, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 288);
            this.panel1.TabIndex = 12;
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 600);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.anot);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.cbDentista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewLinkColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.FlowLayoutPanel anot;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox cbDentista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuAgPacientes;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentistas;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuDentista;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}