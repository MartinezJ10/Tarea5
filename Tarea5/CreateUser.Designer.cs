namespace Tarea5
{
    partial class frmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            txtNuevaContrasenia = new TextBox();
            txtNuevoUsuario = new TextBox();
            btnCrearUsuario = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(422, 289);
            txtNuevaContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.Size = new Size(169, 27);
            txtNuevaContrasenia.TabIndex = 10;
            // 
            // txtNuevoUsuario
            // 
            txtNuevoUsuario.Location = new Point(422, 212);
            txtNuevoUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(169, 27);
            txtNuevoUsuario.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.DarkRed;
            btnCrearUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearUsuario.Location = new Point(506, 357);
            btnCrearUsuario.Margin = new Padding(3, 4, 3, 4);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(86, 31);
            btnCrearUsuario.TabIndex = 8;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(323, 289);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 7;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 216);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 89);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 11;
            label1.Text = "CREAR USUARIO";
            // 
            // frmCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txtNuevaContrasenia);
            Controls.Add(txtNuevoUsuario);
            Controls.Add(btnCrearUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCreateUser";
            Text = "CreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevaContrasenia;
        private TextBox txtNuevoUsuario;
        private Button btnCrearUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}