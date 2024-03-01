namespace Tarea5
{
    partial class frmMain
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
            btnCrearTabla = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtDirector = new TextBox();
            label2 = new Label();
            txtPais = new TextBox();
            label3 = new Label();
            dtpFechaLanzamiento = new DateTimePicker();
            label4 = new Label();
            dgvData = new DataGridView();
            btnCrear = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label5 = new Label();
            txtGenero = new TextBox();
            label = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnCrearTabla
            // 
            btnCrearTabla.Location = new Point(287, 28);
            btnCrearTabla.Name = "btnCrearTabla";
            btnCrearTabla.Size = new Size(205, 23);
            btnCrearTabla.TabIndex = 0;
            btnCrearTabla.Text = "CREAR TABLA";
            btnCrearTabla.UseVisualStyleBackColor = true;
            btnCrearTabla.Click += btnCrearTabla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(117, 125);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(143, 23);
            txtDirector.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 128);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Director";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(117, 176);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(143, 23);
            txtPais.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 179);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 5;
            label3.Text = "Pais";
            // 
            // dtpFechaLanzamiento
            // 
            dtpFechaLanzamiento.Location = new Point(191, 258);
            dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            dtpFechaLanzamiento.Size = new Size(200, 23);
            dtpFechaLanzamiento.TabIndex = 7;
            dtpFechaLanzamiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 258);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Lanzamiento";
            label4.Click += label4_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(42, 393);
            dgvData.Name = "dgvData";
            dgvData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvData.Size = new Size(600, 181);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(544, 96);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(98, 28);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(287, 321);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 28);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(111, 322);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(143, 23);
            txtBuscar.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 328);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 13;
            label5.Text = "Buscar";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(117, 218);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(143, 23);
            txtGenero.TabIndex = 15;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(42, 221);
            label.Name = "label";
            label.Size = new Size(45, 15);
            label.TabIndex = 14;
            label.Text = "Género";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(544, 142);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 28);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(544, 191);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 28);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(349, 77);
            txtId.Name = "txtId";
            txtId.Size = new Size(143, 23);
            txtId.TabIndex = 19;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 80);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 18;
            label6.Text = "Id";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 606);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(txtGenero);
            Controls.Add(label);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Controls.Add(dgvData);
            Controls.Add(label4);
            Controls.Add(dtpFechaLanzamiento);
            Controls.Add(txtPais);
            Controls.Add(label3);
            Controls.Add(txtDirector);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCrearTabla);
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearTabla;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDirector;
        private Label label2;
        private TextBox txtPais;
        private Label label3;
        private DateTimePicker dtpFechaLanzamiento;
        private Label label4;
        private DataGridView dgvData;
        private Button btnCrear;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label5;
        private TextBox txtGenero;
        private Label label;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtId;
        private Label label6;
    }
}