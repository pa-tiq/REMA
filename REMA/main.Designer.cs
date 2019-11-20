namespace REMA
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageViga = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownW = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownU = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownF = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageSecTrans = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTransY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransX = new System.Windows.Forms.NumericUpDown();
            this.labelTransy = new System.Windows.Forms.Label();
            this.labelTransx = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageConstantes = new System.Windows.Forms.TabPage();
            this.buttonValoresPadrao = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageViga.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSecTrans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalcular.Location = new System.Drawing.Point(11, 288);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(97, 28);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(610, 288);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(97, 28);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageViga);
            this.tabControl1.Controls.Add(this.tabPageSecTrans);
            this.tabControl1.Controls.Add(this.tabPageConstantes);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 271);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageViga
            // 
            this.tabPageViga.Controls.Add(this.groupBox1);
            this.tabPageViga.Controls.Add(this.pictureBox1);
            this.tabPageViga.Location = new System.Drawing.Point(4, 22);
            this.tabPageViga.Name = "tabPageViga";
            this.tabPageViga.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViga.Size = new System.Drawing.Size(688, 245);
            this.tabPageViga.TabIndex = 0;
            this.tabPageViga.Text = "Viga";
            this.tabPageViga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDownW);
            this.groupBox1.Controls.Add(this.numericUpDownU);
            this.groupBox1.Controls.Add(this.numericUpDownV);
            this.groupBox1.Controls.Add(this.numericUpDownP);
            this.groupBox1.Controls.Add(this.numericUpDownF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelU);
            this.groupBox1.Controls.Add(this.labelP);
            this.groupBox1.Controls.Add(this.labelF);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 233);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownW
            // 
            this.numericUpDownW.Location = new System.Drawing.Point(31, 126);
            this.numericUpDownW.Name = "numericUpDownW";
            this.numericUpDownW.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownW.TabIndex = 41;
            // 
            // numericUpDownU
            // 
            this.numericUpDownU.Location = new System.Drawing.Point(31, 71);
            this.numericUpDownU.Name = "numericUpDownU";
            this.numericUpDownU.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownU.TabIndex = 40;
            // 
            // numericUpDownV
            // 
            this.numericUpDownV.Location = new System.Drawing.Point(32, 98);
            this.numericUpDownV.Name = "numericUpDownV";
            this.numericUpDownV.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownV.TabIndex = 39;
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.Location = new System.Drawing.Point(31, 45);
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownP.TabIndex = 38;
            // 
            // numericUpDownF
            // 
            this.numericUpDownF.Location = new System.Drawing.Point(31, 19);
            this.numericUpDownF.Name = "numericUpDownF";
            this.numericUpDownF.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownF.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "w:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "v:";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(10, 74);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(16, 13);
            this.labelU.TabIndex = 34;
            this.labelU.Text = "u:";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(9, 48);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(17, 13);
            this.labelP.TabIndex = 33;
            this.labelP.Text = "P:";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(9, 22);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(16, 13);
            this.labelF.TabIndex = 32;
            this.labelF.Text = "F:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageSecTrans
            // 
            this.tabPageSecTrans.Controls.Add(this.groupBox3);
            this.tabPageSecTrans.Controls.Add(this.groupBox2);
            this.tabPageSecTrans.Controls.Add(this.pictureBox2);
            this.tabPageSecTrans.Location = new System.Drawing.Point(4, 22);
            this.tabPageSecTrans.Name = "tabPageSecTrans";
            this.tabPageSecTrans.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSecTrans.Size = new System.Drawing.Size(688, 245);
            this.tabPageSecTrans.TabIndex = 1;
            this.tabPageSecTrans.Text = "Seção Transversal";
            this.tabPageSecTrans.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(491, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 161);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownTransY);
            this.groupBox2.Controls.Add(this.numericUpDownTransX);
            this.groupBox2.Controls.Add(this.labelTransy);
            this.groupBox2.Controls.Add(this.labelTransx);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 77);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDownTransY
            // 
            this.numericUpDownTransY.Location = new System.Drawing.Point(29, 45);
            this.numericUpDownTransY.Name = "numericUpDownTransY";
            this.numericUpDownTransY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTransY.TabIndex = 28;
            // 
            // numericUpDownTransX
            // 
            this.numericUpDownTransX.Location = new System.Drawing.Point(29, 19);
            this.numericUpDownTransX.Name = "numericUpDownTransX";
            this.numericUpDownTransX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTransX.TabIndex = 27;
            // 
            // labelTransy
            // 
            this.labelTransy.AutoSize = true;
            this.labelTransy.Location = new System.Drawing.Point(8, 47);
            this.labelTransy.Name = "labelTransy";
            this.labelTransy.Size = new System.Drawing.Size(15, 13);
            this.labelTransy.TabIndex = 26;
            this.labelTransy.Text = "y:";
            // 
            // labelTransx
            // 
            this.labelTransx.AutoSize = true;
            this.labelTransx.Location = new System.Drawing.Point(8, 21);
            this.labelTransx.Name = "labelTransx";
            this.labelTransx.Size = new System.Drawing.Size(15, 13);
            this.labelTransx.TabIndex = 25;
            this.labelTransx.Text = "x:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageConstantes
            // 
            this.tabPageConstantes.Location = new System.Drawing.Point(4, 22);
            this.tabPageConstantes.Name = "tabPageConstantes";
            this.tabPageConstantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConstantes.Size = new System.Drawing.Size(688, 245);
            this.tabPageConstantes.TabIndex = 2;
            this.tabPageConstantes.Text = "Constantes";
            this.tabPageConstantes.UseVisualStyleBackColor = true;
            // 
            // buttonValoresPadrao
            // 
            this.buttonValoresPadrao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValoresPadrao.Location = new System.Drawing.Point(509, 288);
            this.buttonValoresPadrao.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValoresPadrao.Name = "buttonValoresPadrao";
            this.buttonValoresPadrao.Size = new System.Drawing.Size(97, 28);
            this.buttonValoresPadrao.TabIndex = 17;
            this.buttonValoresPadrao.Text = "Valores Padrão";
            this.buttonValoresPadrao.UseVisualStyleBackColor = true;
            this.buttonValoresPadrao.Click += new System.EventHandler(this.buttonValoresPadrao_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(31, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 42;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(32, 204);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 43;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(32, 178);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "S1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "S2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "S3:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 327);
            this.Controls.Add(this.buttonValoresPadrao);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "REMA";
            this.tabControl1.ResumeLayout(false);
            this.tabPageViga.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSecTrans.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageViga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageSecTrans;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPageConstantes;
        private System.Windows.Forms.Button buttonValoresPadrao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownW;
        private System.Windows.Forms.NumericUpDown numericUpDownU;
        private System.Windows.Forms.NumericUpDown numericUpDownV;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
        private System.Windows.Forms.NumericUpDown numericUpDownF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelU;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownTransY;
        private System.Windows.Forms.NumericUpDown numericUpDownTransX;
        private System.Windows.Forms.Label labelTransy;
        private System.Windows.Forms.Label labelTransx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

