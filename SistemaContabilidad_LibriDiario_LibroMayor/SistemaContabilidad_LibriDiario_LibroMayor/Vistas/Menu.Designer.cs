
namespace SistemaContabilidad_LibriDiario_LibroMayor
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonREGISTRAR = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonREGISTRAR
            // 
            this.buttonREGISTRAR.Location = new System.Drawing.Point(116, 236);
            this.buttonREGISTRAR.Name = "buttonREGISTRAR";
            this.buttonREGISTRAR.Size = new System.Drawing.Size(116, 23);
            this.buttonREGISTRAR.TabIndex = 10;
            this.buttonREGISTRAR.Text = "LIBRO MAYOR";
            this.buttonREGISTRAR.UseVisualStyleBackColor = true;
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(116, 288);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(116, 23);
            this.buttonSALIR.TabIndex = 11;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "LIBRO DIARIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.buttonREGISTRAR);
            this.Name = "Menu";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonREGISTRAR;
        private System.Windows.Forms.Button buttonSALIR;
        private System.Windows.Forms.Button button1;
    }
}

