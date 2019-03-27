namespace WindowsFormsApplication2
{
    partial class Operaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnD = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(36, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(41, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Valor A";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(40, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Valor2";
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(94, 36);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 2;
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(94, 73);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(35, 119);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Reasultado";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(119, 134);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(57, 23);
            this.btnCal.TabIndex = 5;
            this.btnCal.Text = "&Sumar";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnM);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtValB);
            this.groupBox1.Controls.Add(this.btnCal);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.txtValA);
            this.groupBox1.Location = new System.Drawing.Point(25, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(308, 134);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(57, 23);
            this.btnD.TabIndex = 8;
            this.btnD.Text = "&Dividir";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(245, 134);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(57, 23);
            this.btnM.TabIndex = 7;
            this.btnM.Text = "&Multi.";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Restar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.TextBox txtValB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button button1;
    }
}

