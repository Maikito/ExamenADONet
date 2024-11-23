namespace ExamenADONet
{
    partial class frmMenu
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
            this.btnFrmBuscar = new System.Windows.Forms.Button();
            this.frmAgregar = new System.Windows.Forms.Button();
            this.btnFrmActualizar = new System.Windows.Forms.Button();
            this.btnFrmEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrmBuscar
            // 
            this.btnFrmBuscar.Location = new System.Drawing.Point(64, 12);
            this.btnFrmBuscar.Name = "btnFrmBuscar";
            this.btnFrmBuscar.Size = new System.Drawing.Size(306, 106);
            this.btnFrmBuscar.TabIndex = 0;
            this.btnFrmBuscar.Text = "BUSCAR";
            this.btnFrmBuscar.UseVisualStyleBackColor = true;
            this.btnFrmBuscar.Click += new System.EventHandler(this.btnFrmBuscar_Click);
            // 
            // frmAgregar
            // 
            this.frmAgregar.Location = new System.Drawing.Point(64, 140);
            this.frmAgregar.Name = "frmAgregar";
            this.frmAgregar.Size = new System.Drawing.Size(306, 106);
            this.frmAgregar.TabIndex = 0;
            this.frmAgregar.Text = "AGREGAR";
            this.frmAgregar.UseVisualStyleBackColor = true;
            this.frmAgregar.Click += new System.EventHandler(this.frmAgregar_Click);
            // 
            // btnFrmActualizar
            // 
            this.btnFrmActualizar.Location = new System.Drawing.Point(64, 273);
            this.btnFrmActualizar.Name = "btnFrmActualizar";
            this.btnFrmActualizar.Size = new System.Drawing.Size(306, 106);
            this.btnFrmActualizar.TabIndex = 0;
            this.btnFrmActualizar.Text = "EDITAR";
            this.btnFrmActualizar.UseVisualStyleBackColor = true;
            this.btnFrmActualizar.Click += new System.EventHandler(this.btnFrmActualizar_Click);
            // 
            // btnFrmEliminar
            // 
            this.btnFrmEliminar.Location = new System.Drawing.Point(64, 399);
            this.btnFrmEliminar.Name = "btnFrmEliminar";
            this.btnFrmEliminar.Size = new System.Drawing.Size(306, 106);
            this.btnFrmEliminar.TabIndex = 0;
            this.btnFrmEliminar.Text = "ELIMINAR";
            this.btnFrmEliminar.UseVisualStyleBackColor = true;
            this.btnFrmEliminar.Click += new System.EventHandler(this.btnFrmEliminar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 562);
            this.Controls.Add(this.btnFrmEliminar);
            this.Controls.Add(this.btnFrmActualizar);
            this.Controls.Add(this.frmAgregar);
            this.Controls.Add(this.btnFrmBuscar);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrmBuscar;
        private System.Windows.Forms.Button frmAgregar;
        private System.Windows.Forms.Button btnFrmActualizar;
        private System.Windows.Forms.Button btnFrmEliminar;
    }
}