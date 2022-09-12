
namespace PRÁCTICA_5._3
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.comboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.txt_num4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(21, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(188, 50);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(21, 130);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(100, 20);
            this.txtNum3.TabIndex = 2;
            // 
            // comboOpciones
            // 
            this.comboOpciones.FormattingEnabled = true;
            this.comboOpciones.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Diario"});
            this.comboOpciones.Location = new System.Drawing.Point(176, 130);
            this.comboOpciones.Name = "comboOpciones";
            this.comboOpciones.Size = new System.Drawing.Size(121, 21);
            this.comboOpciones.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(101, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_num1.Location = new System.Drawing.Point(48, 24);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(42, 20);
            this.txt_num1.TabIndex = 5;
            this.txt_num1.Text = "Capital";
            // 
            // txt_num2
            // 
            this.txt_num2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_num2.Location = new System.Drawing.Point(197, 24);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(81, 20);
            this.txt_num2.TabIndex = 6;
            this.txt_num2.Text = "Tasa de interés";
            // 
            // txt_num3
            // 
            this.txt_num3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_num3.Location = new System.Drawing.Point(48, 104);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(45, 20);
            this.txt_num3.TabIndex = 7;
            this.txt_num3.Text = "Tiempo";
            // 
            // txt_num4
            // 
            this.txt_num4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_num4.Location = new System.Drawing.Point(188, 104);
            this.txt_num4.Name = "txt_num4";
            this.txt_num4.Size = new System.Drawing.Size(100, 20);
            this.txt_num4.TabIndex = 8;
            this.txt_num4.Text = "Período de tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(321, 233);
            this.Controls.Add(this.txt_num4);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.comboOpciones);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.TextBox txt_num4;
    }
}

