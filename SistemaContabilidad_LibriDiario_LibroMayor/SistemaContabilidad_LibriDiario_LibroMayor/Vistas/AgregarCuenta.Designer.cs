
namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    partial class AgregarCuenta
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
            this.buttonAGREGAR = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.comboBoxTIPO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNOMBRECUENTA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAGREGAR
            // 
            this.buttonAGREGAR.Location = new System.Drawing.Point(38, 250);
            this.buttonAGREGAR.Name = "buttonAGREGAR";
            this.buttonAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.buttonAGREGAR.TabIndex = 0;
            this.buttonAGREGAR.Text = "AGREGAR";
            this.buttonAGREGAR.UseVisualStyleBackColor = true;
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(38, 291);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(75, 23);
            this.buttonSALIR.TabIndex = 1;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            // 
            // comboBoxTIPO
            // 
            this.comboBoxTIPO.FormattingEnabled = true;
            this.comboBoxTIPO.Location = new System.Drawing.Point(132, 54);
            this.comboBoxTIPO.Name = "comboBoxTIPO";
            this.comboBoxTIPO.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTIPO.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE";
            // 
            // textBoxNOMBRECUENTA
            // 
            this.textBoxNOMBRECUENTA.Location = new System.Drawing.Point(132, 117);
            this.textBoxNOMBRECUENTA.Name = "textBoxNOMBRECUENTA";
            this.textBoxNOMBRECUENTA.Size = new System.Drawing.Size(121, 23);
            this.textBoxNOMBRECUENTA.TabIndex = 10;
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.textBoxNOMBRECUENTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTIPO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.buttonAGREGAR);
            this.Name = "AgregarCuenta";
            this.Text = "AGREGAR CUENTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAGREGAR;
        private System.Windows.Forms.Button buttonSALIR;
        private System.Windows.Forms.ComboBox comboBoxTIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNOMBRECUENTA;
    }
}