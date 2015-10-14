namespace LotkaVolterra
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
            this.txtboxStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtCx = new System.Windows.Forms.TextBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.generatebtn = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graphPN = new ZedGraph.ZedGraphControl();
            this.zedGraphProcess = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxJ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxStart
            // 
            this.txtboxStart.Location = new System.Drawing.Point(54, 16);
            this.txtboxStart.Name = "txtboxStart";
            this.txtboxStart.Size = new System.Drawing.Size(36, 20);
            this.txtboxStart.TabIndex = 0;
            this.txtboxStart.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Початок";
            // 
            // zedGraph
            // 
            this.zedGraph.AutoScroll = true;
            this.zedGraph.AutoSize = true;
            this.zedGraph.Location = new System.Drawing.Point(10, 16);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 10D;
            this.zedGraph.ScrollMaxX = 10D;
            this.zedGraph.ScrollMaxY = 10D;
            this.zedGraph.ScrollMaxY2 = 10D;
            this.zedGraph.ScrollMinX = 10D;
            this.zedGraph.ScrollMinY = 10D;
            this.zedGraph.ScrollMinY2 = 10D;
            this.zedGraph.Size = new System.Drawing.Size(652, 252);
            this.zedGraph.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBoxJ);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDx);
            this.groupBox1.Controls.Add(this.txtCx);
            this.groupBox1.Controls.Add(this.txtBx);
            this.groupBox1.Controls.Add(this.txtAx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAlpha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.generatebtn);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxStart);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри моделювання";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(305, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "d(x)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(305, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "c(x)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "a(x)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "b(x)";
            // 
            // txtDx
            // 
            this.txtDx.Location = new System.Drawing.Point(335, 45);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(35, 20);
            this.txtDx.TabIndex = 62;
            this.txtDx.Text = "-0,2";
            // 
            // txtCx
            // 
            this.txtCx.Location = new System.Drawing.Point(335, 16);
            this.txtCx.Name = "txtCx";
            this.txtCx.Size = new System.Drawing.Size(35, 20);
            this.txtCx.TabIndex = 61;
            this.txtCx.Text = "0,5";
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(200, 42);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(35, 20);
            this.txtBx.TabIndex = 60;
            this.txtBx.Text = "-0,3";
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(200, 16);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(35, 20);
            this.txtAx.TabIndex = 59;
            this.txtAx.Text = "0,5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(180, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "A";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(200, 71);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(35, 20);
            this.txtAlpha.TabIndex = 55;
            this.txtAlpha.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "N(0)";
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generatebtn.Location = new System.Drawing.Point(308, 70);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(59, 39);
            this.generatebtn.TabIndex = 38;
            this.generatebtn.Text = "Моделювати";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(131, 71);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(36, 20);
            this.textBoxN.TabIndex = 53;
            this.textBoxN.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "P(0)";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(54, 71);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(36, 20);
            this.textBoxP.TabIndex = 51;
            this.textBoxP.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "d";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(264, 42);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(35, 20);
            this.textBoxD.TabIndex = 49;
            this.textBoxD.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "c";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(264, 16);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(35, 20);
            this.textBoxC.TabIndex = 47;
            this.textBoxC.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(132, 42);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(35, 20);
            this.textBoxB.TabIndex = 45;
            this.textBoxB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "a";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(132, 16);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(35, 20);
            this.textBoxA.TabIndex = 43;
            this.textBoxA.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Кінець";
            // 
            // txtboxEnd
            // 
            this.txtboxEnd.Location = new System.Drawing.Point(54, 42);
            this.txtboxEnd.Name = "txtboxEnd";
            this.txtboxEnd.Size = new System.Drawing.Size(36, 20);
            this.txtboxEnd.TabIndex = 39;
            this.txtboxEnd.Text = "50";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 96);
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
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.graphPN);
            this.groupBox3.Controls.Add(this.zedGraphProcess);
            this.groupBox3.Controls.Add(this.zedGraph);
            this.groupBox3.Location = new System.Drawing.Point(9, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 552);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Візуалізація моделювання";
            // 
            // graphPN
            // 
            this.graphPN.AutoScroll = true;
            this.graphPN.AutoSize = true;
            this.graphPN.Location = new System.Drawing.Point(668, 16);
            this.graphPN.Name = "graphPN";
            this.graphPN.ScrollGrace = 10D;
            this.graphPN.ScrollMaxX = 10D;
            this.graphPN.ScrollMaxY = 10D;
            this.graphPN.ScrollMaxY2 = 10D;
            this.graphPN.ScrollMinX = 10D;
            this.graphPN.ScrollMinY = 10D;
            this.graphPN.ScrollMinY2 = 10D;
            this.graphPN.Size = new System.Drawing.Size(310, 252);
            this.graphPN.TabIndex = 4;
            // 
            // zedGraphProcess
            // 
            this.zedGraphProcess.AutoScroll = true;
            this.zedGraphProcess.AutoSize = true;
            this.zedGraphProcess.Location = new System.Drawing.Point(10, 274);
            this.zedGraphProcess.Name = "zedGraphProcess";
            this.zedGraphProcess.ScrollGrace = 10D;
            this.zedGraphProcess.ScrollMaxX = 10D;
            this.zedGraphProcess.ScrollMaxY = 10D;
            this.zedGraphProcess.ScrollMaxY2 = 10D;
            this.zedGraphProcess.ScrollMinX = 10D;
            this.zedGraphProcess.ScrollMinY = 10D;
            this.zedGraphProcess.ScrollMinY2 = 10D;
            this.zedGraphProcess.Size = new System.Drawing.Size(968, 252);
            this.zedGraphProcess.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(388, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 115);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення моделі";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(9, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "j";
            // 
            // textBoxJ
            // 
            this.textBoxJ.Location = new System.Drawing.Point(264, 70);
            this.textBoxJ.Name = "textBoxJ";
            this.textBoxJ.Size = new System.Drawing.Size(35, 20);
            this.textBoxJ.TabIndex = 67;
            this.textBoxJ.Text = "0";
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
            this.Text = "Модель Лотки-Вольтерра";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxStart;
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
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEnd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxP;
        private ZedGraph.ZedGraphControl zedGraphProcess;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtCx;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtAx;
        private ZedGraph.ZedGraphControl graphPN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxJ;
    }
}

