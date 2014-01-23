namespace GenerateTestData
{
    partial class ProgramInterface
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
            this.components = new System.ComponentModel.Container();
            this.txtboxIntensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDistribution = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxInterval = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.zedGraphEvol = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zedGraphEmp = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDisp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxIntensity
            // 
            this.txtboxIntensity.Location = new System.Drawing.Point(83, 16);
            this.txtboxIntensity.Name = "txtboxIntensity";
            this.txtboxIntensity.Size = new System.Drawing.Size(85, 20);
            this.txtboxIntensity.TabIndex = 0;
            this.txtboxIntensity.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Інтенсивність";
            // 
            // zedGraph
            // 
            this.zedGraph.AutoScroll = true;
            this.zedGraph.AutoSize = true;
            this.zedGraph.Location = new System.Drawing.Point(6, 19);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 10D;
            this.zedGraph.ScrollMaxX = 10D;
            this.zedGraph.ScrollMaxY = 10D;
            this.zedGraph.ScrollMaxY2 = 10D;
            this.zedGraph.ScrollMinX = 10D;
            this.zedGraph.ScrollMinY = 10D;
            this.zedGraph.ScrollMinY2 = 10D;
            this.zedGraph.Size = new System.Drawing.Size(485, 222);
            this.zedGraph.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.comboBoxDistribution);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtboxDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxInterval);
            this.groupBox1.Controls.Add(this.generatebtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxIntensity);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 151);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Умова моделювання";
            // 
            // comboBoxDistribution
            // 
            this.comboBoxDistribution.FormattingEnabled = true;
            this.comboBoxDistribution.Location = new System.Drawing.Point(9, 89);
            this.comboBoxDistribution.Name = "comboBoxDistribution";
            this.comboBoxDistribution.Size = new System.Drawing.Size(158, 21);
            this.comboBoxDistribution.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Тривалість";
            // 
            // txtboxDuration
            // 
            this.txtboxDuration.Location = new System.Drawing.Point(83, 63);
            this.txtboxDuration.Name = "txtboxDuration";
            this.txtboxDuration.Size = new System.Drawing.Size(85, 20);
            this.txtboxDuration.TabIndex = 41;
            this.txtboxDuration.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Інтервал";
            // 
            // txtboxInterval
            // 
            this.txtboxInterval.Location = new System.Drawing.Point(83, 39);
            this.txtboxInterval.Name = "txtboxInterval";
            this.txtboxInterval.Size = new System.Drawing.Size(85, 20);
            this.txtboxInterval.TabIndex = 39;
            this.txtboxInterval.Text = "1";
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.generatebtn.Location = new System.Drawing.Point(9, 115);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(158, 28);
            this.generatebtn.TabIndex = 38;
            this.generatebtn.Text = "Моделювати";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // zedGraphEvol
            // 
            this.zedGraphEvol.Location = new System.Drawing.Point(6, 247);
            this.zedGraphEvol.Name = "zedGraphEvol";
            this.zedGraphEvol.ScrollGrace = 0D;
            this.zedGraphEvol.ScrollMaxX = 0D;
            this.zedGraphEvol.ScrollMaxY = 0D;
            this.zedGraphEvol.ScrollMaxY2 = 0D;
            this.zedGraphEvol.ScrollMinX = 0D;
            this.zedGraphEvol.ScrollMinY = 0D;
            this.zedGraphEvol.ScrollMinY2 = 0D;
            this.zedGraphEvol.Size = new System.Drawing.Size(972, 244);
            this.zedGraphEvol.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Графік переходів і перебувань в станах";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Вигляд гіперболи залежної вид впливів процесу";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 126);
            this.dataGridView1.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(999, 702);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Пуассонівський процес";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.zedGraphEmp);
            this.groupBox3.Controls.Add(this.zedGraphEvol);
            this.groupBox3.Controls.Add(this.zedGraph);
            this.groupBox3.Location = new System.Drawing.Point(9, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 516);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Візуалізація процесу";
            // 
            // zedGraphEmp
            // 
            this.zedGraphEmp.Location = new System.Drawing.Point(495, 19);
            this.zedGraphEmp.Name = "zedGraphEmp";
            this.zedGraphEmp.ScrollGrace = 0D;
            this.zedGraphEmp.ScrollMaxX = 0D;
            this.zedGraphEmp.ScrollMaxY = 0D;
            this.zedGraphEmp.ScrollMaxY2 = 0D;
            this.zedGraphEmp.ScrollMinX = 0D;
            this.zedGraphEmp.ScrollMinY = 0D;
            this.zedGraphEmp.ScrollMinY2 = 0D;
            this.zedGraphEmp.Size = new System.Drawing.Size(483, 222);
            this.zedGraphEmp.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.lblDisp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblMS);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(196, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 151);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення процесу";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(10, 106);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 13);
            this.lblDisp.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Вибіркова дисперсія";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Вибіркове середнє";
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(10, 56);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(0, 13);
            this.lblMS.TabIndex = 40;
            // 
            // ProgramInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1013, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Name = "ProgramInterface";
            this.Text = "Моделюввання пуассонівського процесу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxIntensity;
        private System.Windows.Forms.Label label1;
        //Distributions combo
        private System.Windows.Forms.GroupBox groupBox1;
        // Distribution parameters

        private System.Windows.Forms.Label label6;

        //Transition Matrix
        private System.Windows.Forms.Label label12;
        // Buttons
        private System.Windows.Forms.Button generatebtn;
        // Table
        private System.Windows.Forms.DataGridView dataGridView1;
        // Graphics
        private ZedGraph.ZedGraphControl zedGraphEvol;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDuration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMS;
        private ZedGraph.ZedGraphControl zedGraphEmp;
        private System.Windows.Forms.ComboBox comboBoxDistribution;
    }
}

