namespace Presentation.Screens
{
    partial class PlatosDialog
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
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatos.Location = new System.Drawing.Point(13, 13);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.Size = new System.Drawing.Size(648, 169);
            this.dgvPlatos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 189);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Platos";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // PlatosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 237);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPlatos);
            this.Name = "PlatosDialog";
            this.Text = "PlatosDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlatos;
        private System.Windows.Forms.Button btnAgregar;
    }
}