namespace Tarea5
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            linkLabel1 = new LinkLabel();
            btnCrearTablauUsuarios = new Button();
            btnAbrir = new Button();
            lbAbrir = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 52);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "TAREA 5 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 171);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 244);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.MediumSeaGreen;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(295, 312);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(96, 31);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(221, 167);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(169, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(221, 244);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(169, 27);
            txtContrasenia.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(304, 407);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear Cuenta";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnCrearTablauUsuarios
            // 
            btnCrearTablauUsuarios.BackColor = Color.MediumSeaGreen;
            btnCrearTablauUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearTablauUsuarios.Location = new Point(514, 189);
            btnCrearTablauUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnCrearTablauUsuarios.Name = "btnCrearTablauUsuarios";
            btnCrearTablauUsuarios.Size = new Size(234, 31);
            btnCrearTablauUsuarios.TabIndex = 7;
            btnCrearTablauUsuarios.Text = "CREAR TABLA USUARIOS";
            btnCrearTablauUsuarios.UseVisualStyleBackColor = false;
            btnCrearTablauUsuarios.Click += btnCrearTablauUsuarios_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.MediumSeaGreen;
            btnAbrir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(514, 284);
            btnAbrir.Margin = new Padding(3, 4, 3, 4);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(234, 36);
            btnAbrir.TabIndex = 8;
            btnAbrir.Text = "CARGAR JSON";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // lbAbrir
            // 
            lbAbrir.AutoSize = true;
            lbAbrir.Location = new Point(514, 324);
            lbAbrir.Name = "lbAbrir";
            lbAbrir.Size = new Size(232, 20);
            lbAbrir.TabIndex = 9;
            lbAbrir.Text = "No se ha cargado un archivo .json";
            lbAbrir.TextAlign = ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "ArchivosJson|*.json";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(914, 600);
            Controls.Add(lbAbrir);
            Controls.Add(btnAbrir);
            Controls.Add(btnCrearTablauUsuarios);
            Controls.Add(linkLabel1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private LinkLabel linkLabel1;
        private Button btnCrearTablauUsuarios;
        private Button btnAbrir;
        private Label lbAbrir;
        private OpenFileDialog openFileDialog1;
    }
}
