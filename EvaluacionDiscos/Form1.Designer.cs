namespace EvaluacionDiscos
{
    partial class Ventana1
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
            this.dgvdiscos = new System.Windows.Forms.DataGridView();
            this.picboxdiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxdiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdiscos
            // 
            this.dgvdiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiscos.Location = new System.Drawing.Point(12, 355);
            this.dgvdiscos.Name = "dgvdiscos";
            this.dgvdiscos.RowHeadersWidth = 51;
            this.dgvdiscos.RowTemplate.Height = 24;
            this.dgvdiscos.Size = new System.Drawing.Size(600, 271);
            this.dgvdiscos.TabIndex = 0;
            this.dgvdiscos.SelectionChanged += new System.EventHandler(this.dgvdiscos_SelectionChanged);
            // 
            // picboxdiscos
            // 
            this.picboxdiscos.Location = new System.Drawing.Point(252, 18);
            this.picboxdiscos.Name = "picboxdiscos";
            this.picboxdiscos.Size = new System.Drawing.Size(360, 304);
            this.picboxdiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxdiscos.TabIndex = 1;
            this.picboxdiscos.TabStop = false;
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(624, 638);
            this.Controls.Add(this.picboxdiscos);
            this.Controls.Add(this.dgvdiscos);
            this.Name = "Ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.Ventana1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxdiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiscos;
        private System.Windows.Forms.PictureBox picboxdiscos;
    }
}

