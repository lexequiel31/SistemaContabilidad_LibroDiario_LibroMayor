
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
            this.buttonLIBROMAYOR = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.buttonLIBRODIARIO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLIBROMAYOR
            // 
            this.buttonLIBROMAYOR.Location = new System.Drawing.Point(116, 236);
            this.buttonLIBROMAYOR.Name = "buttonLIBROMAYOR";
            this.buttonLIBROMAYOR.Size = new System.Drawing.Size(116, 23);
            this.buttonLIBROMAYOR.TabIndex = 10;
            this.buttonLIBROMAYOR.Text = "LIBRO MAYOR";
            this.buttonLIBROMAYOR.UseVisualStyleBackColor = true;
            this.buttonLIBROMAYOR.Click += new System.EventHandler(this.buttonLIBROMAYOR_Click);
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(116, 288);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(116, 23);
            this.buttonSALIR.TabIndex = 11;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            this.buttonSALIR.Click += new System.EventHandler(this.buttonSALIR_Click);
            // 
            // buttonLIBRODIARIO
            // 
            this.buttonLIBRODIARIO.Location = new System.Drawing.Point(116, 186);
            this.buttonLIBRODIARIO.Name = "buttonLIBRODIARIO";
            this.buttonLIBRODIARIO.Size = new System.Drawing.Size(116, 23);
            this.buttonLIBRODIARIO.TabIndex = 12;
            this.buttonLIBRODIARIO.Text = "LIBRO DIARIO";
            this.buttonLIBRODIARIO.UseVisualStyleBackColor = true;
            this.buttonLIBRODIARIO.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "SISTEMA LIBRO DIARIO-LIBRO MAYOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "GLOBAL - GRUPO 8";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "GOZALVEZ, Franco - PIRIZ,Carla - MORENO, Exequiel";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLIBRODIARIO);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.buttonLIBROMAYOR);
            this.Name = "Menu";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLIBROMAYOR;
        private System.Windows.Forms.Button buttonSALIR;
        private System.Windows.Forms.Button buttonLIBRODIARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

