
namespace ProyectoFinalBotica
{
    partial class FrmMenu_Administrador
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
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnIngresosEgresos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReclamos
            // 
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamos.Location = new System.Drawing.Point(302, 423);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(360, 120);
            this.btnReclamos.TabIndex = 16;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // btnIngresosEgresos
            // 
            this.btnIngresosEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresosEgresos.Location = new System.Drawing.Point(493, 281);
            this.btnIngresosEgresos.Name = "btnIngresosEgresos";
            this.btnIngresosEgresos.Size = new System.Drawing.Size(360, 120);
            this.btnIngresosEgresos.TabIndex = 15;
            this.btnIngresosEgresos.Text = "Ingresos / Egresos";
            this.btnIngresosEgresos.UseVisualStyleBackColor = true;
            this.btnIngresosEgresos.Click += new System.EventHandler(this.btnIngresosEgresos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(493, 138);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(360, 120);
            this.btnUsuarios.TabIndex = 13;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(111, 280);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(360, 120);
            this.btnCaja.TabIndex = 14;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPedido.Location = new System.Drawing.Point(111, 138);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(360, 120);
            this.btnGenerarPedido.TabIndex = 12;
            this.btnGenerarPedido.Text = "Generar Pedido";
            this.btnGenerarPedido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "MENÚ";
            // 
            // FrmMenu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnReclamos);
            this.Controls.Add(this.btnIngresosEgresos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnGenerarPedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu_Administrador";
            this.Text = "FrmMenu_Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnIngresosEgresos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Label label1;
    }
}