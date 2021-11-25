
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
            this.buttonMENU = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLIBRODIARIO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTOTALDEBE = new System.Windows.Forms.TextBox();
            this.textBoxTOTALHABER = new System.Windows.Forms.TextBox();
            this.textBoxSALDO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCUENTA
            // 
            this.comboBoxCUENTA.FormattingEnabled = true;
            this.comboBoxCUENTA.Location = new System.Drawing.Point(128, 82);
            this.comboBoxCUENTA.Name = "comboBoxCUENTA";
            this.comboBoxCUENTA.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCUENTA.TabIndex = 18;
            this.comboBoxCUENTA.SelectedIndexChanged += new System.EventHandler(this.comboBoxCUENTA_SelectedIndexChanged);
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
            this.comboBoxTIPO.SelectedIndexChanged += new System.EventHandler(this.comboBoxTIPO_SelectedIndexChanged);
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
            // buttonMENU
            // 
            this.buttonMENU.Location = new System.Drawing.Point(34, 493);
            this.buttonMENU.Name = "buttonMENU";
            this.buttonMENU.Size = new System.Drawing.Size(112, 23);
            this.buttonMENU.TabIndex = 19;
            this.buttonMENU.Text = "SALIR";
            this.buttonMENU.UseVisualStyleBackColor = true;
            this.buttonMENU.Click += new System.EventHandler(this.buttonMENU_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // buttonLIBRODIARIO
            // 
            this.buttonLIBRODIARIO.Location = new System.Drawing.Point(34, 452);
            this.buttonLIBRODIARIO.Name = "buttonLIBRODIARIO";
            this.buttonLIBRODIARIO.Size = new System.Drawing.Size(112, 23);
            this.buttonLIBRODIARIO.TabIndex = 21;
            this.buttonLIBRODIARIO.Text = "LIBRO DIARIO";
            this.buttonLIBRODIARIO.UseVisualStyleBackColor = true;
            this.buttonLIBRODIARIO.Click += new System.EventHandler(this.buttonLIBRODIARIO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total DEBE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Saldo DEUDOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total HABER";
            // 
            // textBoxTOTALDEBE
            // 
            this.textBoxTOTALDEBE.Location = new System.Drawing.Point(159, 340);
            this.textBoxTOTALDEBE.Name = "textBoxTOTALDEBE";
            this.textBoxTOTALDEBE.Size = new System.Drawing.Size(100, 23);
            this.textBoxTOTALDEBE.TabIndex = 25;
            // 
            // textBoxTOTALHABER
            // 
            this.textBoxTOTALHABER.Location = new System.Drawing.Point(159, 371);
            this.textBoxTOTALHABER.Name = "textBoxTOTALHABER";
            this.textBoxTOTALHABER.Size = new System.Drawing.Size(100, 23);
            this.textBoxTOTALHABER.TabIndex = 26;
            // 
            // textBoxSALDO
            // 
            this.textBoxSALDO.Location = new System.Drawing.Point(159, 406);
            this.textBoxSALDO.Name = "textBoxSALDO";
            this.textBoxSALDO.Size = new System.Drawing.Size(100, 23);
            this.textBoxSALDO.TabIndex = 27;
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 562);
            this.Controls.Add(this.textBoxSALDO);
            this.Controls.Add(this.textBoxTOTALHABER);
            this.Controls.Add(this.textBoxTOTALDEBE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLIBRODIARIO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMENU);
            this.Controls.Add(this.comboBoxCUENTA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTIPO);
            this.Controls.Add(this.label1);
            this.Name = "LibroMayor";
            this.Text = "LIBRO MAYOR";
            this.Load += new System.EventHandler(this.LibroMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCUENTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMENU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLIBRODIARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTOTALDEBE;
        private System.Windows.Forms.TextBox textBoxTOTALHABER;
        private System.Windows.Forms.TextBox textBoxSALDO;
    }
}