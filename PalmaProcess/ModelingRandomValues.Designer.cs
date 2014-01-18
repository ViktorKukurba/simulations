namespace M2
{
    partial class ModelingRandomValues
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zedGraphRandomValues = new ZedGraph.ZedGraphControl();
            this.btnGenRndValues = new System.Windows.Forms.Button();
            this.IterAmount = new System.Windows.Forms.TextBox();
            this.lblIter = new System.Windows.Forms.Label();
            this.zedGraphKumulante = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1167, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // zedGraphRandomValues
            // 
            this.zedGraphRandomValues.Location = new System.Drawing.Point(12, 190);
            this.zedGraphRandomValues.Name = "zedGraphRandomValues";
            this.zedGraphRandomValues.ScrollGrace = 0D;
            this.zedGraphRandomValues.ScrollMaxX = 0D;
            this.zedGraphRandomValues.ScrollMaxY = 0D;
            this.zedGraphRandomValues.ScrollMaxY2 = 0D;
            this.zedGraphRandomValues.ScrollMinX = 0D;
            this.zedGraphRandomValues.ScrollMinY = 0D;
            this.zedGraphRandomValues.ScrollMinY2 = 0D;
            this.zedGraphRandomValues.Size = new System.Drawing.Size(1300, 213);
            this.zedGraphRandomValues.TabIndex = 37;
            // 
            // btnGenRndValues
            // 
            this.btnGenRndValues.Location = new System.Drawing.Point(12, 41);
            this.btnGenRndValues.Name = "btnGenRndValues";
            this.btnGenRndValues.Size = new System.Drawing.Size(125, 32);
            this.btnGenRndValues.TabIndex = 38;
            this.btnGenRndValues.Text = "Генерувати";
            this.btnGenRndValues.UseVisualStyleBackColor = true;
            this.btnGenRndValues.Click += new System.EventHandler(this.btnGenRndValues_Click);
            // 
            // IterAmount
            // 
            this.IterAmount.Location = new System.Drawing.Point(12, 21);
            this.IterAmount.Name = "IterAmount";
            this.IterAmount.Size = new System.Drawing.Size(125, 20);
            this.IterAmount.TabIndex = 39;
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Location = new System.Drawing.Point(12, 7);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(95, 13);
            this.lblIter.TabIndex = 40;
            this.lblIter.Text = "Кількість ітерацій";
            // 
            // zedGraphKumulante
            // 
            this.zedGraphKumulante.Location = new System.Drawing.Point(12, 406);
            this.zedGraphKumulante.Name = "zedGraphKumulante";
            this.zedGraphKumulante.ScrollGrace = 0D;
            this.zedGraphKumulante.ScrollMaxX = 0D;
            this.zedGraphKumulante.ScrollMaxY = 0D;
            this.zedGraphKumulante.ScrollMaxY2 = 0D;
            this.zedGraphKumulante.ScrollMinX = 0D;
            this.zedGraphKumulante.ScrollMinY = 0D;
            this.zedGraphKumulante.ScrollMinY2 = 0D;
            this.zedGraphKumulante.Size = new System.Drawing.Size(1300, 224);
            this.zedGraphKumulante.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Перевірка розподілу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 32);
            this.button2.TabIndex = 43;
            this.button2.Text = "Завантажити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 44;
            this.button3.Text = "Моделювання кінцевого етапу тестування";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ModelingRandomValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 632);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraphKumulante);
            this.Controls.Add(this.lblIter);
            this.Controls.Add(this.IterAmount);
            this.Controls.Add(this.btnGenRndValues);
            this.Controls.Add(this.zedGraphRandomValues);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModelingRandomValues";
            this.Text = "ModelingRandomValues";
            this.Load += new System.EventHandler(this.ModelingRandomValues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphRandomValues;
        private System.Windows.Forms.Button btnGenRndValues;
        private System.Windows.Forms.TextBox IterAmount;
        private System.Windows.Forms.Label lblIter;
        private ZedGraph.ZedGraphControl zedGraphKumulante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}