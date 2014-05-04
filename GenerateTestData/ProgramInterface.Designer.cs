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
            this.label12 = new System.Windows.Forms.Label();
            this.tabTestModel = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblModelAlpha = new System.Windows.Forms.Label();
            this.lblModelBeta = new System.Windows.Forms.Label();
            this.lblModelS = new System.Windows.Forms.Label();
            this.lblModelTotal = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabGenerate = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxIntensity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generatebtn = new System.Windows.Forms.Button();
            this.txtboxInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDistribution = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.zedGraphEvol = new ZedGraph.ZedGraphControl();
            this.zedGraphEmp = new ZedGraph.ZedGraphControl();
            this.appTabs = new System.Windows.Forms.TabControl();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.groupBoxSOP = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSopA = new System.Windows.Forms.TextBox();
            this.txtSopB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSOP = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblSOPTotal = new System.Windows.Forms.Label();
            this.lblSOPS = new System.Windows.Forms.Label();
            this.progressBarSOP = new System.Windows.Forms.ProgressBar();
            this.lblSOPStatus = new System.Windows.Forms.Label();
            this.tabTestModel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabGenerate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.appTabs.SuspendLayout();
            this.groupBoxModel.SuspendLayout();
            this.groupBoxSOP.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
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
            // tabTestModel
            // 
            this.tabTestModel.Controls.Add(this.groupBoxSOP);
            this.tabTestModel.Controls.Add(this.groupBoxModel);
            this.tabTestModel.Location = new System.Drawing.Point(4, 22);
            this.tabTestModel.Name = "tabTestModel";
            this.tabTestModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestModel.Size = new System.Drawing.Size(1003, 687);
            this.tabTestModel.TabIndex = 1;
            this.tabTestModel.Text = "Модель тестування";
            this.tabTestModel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtS);
            this.groupBox5.Controls.Add(this.txtBeta);
            this.groupBox5.Controls.Add(this.txtAlpha);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btnModel);
            this.groupBox5.Location = new System.Drawing.Point(23, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 162);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Початкові значення";
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(9, 128);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(104, 28);
            this.btnModel.TabIndex = 44;
            this.btnModel.Text = "Модель";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Visible = false;
            this.btnModel.Click += new System.EventHandler(this.Model_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "alpha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "beta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "s";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(45, 29);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(100, 20);
            this.txtAlpha.TabIndex = 48;
            this.txtAlpha.Text = "65";
            // 
            // txtBeta
            // 
            this.txtBeta.Location = new System.Drawing.Point(45, 60);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(100, 20);
            this.txtBeta.TabIndex = 49;
            this.txtBeta.Text = "0,01";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(45, 93);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 50;
            this.txtS.Text = "0,08";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblModelTotal);
            this.groupBox6.Controls.Add(this.lblModelS);
            this.groupBox6.Controls.Add(this.lblModelBeta);
            this.groupBox6.Controls.Add(this.lblModelAlpha);
            this.groupBox6.Location = new System.Drawing.Point(241, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 161);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Значення моделі";
            // 
            // lblModelAlpha
            // 
            this.lblModelAlpha.AutoSize = true;
            this.lblModelAlpha.Location = new System.Drawing.Point(13, 29);
            this.lblModelAlpha.Name = "lblModelAlpha";
            this.lblModelAlpha.Size = new System.Drawing.Size(33, 13);
            this.lblModelAlpha.TabIndex = 46;
            this.lblModelAlpha.Text = "alpha";
            // 
            // lblModelBeta
            // 
            this.lblModelBeta.AutoSize = true;
            this.lblModelBeta.Location = new System.Drawing.Point(13, 60);
            this.lblModelBeta.Name = "lblModelBeta";
            this.lblModelBeta.Size = new System.Drawing.Size(28, 13);
            this.lblModelBeta.TabIndex = 47;
            this.lblModelBeta.Text = "beta";
            // 
            // lblModelS
            // 
            this.lblModelS.AutoSize = true;
            this.lblModelS.Location = new System.Drawing.Point(13, 93);
            this.lblModelS.Name = "lblModelS";
            this.lblModelS.Size = new System.Drawing.Size(12, 13);
            this.lblModelS.TabIndex = 48;
            this.lblModelS.Text = "s";
            // 
            // lblModelTotal
            // 
            this.lblModelTotal.AutoSize = true;
            this.lblModelTotal.Location = new System.Drawing.Point(13, 128);
            this.lblModelTotal.Name = "lblModelTotal";
            this.lblModelTotal.Size = new System.Drawing.Size(31, 13);
            this.lblModelTotal.TabIndex = 49;
            this.lblModelTotal.Text = "Total";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 27);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(207, 23);
            this.progressBar.TabIndex = 47;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(238, 37);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 50;
            // 
            // tabGenerate
            // 
            this.tabGenerate.Controls.Add(this.groupBox4);
            this.tabGenerate.Location = new System.Drawing.Point(4, 22);
            this.tabGenerate.Name = "tabGenerate";
            this.tabGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerate.Size = new System.Drawing.Size(1003, 687);
            this.tabGenerate.TabIndex = 0;
            this.tabGenerate.Text = "Моделювання процесу тестування";
            this.tabGenerate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(999, 702);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Процес тестування";
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
            // txtboxIntensity
            // 
            this.txtboxIntensity.Location = new System.Drawing.Point(83, 16);
            this.txtboxIntensity.Name = "txtboxIntensity";
            this.txtboxIntensity.Size = new System.Drawing.Size(85, 20);
            this.txtboxIntensity.TabIndex = 0;
            this.txtboxIntensity.Text = "10";
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
            // txtboxInterval
            // 
            this.txtboxInterval.Location = new System.Drawing.Point(83, 39);
            this.txtboxInterval.Name = "txtboxInterval";
            this.txtboxInterval.Size = new System.Drawing.Size(85, 20);
            this.txtboxInterval.TabIndex = 39;
            this.txtboxInterval.Text = "1";
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
            // txtboxDuration
            // 
            this.txtboxDuration.Location = new System.Drawing.Point(83, 63);
            this.txtboxDuration.Name = "txtboxDuration";
            this.txtboxDuration.Size = new System.Drawing.Size(85, 20);
            this.txtboxDuration.TabIndex = 41;
            this.txtboxDuration.Text = "120";
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
            // comboBoxDistribution
            // 
            this.comboBoxDistribution.FormattingEnabled = true;
            this.comboBoxDistribution.Location = new System.Drawing.Point(9, 89);
            this.comboBoxDistribution.Name = "comboBoxDistribution";
            this.comboBoxDistribution.Size = new System.Drawing.Size(158, 21);
            this.comboBoxDistribution.TabIndex = 43;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 126);
            this.dataGridView1.TabIndex = 39;
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(10, 56);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(0, 13);
            this.lblMS.TabIndex = 40;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Вибіркова дисперсія";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(10, 106);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 13);
            this.lblDisp.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.zedGraphEmp);
            this.groupBox3.Controls.Add(this.zedGraphEvol);
            this.groupBox3.Controls.Add(this.zedGraph);
            this.groupBox3.Location = new System.Drawing.Point(9, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 502);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Візуалізація процесу";
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
            // appTabs
            // 
            this.appTabs.Controls.Add(this.tabGenerate);
            this.appTabs.Controls.Add(this.tabTestModel);
            this.appTabs.Location = new System.Drawing.Point(0, 3);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(1011, 713);
            this.appTabs.TabIndex = 41;
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.groupBox6);
            this.groupBoxModel.Controls.Add(this.lblStatus);
            this.groupBoxModel.Controls.Add(this.groupBox5);
            this.groupBoxModel.Controls.Add(this.progressBar);
            this.groupBoxModel.Location = new System.Drawing.Point(6, 6);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Size = new System.Drawing.Size(991, 229);
            this.groupBoxModel.TabIndex = 51;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Розвязок моделі";
            // 
            // groupBoxSOP
            // 
            this.groupBoxSOP.Controls.Add(this.lblSOPStatus);
            this.groupBoxSOP.Controls.Add(this.progressBarSOP);
            this.groupBoxSOP.Controls.Add(this.groupBox8);
            this.groupBoxSOP.Controls.Add(this.groupBox7);
            this.groupBoxSOP.Location = new System.Drawing.Point(6, 241);
            this.groupBoxSOP.Name = "groupBoxSOP";
            this.groupBoxSOP.Size = new System.Drawing.Size(991, 191);
            this.groupBoxSOP.TabIndex = 52;
            this.groupBoxSOP.TabStop = false;
            this.groupBoxSOP.Text = "Оптимізація моделі тестування";
            this.groupBoxSOP.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSOP);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtSopB);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txtSopA);
            this.groupBox7.Location = new System.Drawing.Point(23, 55);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 130);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Параметри";
            // 
            // txtSopA
            // 
            this.txtSopA.Location = new System.Drawing.Point(45, 19);
            this.txtSopA.Name = "txtSopA";
            this.txtSopA.Size = new System.Drawing.Size(100, 20);
            this.txtSopA.TabIndex = 0;
            this.txtSopA.Text = "1";
            // 
            // txtSopB
            // 
            this.txtSopB.Location = new System.Drawing.Point(45, 50);
            this.txtSopB.Name = "txtSopB";
            this.txtSopB.Size = new System.Drawing.Size(100, 20);
            this.txtSopB.TabIndex = 1;
            this.txtSopB.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "b";
            // 
            // btnSOP
            // 
            this.btnSOP.Location = new System.Drawing.Point(9, 78);
            this.btnSOP.Name = "btnSOP";
            this.btnSOP.Size = new System.Drawing.Size(104, 27);
            this.btnSOP.TabIndex = 1;
            this.btnSOP.Text = "Процедура";
            this.btnSOP.UseVisualStyleBackColor = true;
            this.btnSOP.Click += new System.EventHandler(this.btnSOP_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblSOPTotal);
            this.groupBox8.Controls.Add(this.lblSOPS);
            this.groupBox8.Location = new System.Drawing.Point(241, 55);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(274, 130);
            this.groupBox8.TabIndex = 47;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Значення процедури";
            // 
            // lblSOPTotal
            // 
            this.lblSOPTotal.AutoSize = true;
            this.lblSOPTotal.Location = new System.Drawing.Point(13, 53);
            this.lblSOPTotal.Name = "lblSOPTotal";
            this.lblSOPTotal.Size = new System.Drawing.Size(31, 13);
            this.lblSOPTotal.TabIndex = 49;
            this.lblSOPTotal.Text = "Total";
            // 
            // lblSOPS
            // 
            this.lblSOPS.AutoSize = true;
            this.lblSOPS.Location = new System.Drawing.Point(13, 18);
            this.lblSOPS.Name = "lblSOPS";
            this.lblSOPS.Size = new System.Drawing.Size(12, 13);
            this.lblSOPS.TabIndex = 48;
            this.lblSOPS.Text = "s";
            // 
            // progressBarSOP
            // 
            this.progressBarSOP.Location = new System.Drawing.Point(23, 19);
            this.progressBarSOP.Name = "progressBarSOP";
            this.progressBarSOP.Size = new System.Drawing.Size(207, 23);
            this.progressBarSOP.TabIndex = 48;
            // 
            // lblSOPStatus
            // 
            this.lblSOPStatus.AutoSize = true;
            this.lblSOPStatus.Location = new System.Drawing.Point(238, 29);
            this.lblSOPStatus.Name = "lblSOPStatus";
            this.lblSOPStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSOPStatus.TabIndex = 51;
            // 
            // ProgramInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1013, 716);
            this.Controls.Add(this.appTabs);
            this.Controls.Add(this.label12);
            this.Name = "ProgramInterface";
            this.Text = "Дослідження процесу тестування";
            this.tabTestModel.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabGenerate.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.appTabs.ResumeLayout(false);
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxModel.PerformLayout();
            this.groupBoxSOP.ResumeLayout(false);
            this.groupBoxSOP.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Distributions combo
        // Distribution parameters

        //Transition Matrix
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabTestModel;
        private System.Windows.Forms.GroupBox groupBoxSOP;
        private System.Windows.Forms.GroupBox groupBoxModel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblModelTotal;
        private System.Windows.Forms.Label lblModelS;
        private System.Windows.Forms.Label lblModelBeta;
        private System.Windows.Forms.Label lblModelAlpha;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabPage tabGenerate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private ZedGraph.ZedGraphControl zedGraphEmp;
        private ZedGraph.ZedGraphControl zedGraphEvol;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDistribution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxInterval;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIntensity;
        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.ProgressBar progressBarSOP;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblSOPTotal;
        private System.Windows.Forms.Label lblSOPS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSOP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSopB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSopA;
        private System.Windows.Forms.Label lblSOPStatus;
        // Buttons
        // Table
        // Graphics
    }
}

