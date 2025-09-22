namespace Variables
{
    partial class Form1
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
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBcodigo = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.lblvariablelocal = new System.Windows.Forms.Label();
            this.lblvariableglobal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(253, 80);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(230, 20);
            this.TBnombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // TBcodigo
            // 
            this.TBcodigo.Location = new System.Drawing.Point(253, 125);
            this.TBcodigo.Name = "TBcodigo";
            this.TBcodigo.Size = new System.Drawing.Size(230, 20);
            this.TBcodigo.TabIndex = 3;
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(306, 176);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(132, 72);
            this.Verificar.TabIndex = 4;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            // 
            // lblvariablelocal
            // 
            this.lblvariablelocal.AutoSize = true;
            this.lblvariablelocal.Location = new System.Drawing.Point(265, 280);
            this.lblvariablelocal.Name = "lblvariablelocal";
            this.lblvariablelocal.Size = new System.Drawing.Size(67, 13);
            this.lblvariablelocal.TabIndex = 5;
            this.lblvariablelocal.Text = "Variablelocal";
            // 
            // lblvariableglobal
            // 
            this.lblvariableglobal.AutoSize = true;
            this.lblvariableglobal.Location = new System.Drawing.Point(265, 315);
            this.lblvariableglobal.Name = "lblvariableglobal";
            this.lblvariableglobal.Size = new System.Drawing.Size(79, 13);
            this.lblvariableglobal.TabIndex = 6;
            this.lblvariableglobal.Text = "varaible global}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblvariableglobal);
            this.Controls.Add(this.lblvariablelocal);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.TBcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBcodigo;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Label lblvariablelocal;
        private System.Windows.Forms.Label lblvariableglobal;
    }
}

