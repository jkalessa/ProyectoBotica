﻿
namespace ProyectoFinalBotica
{
    partial class FrmMenu_Farmaceutico
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
            this.btnGenerarTicket = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.btnIngresosEgresos = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTicket.Location = new System.Drawing.Point(111, 138);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(360, 120);
            this.btnGenerarTicket.TabIndex = 1;
            this.btnGenerarTicket.Text = "Generar Ticket";
            this.btnGenerarTicket.UseVisualStyleBackColor = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(493, 138);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(360, 120);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Stock de Producto";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCajas
            // 
            this.btnCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajas.Location = new System.Drawing.Point(111, 280);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(360, 120);
            this.btnCajas.TabIndex = 3;
            this.btnCajas.Text = "Reporte de Pedido";
            this.btnCajas.UseVisualStyleBackColor = true;
            // 
            // btnIngresosEgresos
            // 
            this.btnIngresosEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresosEgresos.Location = new System.Drawing.Point(493, 281);
            this.btnIngresosEgresos.Name = "btnIngresosEgresos";
            this.btnIngresosEgresos.Size = new System.Drawing.Size(360, 120);
            this.btnIngresosEgresos.TabIndex = 4;
            this.btnIngresosEgresos.Text = "Proveedores";
            this.btnIngresosEgresos.UseVisualStyleBackColor = true;
            // 
            // btnReclamos
            // 
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamos.Location = new System.Drawing.Point(302, 423);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(360, 120);
            this.btnReclamos.TabIndex = 5;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ";
            // 
            // FrmMenu_Farmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReclamos);
            this.Controls.Add(this.btnIngresosEgresos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCajas);
            this.Controls.Add(this.btnGenerarTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu_Farmaceutico";
            this.Text = "FrmMenu_Farmaceutico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarTicket;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Button btnIngresosEgresos;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Label label1;
    }
}