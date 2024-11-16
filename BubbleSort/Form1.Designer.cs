namespace BubbleSort
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
            dataGridView1 = new DataGridView();
            btnOrdenarPorNombre = new Button();
            btnOrdenarPorCalificacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(298, 259);
            dataGridView1.TabIndex = 0;
            // 
            // btnOrdenarPorNombre
            // 
            btnOrdenarPorNombre.Location = new Point(401, 69);
            btnOrdenarPorNombre.Name = "btnOrdenarPorNombre";
            btnOrdenarPorNombre.Size = new Size(231, 23);
            btnOrdenarPorNombre.TabIndex = 1;
            btnOrdenarPorNombre.Text = "Ordenar por Nombre";
            btnOrdenarPorNombre.UseVisualStyleBackColor = true;
            btnOrdenarPorNombre.Click += btnOrdenarPorNombre_Click;
            // 
            // btnOrdenarPorCalificacion
            // 
            btnOrdenarPorCalificacion.Location = new Point(401, 116);
            btnOrdenarPorCalificacion.Name = "btnOrdenarPorCalificacion";
            btnOrdenarPorCalificacion.Size = new Size(231, 23);
            btnOrdenarPorCalificacion.TabIndex = 2;
            btnOrdenarPorCalificacion.Text = "Ordenar por Calificación";
            btnOrdenarPorCalificacion.UseVisualStyleBackColor = true;
            btnOrdenarPorCalificacion.Click += btnOrdenarPorCalificacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenarPorCalificacion);
            Controls.Add(btnOrdenarPorNombre);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOrdenarPorNombre;
        private Button btnOrdenarPorCalificacion;
    }
}
