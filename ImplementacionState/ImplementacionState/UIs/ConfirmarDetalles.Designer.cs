namespace ImplementacionState.UIs
{
    partial class ConfirmarDetalles
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
            this.btnAcc = new System.Windows.Forms.Button();
            this.brnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAcc.Location = new System.Drawing.Point(153, 87);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(79, 31);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Text = "Aceptar";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // brnCancel
            // 
            this.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnCancel.Location = new System.Drawing.Point(342, 87);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(79, 31);
            this.brnCancel.TabIndex = 1;
            this.brnCancel.Text = "Cancelar";
            this.brnCancel.UseVisualStyleBackColor = true;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmar Finalizacion de los Items Seleccionados?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnAcc);
            this.Name = "ConfirmarDetalles";
            this.Text = "Confirmacion de finalizacion";
            this.Load += new System.EventHandler(this.ConfirmarDetalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Label label1;
    }
}