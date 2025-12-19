namespace Shellsortt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTamaño = new Label();
            txtTamaño = new TextBox();
            btnGenerar = new Button();
            txtArreglo = new TextBox();
            btnOrdenar = new Button();
            txtResultado = new TextBox();
            lblArreglo = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Font = new Font("Segoe UI", 11F);
            lblTamaño.Location = new Point(22, 20);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(141, 20);
            lblTamaño.TabIndex = 0;
            lblTamaño.Text = "Tamaño del arreglo:";
            // 
            // txtTamaño
            // 
            txtTamaño.Font = new Font("Segoe UI", 11F);
            txtTamaño.Location = new Point(26, 45);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(120, 27);
            txtTamaño.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 11F);
            btnGenerar.Location = new Point(165, 42);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 32);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // txtArreglo
            // 
            txtArreglo.Font = new Font("Segoe UI", 11F);
            txtArreglo.Location = new Point(26, 115);
            txtArreglo.Multiline = true;
            txtArreglo.Name = "txtArreglo";
            txtArreglo.ReadOnly = true;
            txtArreglo.Size = new Size(709, 126);
            txtArreglo.TabIndex = 3;
            txtArreglo.TextChanged += txtArreglo_TextChanged;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Font = new Font("Segoe UI", 11F);
            btnOrdenar.Location = new Point(32, 264);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(120, 35);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 11F);
            txtResultado.Location = new Point(26, 362);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(709, 184);
            txtResultado.TabIndex = 5;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // lblArreglo
            // 
            lblArreglo.AutoSize = true;
            lblArreglo.Font = new Font("Segoe UI", 11F);
            lblArreglo.Location = new Point(22, 90);
            lblArreglo.Name = "lblArreglo";
            lblArreglo.Size = new Size(130, 20);
            lblArreglo.TabIndex = 6;
            lblArreglo.Text = "Arreglo generado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 11F);
            lblResultado.Location = new Point(32, 330);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            ClientSize = new Size(759, 570);
            Controls.Add(lblResultado);
            Controls.Add(lblArreglo);
            Controls.Add(txtResultado);
            Controls.Add(btnOrdenar);
            Controls.Add(txtArreglo);
            Controls.Add(btnGenerar);
            Controls.Add(txtTamaño);
            Controls.Add(lblTamaño);
            Name = "Form1";
            Text = "Shellsort Interactivo";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.Label lblResultado;
    }
}
