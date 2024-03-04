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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            btnCrearTabla.BackColor = Color.MediumSeaGreen;
            btnCrearTabla.Location = new Point(328, 37);
            btnCrearTabla.Margin = new Padding(3, 4, 3, 4);
            btnCrearTabla.Name = "btnCrearTabla";
            btnCrearTabla.Size = new Size(234, 31);
            btnCrearTabla.TabIndex = 0;
            btnCrearTabla.Text = "CREAR TABLA";
            btnCrearTabla.UseVisualStyleBackColor = false;
            btnCrearTabla.Click += btnCrearTabla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 107);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 103);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(163, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(134, 167);
            txtDirector.Margin = new Padding(3, 4, 3, 4);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(163, 27);
            txtDirector.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 171);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Director:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(134, 235);
            txtPais.Margin = new Padding(3, 4, 3, 4);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(163, 27);
            txtPais.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 239);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Pais:";
            // 
            // dtpFechaLanzamiento
            // 
            dtpFechaLanzamiento.Location = new Point(218, 344);
            dtpFechaLanzamiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            dtpFechaLanzamiento.Size = new Size(228, 27);
            dtpFechaLanzamiento.TabIndex = 7;
            dtpFechaLanzamiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 344);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de Lanzamiento:";
            label4.Click += label4_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = Color.Teal;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(48, 432);
            dgvData.Margin = new Padding(3, 4, 3, 4);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvData.Size = new Size(750, 241);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.MediumSeaGreen;
            btnCrear.Location = new Point(622, 128);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(112, 37);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(134, 291);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(163, 27);
            txtGenero.TabIndex = 15;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(48, 295);
            label.Name = "label";
            label.Size = new Size(64, 20);
            label.TabIndex = 14;
            label.Text = "Género:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumSeaGreen;
            btnEliminar.Location = new Point(622, 189);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 37);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.MediumSeaGreen;
            btnActualizar.Location = new Point(622, 255);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 37);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(399, 103);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 27);
            txtId.TabIndex = 19;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(363, 107);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 18;
            label6.Text = "Id:";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(914, 808);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(txtGenero);
            Controls.Add(label);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtGenero;
        private Label label;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtId;
        private Label label6;
    }
}