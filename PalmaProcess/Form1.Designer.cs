namespace ProcessModeling
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRozpodilMinus = new System.Windows.Forms.ComboBox();
            this.comboBoxRozpodilPlus = new System.Windows.Forms.ComboBox();
            this.zedGraphPlus1 = new ZedGraph.ZedGraphControl();
            this.zedGraphMinus1 = new ZedGraph.ZedGraphControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPerehid = new System.Windows.Forms.ComboBox();
            this.groupBoxRozpodilMinus = new System.Windows.Forms.GroupBox();
            this.textBoxParamMinusB = new System.Windows.Forms.TextBox();
            this.textBoxParamMinusA = new System.Windows.Forms.TextBox();
            this.labelparamMinusB = new System.Windows.Forms.Label();
            this.labelparamMinusA = new System.Windows.Forms.Label();
            this.groupBoxStatPlus = new System.Windows.Forms.GroupBox();
            this.labelMatSpodPlus = new System.Windows.Forms.Label();
            this.labelSerPlus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRozpodilPlus = new System.Windows.Forms.GroupBox();
            this.labelParamPlusA = new System.Windows.Forms.Label();
            this.labelParamPlusB = new System.Windows.Forms.Label();
            this.textBoxParamPlusB = new System.Windows.Forms.TextBox();
            this.textBoxParamPlusA = new System.Windows.Forms.TextBox();
            this.zedGraphEvol = new ZedGraph.ZedGraphControl();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zedGraphNull = new ZedGraph.ZedGraphControl();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxParamNullB = new System.Windows.Forms.TextBox();
            this.textBoxParamNullA = new System.Windows.Forms.TextBox();
            this.labelparamNullB = new System.Windows.Forms.Label();
            this.labelparamNullA = new System.Windows.Forms.Label();
            this.comboBoxRozpodilNull = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrixPereh = new System.Windows.Forms.GroupBox();
            this.textBoxP32 = new System.Windows.Forms.TextBox();
            this.textBoxP33 = new System.Windows.Forms.TextBox();
            this.textBoxP22 = new System.Windows.Forms.TextBox();
            this.textBoxP13 = new System.Windows.Forms.TextBox();
            this.textBoxP23 = new System.Windows.Forms.TextBox();
            this.textBoxP12 = new System.Windows.Forms.TextBox();
            this.textBoxP31 = new System.Windows.Forms.TextBox();
            this.textBoxP21 = new System.Windows.Forms.TextBox();
            this.textBoxP11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.zedGraphPSO = new ZedGraph.ZedGraphControl();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.checkBoxSOP = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSerMinus = new System.Windows.Forms.Label();
            this.labelMatSpodMinus = new System.Windows.Forms.Label();
            this.groupBoxStatMinus = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxRozpodilMinus.SuspendLayout();
            this.groupBoxStatPlus.SuspendLayout();
            this.groupBoxRozpodilPlus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxMatrixPereh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStatMinus.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "50";
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "К-сть переходів";
            this.label1.Visible = false;
            // 
            // zedGraph
            // 
            this.zedGraph.AutoScroll = true;
            this.zedGraph.AutoSize = true;
            this.zedGraph.Location = new System.Drawing.Point(125, 157);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 10D;
            this.zedGraph.ScrollMaxX = 10D;
            this.zedGraph.ScrollMaxY = 10D;
            this.zedGraph.ScrollMaxY2 = 10D;
            this.zedGraph.ScrollMinX = 10D;
            this.zedGraph.ScrollMinY = 10D;
            this.zedGraph.ScrollMinY2 = 10D;
            this.zedGraph.Size = new System.Drawing.Size(854, 260);
            this.zedGraph.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Час моделювання";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Таблиця тривалості перебування в станах(відображає не більше перших 600 переходів" +
    ")";
            // 
            // comboBoxRozpodilMinus
            // 
            this.comboBoxRozpodilMinus.FormattingEnabled = true;
            this.comboBoxRozpodilMinus.Location = new System.Drawing.Point(3, 13);
            this.comboBoxRozpodilMinus.Name = "comboBoxRozpodilMinus";
            this.comboBoxRozpodilMinus.Size = new System.Drawing.Size(92, 21);
            this.comboBoxRozpodilMinus.TabIndex = 9;
            this.comboBoxRozpodilMinus.SelectedIndexChanged += new System.EventHandler(this.comboBoxRozpodilMinus_SelectedIndexChanged);
            // 
            // comboBoxRozpodilPlus
            // 
            this.comboBoxRozpodilPlus.FormattingEnabled = true;
            this.comboBoxRozpodilPlus.Location = new System.Drawing.Point(5, 15);
            this.comboBoxRozpodilPlus.Name = "comboBoxRozpodilPlus";
            this.comboBoxRozpodilPlus.Size = new System.Drawing.Size(90, 21);
            this.comboBoxRozpodilPlus.TabIndex = 10;
            this.comboBoxRozpodilPlus.SelectedIndexChanged += new System.EventHandler(this.comboBoxRozpodilPlus_SelectedIndexChanged);
            // 
            // zedGraphPlus1
            // 
            this.zedGraphPlus1.AutoScroll = true;
            this.zedGraphPlus1.AutoSize = true;
            this.zedGraphPlus1.Location = new System.Drawing.Point(5, 497);
            this.zedGraphPlus1.Name = "zedGraphPlus1";
            this.zedGraphPlus1.ScrollGrace = 0D;
            this.zedGraphPlus1.ScrollMaxX = 0D;
            this.zedGraphPlus1.ScrollMaxY = 0D;
            this.zedGraphPlus1.ScrollMaxY2 = 0D;
            this.zedGraphPlus1.ScrollMinX = 0D;
            this.zedGraphPlus1.ScrollMinY = 0D;
            this.zedGraphPlus1.ScrollMinY2 = 0D;
            this.zedGraphPlus1.Size = new System.Drawing.Size(220, 200);
            this.zedGraphPlus1.TabIndex = 14;
            // 
            // zedGraphMinus1
            // 
            this.zedGraphMinus1.AutoScroll = true;
            this.zedGraphMinus1.AutoSize = true;
            this.zedGraphMinus1.Location = new System.Drawing.Point(342, 165);
            this.zedGraphMinus1.Name = "zedGraphMinus1";
            this.zedGraphMinus1.ScrollGrace = 0D;
            this.zedGraphMinus1.ScrollMaxX = 0D;
            this.zedGraphMinus1.ScrollMaxY = 0D;
            this.zedGraphMinus1.ScrollMaxY2 = 0D;
            this.zedGraphMinus1.ScrollMinX = 0D;
            this.zedGraphMinus1.ScrollMinY = 0D;
            this.zedGraphMinus1.ScrollMinY2 = 0D;
            this.zedGraphMinus1.Size = new System.Drawing.Size(220, 200);
            this.zedGraphMinus1.TabIndex = 15;
            this.zedGraphMinus1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Мін";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxPerehid);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 151);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Умова моделювання";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Умова переходу";
            this.label4.Visible = false;
            // 
            // comboBoxPerehid
            // 
            this.comboBoxPerehid.FormattingEnabled = true;
            this.comboBoxPerehid.Items.AddRange(new object[] {
            "Послідовний (0,1,-1)",
            "Матриця переходів"});
            this.comboBoxPerehid.Location = new System.Drawing.Point(4, 125);
            this.comboBoxPerehid.Name = "comboBoxPerehid";
            this.comboBoxPerehid.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPerehid.TabIndex = 8;
            this.comboBoxPerehid.Visible = false;
            this.comboBoxPerehid.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerehid_SelectedIndexChanged);
            // 
            // groupBoxRozpodilMinus
            // 
            this.groupBoxRozpodilMinus.Controls.Add(this.textBoxParamMinusB);
            this.groupBoxRozpodilMinus.Controls.Add(this.textBoxParamMinusA);
            this.groupBoxRozpodilMinus.Controls.Add(this.labelparamMinusB);
            this.groupBoxRozpodilMinus.Controls.Add(this.labelparamMinusA);
            this.groupBoxRozpodilMinus.Controls.Add(this.comboBoxRozpodilMinus);
            this.groupBoxRozpodilMinus.Location = new System.Drawing.Point(6, 152);
            this.groupBoxRozpodilMinus.Name = "groupBoxRozpodilMinus";
            this.groupBoxRozpodilMinus.Size = new System.Drawing.Size(101, 120);
            this.groupBoxRozpodilMinus.TabIndex = 23;
            this.groupBoxRozpodilMinus.TabStop = false;
            this.groupBoxRozpodilMinus.Text = "Розподіл  -1";
            // 
            // textBoxParamMinusB
            // 
            this.textBoxParamMinusB.Location = new System.Drawing.Point(3, 91);
            this.textBoxParamMinusB.Name = "textBoxParamMinusB";
            this.textBoxParamMinusB.Size = new System.Drawing.Size(89, 20);
            this.textBoxParamMinusB.TabIndex = 13;
            this.textBoxParamMinusB.Text = "0";
            // 
            // textBoxParamMinusA
            // 
            this.textBoxParamMinusA.Location = new System.Drawing.Point(3, 51);
            this.textBoxParamMinusA.Name = "textBoxParamMinusA";
            this.textBoxParamMinusA.Size = new System.Drawing.Size(92, 20);
            this.textBoxParamMinusA.TabIndex = 12;
            this.textBoxParamMinusA.Text = "1";
            // 
            // labelparamMinusB
            // 
            this.labelparamMinusB.AutoSize = true;
            this.labelparamMinusB.Location = new System.Drawing.Point(7, 73);
            this.labelparamMinusB.Name = "labelparamMinusB";
            this.labelparamMinusB.Size = new System.Drawing.Size(65, 13);
            this.labelparamMinusB.TabIndex = 11;
            this.labelparamMinusB.Text = "параметр b";
            this.labelparamMinusB.Click += new System.EventHandler(this.labelparametrMinusB_Click);
            // 
            // labelparamMinusA
            // 
            this.labelparamMinusA.AutoSize = true;
            this.labelparamMinusA.Location = new System.Drawing.Point(7, 34);
            this.labelparamMinusA.Name = "labelparamMinusA";
            this.labelparamMinusA.Size = new System.Drawing.Size(65, 13);
            this.labelparamMinusA.TabIndex = 10;
            this.labelparamMinusA.Text = "параметр a";
            // 
            // groupBoxStatPlus
            // 
            this.groupBoxStatPlus.Controls.Add(this.labelMatSpodPlus);
            this.groupBoxStatPlus.Controls.Add(this.labelSerPlus);
            this.groupBoxStatPlus.Controls.Add(this.label5);
            this.groupBoxStatPlus.Controls.Add(this.label11);
            this.groupBoxStatPlus.Controls.Add(this.label10);
            this.groupBoxStatPlus.Location = new System.Drawing.Point(97, 404);
            this.groupBoxStatPlus.Name = "groupBoxStatPlus";
            this.groupBoxStatPlus.Size = new System.Drawing.Size(10, 120);
            this.groupBoxStatPlus.TabIndex = 25;
            this.groupBoxStatPlus.TabStop = false;
            this.groupBoxStatPlus.Text = "Стан +1";
            this.groupBoxStatPlus.Visible = false;
            // 
            // labelMatSpodPlus
            // 
            this.labelMatSpodPlus.AutoSize = true;
            this.labelMatSpodPlus.Location = new System.Drawing.Point(3, 25);
            this.labelMatSpodPlus.Name = "labelMatSpodPlus";
            this.labelMatSpodPlus.Size = new System.Drawing.Size(19, 13);
            this.labelMatSpodPlus.TabIndex = 23;
            this.labelMatSpodPlus.Text = "----";
            // 
            // labelSerPlus
            // 
            this.labelSerPlus.AutoSize = true;
            this.labelSerPlus.Location = new System.Drawing.Point(3, 43);
            this.labelSerPlus.Name = "labelSerPlus";
            this.labelSerPlus.Size = new System.Drawing.Size(35, 13);
            this.labelSerPlus.TabIndex = 22;
            this.labelSerPlus.Text = "label7";
            this.labelSerPlus.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-260, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // groupBoxRozpodilPlus
            // 
            this.groupBoxRozpodilPlus.Controls.Add(this.textBoxParamPlusB);
            this.groupBoxRozpodilPlus.Controls.Add(this.labelParamPlusA);
            this.groupBoxRozpodilPlus.Controls.Add(this.labelParamPlusB);
            this.groupBoxRozpodilPlus.Controls.Add(this.textBoxParamPlusA);
            this.groupBoxRozpodilPlus.Controls.Add(this.comboBoxRozpodilPlus);
            this.groupBoxRozpodilPlus.Location = new System.Drawing.Point(6, 297);
            this.groupBoxRozpodilPlus.Name = "groupBoxRozpodilPlus";
            this.groupBoxRozpodilPlus.Size = new System.Drawing.Size(100, 120);
            this.groupBoxRozpodilPlus.TabIndex = 26;
            this.groupBoxRozpodilPlus.TabStop = false;
            this.groupBoxRozpodilPlus.Text = "Розподіл +1";
            // 
            // labelParamPlusA
            // 
            this.labelParamPlusA.AutoSize = true;
            this.labelParamPlusA.Location = new System.Drawing.Point(7, 43);
            this.labelParamPlusA.Name = "labelParamPlusA";
            this.labelParamPlusA.Size = new System.Drawing.Size(65, 13);
            this.labelParamPlusA.TabIndex = 14;
            this.labelParamPlusA.Text = "параметр а";
            // 
            // labelParamPlusB
            // 
            this.labelParamPlusB.AutoSize = true;
            this.labelParamPlusB.Location = new System.Drawing.Point(6, 82);
            this.labelParamPlusB.Name = "labelParamPlusB";
            this.labelParamPlusB.Size = new System.Drawing.Size(65, 13);
            this.labelParamPlusB.TabIndex = 13;
            this.labelParamPlusB.Text = "параметр b";
            // 
            // textBoxParamPlusB
            // 
            this.textBoxParamPlusB.Location = new System.Drawing.Point(3, 96);
            this.textBoxParamPlusB.Name = "textBoxParamPlusB";
            this.textBoxParamPlusB.Size = new System.Drawing.Size(92, 20);
            this.textBoxParamPlusB.TabIndex = 12;
            this.textBoxParamPlusB.Text = "0";
            // 
            // textBoxParamPlusA
            // 
            this.textBoxParamPlusA.Location = new System.Drawing.Point(4, 59);
            this.textBoxParamPlusA.Name = "textBoxParamPlusA";
            this.textBoxParamPlusA.Size = new System.Drawing.Size(91, 20);
            this.textBoxParamPlusA.TabIndex = 11;
            this.textBoxParamPlusA.Text = "1";
            // 
            // zedGraphEvol
            // 
            this.zedGraphEvol.Location = new System.Drawing.Point(125, 444);
            this.zedGraphEvol.Name = "zedGraphEvol";
            this.zedGraphEvol.ScrollGrace = 0D;
            this.zedGraphEvol.ScrollMaxX = 0D;
            this.zedGraphEvol.ScrollMaxY = 0D;
            this.zedGraphEvol.ScrollMaxY2 = 0D;
            this.zedGraphEvol.ScrollMinX = 0D;
            this.zedGraphEvol.ScrollMinY = 0D;
            this.zedGraphEvol.ScrollMinY2 = 0D;
            this.zedGraphEvol.Size = new System.Drawing.Size(855, 260);
            this.zedGraphEvol.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Графік переходів і перебувань в станах";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.zedGraphPlus1);
            this.groupBox2.Location = new System.Drawing.Point(884, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(32, 704);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Розподіл часу перебування в станах";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "стан -1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "стан 0:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "стан +1:";
            // 
            // zedGraphNull
            // 
            this.zedGraphNull.Location = new System.Drawing.Point(617, 176);
            this.zedGraphNull.Name = "zedGraphNull";
            this.zedGraphNull.ScrollGrace = 0D;
            this.zedGraphNull.ScrollMaxX = 0D;
            this.zedGraphNull.ScrollMaxY = 0D;
            this.zedGraphNull.ScrollMaxY2 = 0D;
            this.zedGraphNull.ScrollMinX = 0D;
            this.zedGraphNull.ScrollMinY = 0D;
            this.zedGraphNull.ScrollMinY2 = 0D;
            this.zedGraphNull.Size = new System.Drawing.Size(220, 200);
            this.zedGraphNull.TabIndex = 16;
            this.zedGraphNull.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 714);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Процедура стохастичної оптимізації";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxParamNullB);
            this.groupBox3.Controls.Add(this.textBoxParamNullA);
            this.groupBox3.Controls.Add(this.labelparamNullB);
            this.groupBox3.Controls.Add(this.labelparamNullA);
            this.groupBox3.Controls.Add(this.comboBoxRozpodilNull);
            this.groupBox3.Location = new System.Drawing.Point(5, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 120);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Розподіл 0";
            this.groupBox3.Visible = false;
            // 
            // textBoxParamNullB
            // 
            this.textBoxParamNullB.Location = new System.Drawing.Point(5, 95);
            this.textBoxParamNullB.Name = "textBoxParamNullB";
            this.textBoxParamNullB.Size = new System.Drawing.Size(87, 20);
            this.textBoxParamNullB.TabIndex = 4;
            this.textBoxParamNullB.Text = "0";
            // 
            // textBoxParamNullA
            // 
            this.textBoxParamNullA.Location = new System.Drawing.Point(5, 59);
            this.textBoxParamNullA.Name = "textBoxParamNullA";
            this.textBoxParamNullA.Size = new System.Drawing.Size(88, 20);
            this.textBoxParamNullA.TabIndex = 3;
            this.textBoxParamNullA.Text = "1";
            // 
            // labelparamNullB
            // 
            this.labelparamNullB.AutoSize = true;
            this.labelparamNullB.Location = new System.Drawing.Point(7, 81);
            this.labelparamNullB.Name = "labelparamNullB";
            this.labelparamNullB.Size = new System.Drawing.Size(13, 13);
            this.labelparamNullB.TabIndex = 2;
            this.labelparamNullB.Text = "b";
            // 
            // labelparamNullA
            // 
            this.labelparamNullA.AutoSize = true;
            this.labelparamNullA.Location = new System.Drawing.Point(9, 45);
            this.labelparamNullA.Name = "labelparamNullA";
            this.labelparamNullA.Size = new System.Drawing.Size(13, 13);
            this.labelparamNullA.TabIndex = 1;
            this.labelparamNullA.Text = "a";
            // 
            // comboBoxRozpodilNull
            // 
            this.comboBoxRozpodilNull.FormattingEnabled = true;
            this.comboBoxRozpodilNull.Location = new System.Drawing.Point(4, 20);
            this.comboBoxRozpodilNull.Name = "comboBoxRozpodilNull";
            this.comboBoxRozpodilNull.Size = new System.Drawing.Size(96, 21);
            this.comboBoxRozpodilNull.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(97, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(10, 120);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Стан 0";
            this.groupBox4.Visible = false;
            // 
            // groupBoxMatrixPereh
            // 
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP32);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP33);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP22);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP13);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP23);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP12);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP31);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP21);
            this.groupBoxMatrixPereh.Controls.Add(this.groupBox3);
            this.groupBoxMatrixPereh.Controls.Add(this.textBoxP11);
            this.groupBoxMatrixPereh.Location = new System.Drawing.Point(6, 527);
            this.groupBoxMatrixPereh.Name = "groupBoxMatrixPereh";
            this.groupBoxMatrixPereh.Size = new System.Drawing.Size(113, 124);
            this.groupBoxMatrixPereh.TabIndex = 34;
            this.groupBoxMatrixPereh.TabStop = false;
            this.groupBoxMatrixPereh.Text = "Матриця переходів";
            this.groupBoxMatrixPereh.Visible = false;
            // 
            // textBoxP32
            // 
            this.textBoxP32.Location = new System.Drawing.Point(40, 95);
            this.textBoxP32.Name = "textBoxP32";
            this.textBoxP32.Size = new System.Drawing.Size(29, 20);
            this.textBoxP32.TabIndex = 8;
            this.textBoxP32.Text = "0";
            // 
            // textBoxP33
            // 
            this.textBoxP33.Location = new System.Drawing.Point(74, 95);
            this.textBoxP33.Name = "textBoxP33";
            this.textBoxP33.Size = new System.Drawing.Size(30, 20);
            this.textBoxP33.TabIndex = 7;
            this.textBoxP33.Text = "0";
            // 
            // textBoxP22
            // 
            this.textBoxP22.Location = new System.Drawing.Point(39, 59);
            this.textBoxP22.Name = "textBoxP22";
            this.textBoxP22.Size = new System.Drawing.Size(29, 20);
            this.textBoxP22.TabIndex = 6;
            this.textBoxP22.Text = "0";
            // 
            // textBoxP13
            // 
            this.textBoxP13.Location = new System.Drawing.Point(74, 24);
            this.textBoxP13.Name = "textBoxP13";
            this.textBoxP13.Size = new System.Drawing.Size(30, 20);
            this.textBoxP13.TabIndex = 5;
            this.textBoxP13.Text = "1";
            // 
            // textBoxP23
            // 
            this.textBoxP23.Location = new System.Drawing.Point(73, 59);
            this.textBoxP23.Name = "textBoxP23";
            this.textBoxP23.Size = new System.Drawing.Size(30, 20);
            this.textBoxP23.TabIndex = 4;
            this.textBoxP23.Text = "0";
            // 
            // textBoxP12
            // 
            this.textBoxP12.Location = new System.Drawing.Point(39, 24);
            this.textBoxP12.Name = "textBoxP12";
            this.textBoxP12.Size = new System.Drawing.Size(29, 20);
            this.textBoxP12.TabIndex = 3;
            this.textBoxP12.Text = "0";
            this.textBoxP12.TextChanged += new System.EventHandler(this.textBoxP12_TextChanged);
            // 
            // textBoxP31
            // 
            this.textBoxP31.Location = new System.Drawing.Point(2, 95);
            this.textBoxP31.Name = "textBoxP31";
            this.textBoxP31.Size = new System.Drawing.Size(30, 20);
            this.textBoxP31.TabIndex = 2;
            this.textBoxP31.Text = "1";
            // 
            // textBoxP21
            // 
            this.textBoxP21.Location = new System.Drawing.Point(3, 59);
            this.textBoxP21.Name = "textBoxP21";
            this.textBoxP21.Size = new System.Drawing.Size(29, 20);
            this.textBoxP21.TabIndex = 1;
            this.textBoxP21.Text = "0";
            // 
            // textBoxP11
            // 
            this.textBoxP11.Location = new System.Drawing.Point(3, 24);
            this.textBoxP11.Name = "textBoxP11";
            this.textBoxP11.Size = new System.Drawing.Size(29, 20);
            this.textBoxP11.TabIndex = 0;
            this.textBoxP11.Text = "0";
            this.textBoxP11.TextChanged += new System.EventHandler(this.textBoxP11_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Вигляд функції ln(u + x)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // zedGraphPSO
            // 
            this.zedGraphPSO.Location = new System.Drawing.Point(431, 701);
            this.zedGraphPSO.Name = "zedGraphPSO";
            this.zedGraphPSO.ScrollGrace = 0D;
            this.zedGraphPSO.ScrollMaxX = 0D;
            this.zedGraphPSO.ScrollMaxY = 0D;
            this.zedGraphPSO.ScrollMaxY2 = 0D;
            this.zedGraphPSO.ScrollMinX = 0D;
            this.zedGraphPSO.ScrollMinY = 0D;
            this.zedGraphPSO.ScrollMinY2 = 0D;
            this.zedGraphPSO.Size = new System.Drawing.Size(540, 10);
            this.zedGraphPSO.TabIndex = 36;
            this.zedGraphPSO.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 660);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 44);
            this.button3.TabIndex = 38;
            this.button3.Text = "Моделювати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 126);
            this.dataGridView1.TabIndex = 39;
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Location = new System.Drawing.Point(550, 695);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(421, 20);
            this.textBoxFunction.TabIndex = 40;
            this.textBoxFunction.Text = "(1/t)/(2*(1/t^(1/4)))*((u+(1/t^(1/4))+(x))^2-(u-(1/t^(1/4))+(x))^2)";
            this.textBoxFunction.Visible = false;
            // 
            // checkBoxSOP
            // 
            this.checkBoxSOP.AutoSize = true;
            this.checkBoxSOP.Location = new System.Drawing.Point(431, 694);
            this.checkBoxSOP.Name = "checkBoxSOP";
            this.checkBoxSOP.Size = new System.Drawing.Size(113, 17);
            this.checkBoxSOP.TabIndex = 41;
            this.checkBoxSOP.Text = "Реалізувати ПСО";
            this.checkBoxSOP.UseVisualStyleBackColor = true;
            this.checkBoxSOP.Visible = false;
            this.checkBoxSOP.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Min:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Max:";
            this.label9.Visible = false;
            // 
            // labelSerMinus
            // 
            this.labelSerMinus.AutoSize = true;
            this.labelSerMinus.Location = new System.Drawing.Point(3, 42);
            this.labelSerMinus.Name = "labelSerMinus";
            this.labelSerMinus.Size = new System.Drawing.Size(35, 13);
            this.labelSerMinus.TabIndex = 19;
            this.labelSerMinus.Text = "label7";
            this.labelSerMinus.Visible = false;
            // 
            // labelMatSpodMinus
            // 
            this.labelMatSpodMinus.AutoSize = true;
            this.labelMatSpodMinus.Location = new System.Drawing.Point(3, 25);
            this.labelMatSpodMinus.Name = "labelMatSpodMinus";
            this.labelMatSpodMinus.Size = new System.Drawing.Size(35, 13);
            this.labelMatSpodMinus.TabIndex = 20;
            this.labelMatSpodMinus.Text = "label7";
            // 
            // groupBoxStatMinus
            // 
            this.groupBoxStatMinus.Controls.Add(this.labelMatSpodMinus);
            this.groupBoxStatMinus.Controls.Add(this.labelSerMinus);
            this.groupBoxStatMinus.Controls.Add(this.label9);
            this.groupBoxStatMinus.Controls.Add(this.label8);
            this.groupBoxStatMinus.Location = new System.Drawing.Point(96, 151);
            this.groupBoxStatMinus.Name = "groupBoxStatMinus";
            this.groupBoxStatMinus.Size = new System.Drawing.Size(10, 120);
            this.groupBoxStatMinus.TabIndex = 24;
            this.groupBoxStatMinus.TabStop = false;
            this.groupBoxStatMinus.Text = "Стан -1";
            this.groupBoxStatMinus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 716);
            this.Controls.Add(this.groupBoxRozpodilPlus);
            this.Controls.Add(this.checkBoxSOP);
            this.Controls.Add(this.textBoxFunction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.zedGraphNull);
            this.Controls.Add(this.zedGraphPSO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.zedGraphMinus1);
            this.Controls.Add(this.groupBoxMatrixPereh);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zedGraphEvol);
            this.Controls.Add(this.groupBoxStatPlus);
            this.Controls.Add(this.groupBoxStatMinus);
            this.Controls.Add(this.groupBoxRozpodilMinus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Моделюввання потоку Пальма з 2-а станами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRozpodilMinus.ResumeLayout(false);
            this.groupBoxRozpodilMinus.PerformLayout();
            this.groupBoxStatPlus.ResumeLayout(false);
            this.groupBoxStatPlus.PerformLayout();
            this.groupBoxRozpodilPlus.ResumeLayout(false);
            this.groupBoxRozpodilPlus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxMatrixPereh.ResumeLayout(false);
            this.groupBoxMatrixPereh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStatMinus.ResumeLayout(false);
            this.groupBoxStatMinus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
     
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        //Distributions combo
        public System.Windows.Forms.ComboBox comboBoxRozpodilMinus;
        public System.Windows.Forms.ComboBox comboBoxRozpodilPlus;
        public System.Windows.Forms.ComboBox comboBoxRozpodilNull;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxRozpodilMinus;
        private System.Windows.Forms.GroupBox groupBoxStatPlus;
        private System.Windows.Forms.GroupBox groupBoxRozpodilPlus;
        // Distribution parameters
        public System.Windows.Forms.TextBox textBoxParamMinusB;
        public System.Windows.Forms.TextBox textBoxParamMinusA;
        private System.Windows.Forms.Label labelparamMinusB;
        private System.Windows.Forms.Label labelparamMinusA;
        public System.Windows.Forms.TextBox textBoxParamPlusA;
        public System.Windows.Forms.TextBox textBoxParamPlusB;
        private System.Windows.Forms.Label labelParamPlusA;
        private System.Windows.Forms.Label labelParamPlusB;
        private System.Windows.Forms.TextBox textBoxParamNullB;
        private System.Windows.Forms.TextBox textBoxParamNullA;
        private System.Windows.Forms.Label labelparamNullB;
        private System.Windows.Forms.Label labelparamNullA;
        private System.Windows.Forms.Label labelSerPlus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMatSpodPlus;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.GroupBox groupBox4;


        private System.Windows.Forms.GroupBox groupBoxMatrixPereh;
        
        //Transition Matrix
        public System.Windows.Forms.TextBox textBoxP12;
        public System.Windows.Forms.TextBox textBoxP31;
        public System.Windows.Forms.TextBox textBoxP21;
        public System.Windows.Forms.TextBox textBoxP11;
        public System.Windows.Forms.TextBox textBoxP32;
        public System.Windows.Forms.TextBox textBoxP33;
        public System.Windows.Forms.TextBox textBoxP22;
        public System.Windows.Forms.TextBox textBoxP13;
        public System.Windows.Forms.TextBox textBoxP23;

        private System.Windows.Forms.ComboBox comboBoxPerehid;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        // Buttons
        private System.Windows.Forms.Button button3;
        // Table
        private System.Windows.Forms.DataGridView dataGridView1;
        // Graphics
        private ZedGraph.ZedGraphControl zedGraphPSO;
        private ZedGraph.ZedGraphControl zedGraphNull;
        private ZedGraph.ZedGraphControl zedGraphPlus1;
        private ZedGraph.ZedGraphControl zedGraphMinus1;
        private ZedGraph.ZedGraphControl zedGraphEvol;
        private ZedGraph.ZedGraphControl zedGraph;
        
        public System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBoxSOP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSerMinus;
        private System.Windows.Forms.Label labelMatSpodMinus;
        private System.Windows.Forms.GroupBox groupBoxStatMinus;
    }
}

