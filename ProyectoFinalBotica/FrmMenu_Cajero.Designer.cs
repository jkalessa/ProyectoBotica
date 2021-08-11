
namespace ProyectoFinalBotica
{
    partial class FrmMenu_Cajero
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
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.btnRegistroDeVentas = new System.Windows.Forms.Button();
            this.btnReporteDeComprobantes = new System.Windows.Forms.Button();
            this.btnGenerarComprobante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÚ";
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(302, 423);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(360, 120);
            this.btnCaja.TabIndex = 10;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            // 
            // btnIngresos
            // 
            this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.Location = new System.Drawing.Point(493, 281);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(360, 120);
            this.btnIngresos.TabIndex = 9;
            this.btnIngresos.Text = "Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = true;
            // 
            // btnRegistroDeVentas
            // 
            this.btnRegistroDeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeVentas.Location = new System.Drawing.Point(493, 138);
            this.btnRegistroDeVentas.Name = "btnRegistroDeVentas";
            this.btnRegistroDeVentas.Size = new System.Drawing.Size(360, 120);
            this.btnRegistroDeVentas.TabIndex = 7;
            this.btnRegistroDeVentas.Text = "Registro de Ventas";
            this.btnRegistroDeVentas.UseVisualStyleBackColor = true;
            // 
            // btnReporteDeComprobantes
            // 
            this.btnReporteDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteDeComprobantes.Location = new System.Drawing.Point(111, 280);
            this.btnReporteDeComprobantes.Name = "btnReporteDeComprobantes";
            this.btnReporteDeComprobantes.Size = new System.Drawing.Size(360, 120);
            this.btnReporteDeComprobantes.TabIndex = 8;
            this.btnReporteDeComprobantes.Text = "Reporte de Comprobantes";
            this.btnReporteDeComprobantes.UseVisualStyleBackColor = true;
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarComprobante.Location = new System.Drawing.Point(111, 138);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(360, 120);
            this.btnGenerarComprobante.TabIndex = 6;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.UseVisualStyleBackColor = true;
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // FrmMenu_Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnRegistroDeVentas);
            this.Controls.Add(this.btnReporteDeComprobantes);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu_Cajero";
            this.Text = "FrmMenu_Cajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnRegistroDeVentas;
        private System.Windows.Forms.Button btnReporteDeComprobantes;
        private System.Windows.Forms.Button btnGenerarComprobante;
    }
}