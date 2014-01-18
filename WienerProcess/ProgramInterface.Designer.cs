namespace WiennerProcess
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
            this.txtboxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zedXGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDuration = new System.Windows.Forms.TextBox();
            this.modelbtn = new System.Windows.Forms.Button();
            this.zedYGraph = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zedWienerGraph = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblMatSpod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxRadius
            // 
            this.txtboxRadius.Location = new System.Drawing.Point(9, 32);
            this.txtboxRadius.Name = "txtboxRadius";
            this.txtboxRadius.Size = new System.Drawing.Size(158, 20);
            this.txtboxRadius.TabIndex = 0;
            this.txtboxRadius.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Радіус зміщення";
            // 
            // zedXGraph
            // 
            this.zedXGraph.AutoScroll = true;
            this.zedXGraph.AutoSize = true;
            this.zedXGraph.Location = new System.Drawing.Point(6, 19);
            this.zedXGraph.Name = "zedXGraph";
            this.zedXGraph.ScrollGrace = 10D;
            this.zedXGraph.ScrollMaxX = 10D;
            this.zedXGraph.ScrollMaxY = 10D;
            this.zedXGraph.ScrollMaxY2 = 10D;
            this.zedXGraph.ScrollMinX = 10D;
            this.zedXGraph.ScrollMinY = 10D;
            this.zedXGraph.ScrollMinY2 = 10D;
            this.zedXGraph.Size = new System.Drawing.Size(542, 222);
            this.zedXGraph.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtboxDuration);
            this.groupBox1.Controls.Add(this.modelbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxRadius);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 151);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Умова моделювання";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Тривалість";
            // 
            // txtboxDuration
            // 
            this.txtboxDuration.Location = new System.Drawing.Point(10, 79);
            this.txtboxDuration.Name = "txtboxDuration";
            this.txtboxDuration.Size = new System.Drawing.Size(158, 20);
            this.txtboxDuration.TabIndex = 41;
            this.txtboxDuration.Text = "200";
            // 
            // modelbtn
            // 
            this.modelbtn.BackColor = System.Drawing.Color.Silver;
            this.modelbtn.Location = new System.Drawing.Point(10, 107);
            this.modelbtn.Name = "modelbtn";
            this.modelbtn.Size = new System.Drawing.Size(158, 33);
            this.modelbtn.TabIndex = 38;
            this.modelbtn.Text = "Моделювати";
            this.modelbtn.UseVisualStyleBackColor = false;
            this.modelbtn.Click += new System.EventHandler(this.modelbtn_Click);
            // 
            // zedYGraph
            // 
            this.zedYGraph.Location = new System.Drawing.Point(6, 247);
            this.zedYGraph.Name = "zedYGraph";
            this.zedYGraph.ScrollGrace = 0D;
            this.zedYGraph.ScrollMaxX = 0D;
            this.zedYGraph.ScrollMaxY = 0D;
            this.zedYGraph.ScrollMaxY2 = 0D;
            this.zedYGraph.ScrollMinX = 0D;
            this.zedYGraph.ScrollMinY = 0D;
            this.zedYGraph.ScrollMinY2 = 0D;
            this.zedYGraph.Size = new System.Drawing.Size(542, 244);
            this.zedYGraph.TabIndex = 28;
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 125);
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
            this.groupBox4.Size = new System.Drawing.Size(1099, 702);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вінерівський процес";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.zedWienerGraph);
            this.groupBox3.Controls.Add(this.zedYGraph);
            this.groupBox3.Controls.Add(this.zedXGraph);
            this.groupBox3.Location = new System.Drawing.Point(9, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1084, 523);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Візуалізація процесу";
            // 
            // zedWienerGraph
            // 
            this.zedWienerGraph.Location = new System.Drawing.Point(554, 19);
            this.zedWienerGraph.Name = "zedWienerGraph";
            this.zedWienerGraph.ScrollGrace = 0D;
            this.zedWienerGraph.ScrollMaxX = 0D;
            this.zedWienerGraph.ScrollMaxY = 0D;
            this.zedWienerGraph.ScrollMaxY2 = 0D;
            this.zedWienerGraph.ScrollMinX = 0D;
            this.zedWienerGraph.ScrollMinY = 0D;
            this.zedWienerGraph.ScrollMinY2 = 0D;
            this.zedWienerGraph.Size = new System.Drawing.Size(524, 472);
            this.zedWienerGraph.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(196, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 151);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення процесу";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblMin);
            this.panel2.Controls.Add(this.lblMax);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(774, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 70);
            this.panel2.TabIndex = 41;
            this.panel2.Visible = false;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(6, 49);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 13);
            this.lblMin.TabIndex = 3;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(4, 19);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 13);
            this.lblMax.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Макс. значення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Мін. значення";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDisp);
            this.panel1.Controls.Add(this.lblMatSpod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(774, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 70);
            this.panel1.TabIndex = 40;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дисперсія";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(6, 52);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 13);
            this.lblDisp.TabIndex = 1;
            // 
            // lblMatSpod
            // 
            this.lblMatSpod.AutoSize = true;
            this.lblMatSpod.Location = new System.Drawing.Point(6, 19);
            this.lblMatSpod.Name = "lblMatSpod";
            this.lblMatSpod.Size = new System.Drawing.Size(0, 13);
            this.lblMatSpod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Мат. сподівання";
            // 
            // ProgramInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1123, 716);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Name = "ProgramInterface";
            this.Text = "Моделюввання вінерівського процесу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxRadius;
        private System.Windows.Forms.Label label1;
        //Distributions combo
        private System.Windows.Forms.GroupBox groupBox1;
        // Distribution parameters

        private System.Windows.Forms.Label label6;

        //Transition Matrix
        private System.Windows.Forms.Label label12;
        // Buttons
        private System.Windows.Forms.Button modelbtn;
        // Table
        private System.Windows.Forms.DataGridView dataGridView1;
        // Graphics
        private ZedGraph.ZedGraphControl zedYGraph;
        private ZedGraph.ZedGraphControl zedXGraph;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDuration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedWienerGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMatSpod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

