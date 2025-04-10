namespace has_map_ex
{
    partial class Form1
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
            label1 = new Label();
            lblNombre = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnListar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtBuscarId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 64);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(281, 108);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 152);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 186);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Agregar Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 271);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Buscar Por ID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(437, 182);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(470, 268);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(304, 330);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(256, 23);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar Usuarios";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(437, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(437, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(437, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtBuscarId
            // 
            txtBuscarId.Location = new Point(364, 268);
            txtBuscarId.Name = "txtBuscarId";
            txtBuscarId.Size = new Size(100, 23);
            txtBuscarId.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscarId);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnListar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnListar;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtBuscarId;
    }
}
