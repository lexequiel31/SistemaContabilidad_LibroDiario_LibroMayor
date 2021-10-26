
namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    partial class LibroMayor
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
            this.comboBoxCUENTA = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTIPO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCUENTA
            // 
            this.comboBoxCUENTA.FormattingEnabled = true;
            this.comboBoxCUENTA.Location = new System.Drawing.Point(128, 82);
            this.comboBoxCUENTA.Name = "comboBoxCUENTA";
            this.comboBoxCUENTA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCUENTA.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "CUENTA";
            // 
            // comboBoxTIPO
            // 
            this.comboBoxTIPO.FormattingEnabled = true;
            this.comboBoxTIPO.Location = new System.Drawing.Point(128, 37);
            this.comboBoxTIPO.Name = "comboBoxTIPO";
            this.comboBoxTIPO.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTIPO.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "TIPO";
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(34, 388);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(75, 23);
            this.buttonSALIR.TabIndex = 19;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.comboBoxCUENTA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTIPO);
            this.Controls.Add(this.label1);
            this.Name = "LibroMayor";
            this.Text = "LIBRO MAYOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCUENTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSALIR;
    }
}