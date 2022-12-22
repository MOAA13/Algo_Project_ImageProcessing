namespace ImageFilters
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.maxWindowSize = new System.Windows.Forms.NumericUpDown();
            this.trimmingValue = new System.Windows.Forms.NumericUpDown();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lbl_filter = new System.Windows.Forms.Label();
            this.lbl_algorithm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimmingValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 846);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(34, 881);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(230, 120);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnZGraph
            // 
            this.btnZGraph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.Location = new System.Drawing.Point(1716, 881);
            this.btnZGraph.Margin = new System.Windows.Forms.Padding(6);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(230, 120);
            this.btnZGraph.TabIndex = 3;
            this.btnZGraph.Text = "Z Graph Example";
            this.btnZGraph.UseVisualStyleBackColor = true;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1126, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1090, 846);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Alpha Trim",
            "Adaptive Median"});
            this.cbFilter.Location = new System.Drawing.Point(561, 888);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(328, 43);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(943, 893);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wmax";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1008, 957);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "T";
            this.label2.Visible = false;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(1475, 881);
            this.btnGen.Margin = new System.Windows.Forms.Padding(6);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(230, 120);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "Generate Image";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // maxWindowSize
            // 
            this.maxWindowSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWindowSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxWindowSize.Location = new System.Drawing.Point(1051, 889);
            this.maxWindowSize.Margin = new System.Windows.Forms.Padding(6);
            this.maxWindowSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.maxWindowSize.Name = "maxWindowSize";
            this.maxWindowSize.Size = new System.Drawing.Size(240, 40);
            this.maxWindowSize.TabIndex = 15;
            this.maxWindowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.maxWindowSize.Visible = false;
            this.maxWindowSize.ValueChanged += new System.EventHandler(this.maxWindowSize_ValueChanged);
            // 
            // trimmingValue
            // 
            this.trimmingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trimmingValue.Location = new System.Drawing.Point(1051, 953);
            this.trimmingValue.Margin = new System.Windows.Forms.Padding(6);
            this.trimmingValue.Name = "trimmingValue";
            this.trimmingValue.Size = new System.Drawing.Size(240, 40);
            this.trimmingValue.TabIndex = 16;
            this.trimmingValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trimmingValue.Visible = false;
            this.trimmingValue.ValueChanged += new System.EventHandler(this.trimmingValue_ValueChanged);
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Location = new System.Drawing.Point(561, 952);
            this.cbAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(328, 43);
            this.cbAlgorithm.TabIndex = 17;
            this.cbAlgorithm.Visible = false;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbAlgorithm_SelectedIndexChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.AutoSize = true;
            this.lbl_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filter.Location = new System.Drawing.Point(341, 893);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(212, 33);
            this.lbl_filter.TabIndex = 18;
            this.lbl_filter.Text = "Selecterd Filter";
            // 
            // lbl_algorithm
            // 
            this.lbl_algorithm.AutoSize = true;
            this.lbl_algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_algorithm.Location = new System.Drawing.Point(338, 957);
            this.lbl_algorithm.Name = "lbl_algorithm";
            this.lbl_algorithm.Size = new System.Drawing.Size(215, 33);
            this.lbl_algorithm.TabIndex = 19;
            this.lbl_algorithm.Text = "Used Algorithm";
            this.lbl_algorithm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2238, 1065);
            this.Controls.Add(this.lbl_algorithm);
            this.Controls.Add(this.lbl_filter);
            this.Controls.Add(this.cbAlgorithm);
            this.Controls.Add(this.trimmingValue);
            this.Controls.Add(this.maxWindowSize);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Image Filters...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimmingValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.NumericUpDown maxWindowSize;
        private System.Windows.Forms.NumericUpDown trimmingValue;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.Label lbl_filter;
        private System.Windows.Forms.Label lbl_algorithm;
    }
}

