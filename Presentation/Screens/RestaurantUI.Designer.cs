namespace Presentation.Presentation
{
    partial class RestaurantUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxActivo = new System.Windows.Forms.ComboBox();
            this.dgvRestaurantes = new System.Windows.Forms.DataGridView();
            this.btnSelectedRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(209, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(209, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(81, 43);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Activo";
            // 
            // cbxActivo
            // 
            this.cbxActivo.FormattingEnabled = true;
            this.cbxActivo.Location = new System.Drawing.Point(81, 69);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(121, 21);
            this.cbxActivo.TabIndex = 7;
            // 
            // dgvRestaurantes
            // 
            this.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantes.Location = new System.Drawing.Point(13, 147);
            this.dgvRestaurantes.Name = "dgvRestaurantes";
            this.dgvRestaurantes.Size = new System.Drawing.Size(456, 174);
            this.dgvRestaurantes.TabIndex = 8;
            this.dgvRestaurantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRestaurantes_CellFormatting);
            this.dgvRestaurantes.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvRestaurantes_ColumnAdded);
            // 
            // btnSelectedRows
            // 
            this.btnSelectedRows.Location = new System.Drawing.Point(12, 99);
            this.btnSelectedRows.Name = "btnSelectedRows";
            this.btnSelectedRows.Size = new System.Drawing.Size(75, 42);
            this.btnSelectedRows.TabIndex = 9;
            this.btnSelectedRows.Text = "Mostrar Platos";
            this.btnSelectedRows.UseVisualStyleBackColor = true;
            this.btnSelectedRows.Click += new System.EventHandler(this.btnSelectedRows_Click);
            // 
            // RestaurantUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 336);
            this.Controls.Add(this.btnSelectedRows);
            this.Controls.Add(this.dgvRestaurantes);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantUI";
            this.Text = "RestaurantUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxActivo;
        private System.Windows.Forms.DataGridView dgvRestaurantes;
        private System.Windows.Forms.Button btnSelectedRows;
    }
}