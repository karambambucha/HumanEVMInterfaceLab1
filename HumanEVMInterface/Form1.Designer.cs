namespace HumanEVMInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProbabilityMatrixDataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Routes1NumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RouteLengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SubthemeProbablityNumeric = new System.Windows.Forms.NumericUpDown();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.MistakeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MistakeProbabilityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectionSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.StepTimesDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ProbabilityMatrixDataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Routes2NumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.RouteProbablityDataGrid1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.RouteProbablityDataGrid2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes1NumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubthemeProbablityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MistakeProbabilityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes2NumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteProbablityDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteProbablityDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProbabilityMatrixDataGridView1
            // 
            this.ProbabilityMatrixDataGridView1.AllowUserToAddRows = false;
            this.ProbabilityMatrixDataGridView1.AllowUserToDeleteRows = false;
            this.ProbabilityMatrixDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProbabilityMatrixDataGridView1.Location = new System.Drawing.Point(305, 25);
            this.ProbabilityMatrixDataGridView1.Name = "ProbabilityMatrixDataGridView1";
            this.ProbabilityMatrixDataGridView1.Size = new System.Drawing.Size(238, 187);
            this.ProbabilityMatrixDataGridView1.TabIndex = 0;
            this.ProbabilityMatrixDataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ProbabilityMatrixDataGridView_EditingControlShowing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Матрица маршрутов 1 подтемы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество маршрутов 1 подтемы";
            // 
            // Routes1NumberNumeric
            // 
            this.Routes1NumberNumeric.Location = new System.Drawing.Point(12, 32);
            this.Routes1NumberNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Routes1NumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Routes1NumberNumeric.Name = "Routes1NumberNumeric";
            this.Routes1NumberNumeric.Size = new System.Drawing.Size(120, 20);
            this.Routes1NumberNumeric.TabIndex = 5;
            this.Routes1NumberNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Routes1NumberNumeric.ValueChanged += new System.EventHandler(this.Routes1NumberNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Макс длина маршрутов";
            // 
            // RouteLengthNumeric
            // 
            this.RouteLengthNumeric.Location = new System.Drawing.Point(12, 109);
            this.RouteLengthNumeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.RouteLengthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RouteLengthNumeric.Name = "RouteLengthNumeric";
            this.RouteLengthNumeric.Size = new System.Drawing.Size(120, 20);
            this.RouteLengthNumeric.TabIndex = 7;
            this.RouteLengthNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RouteLengthNumeric.ValueChanged += new System.EventHandler(this.RouteLengthNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вероятность выбора 1 подтемы";
            // 
            // SubthemeProbablityNumeric
            // 
            this.SubthemeProbablityNumeric.DecimalPlaces = 2;
            this.SubthemeProbablityNumeric.Location = new System.Drawing.Point(12, 148);
            this.SubthemeProbablityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SubthemeProbablityNumeric.Name = "SubthemeProbablityNumeric";
            this.SubthemeProbablityNumeric.Size = new System.Drawing.Size(120, 20);
            this.SubthemeProbablityNumeric.TabIndex = 9;
            this.SubthemeProbablityNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // MistakeTypeComboBox
            // 
            this.MistakeTypeComboBox.FormattingEnabled = true;
            this.MistakeTypeComboBox.Items.AddRange(new object[] {
            "Повторить шаг",
            "Сделать шаг назад",
            "Начать заново"});
            this.MistakeTypeComboBox.Location = new System.Drawing.Point(12, 187);
            this.MistakeTypeComboBox.Name = "MistakeTypeComboBox";
            this.MistakeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.MistakeTypeComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип ошибки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Вероятность ошибки";
            // 
            // MistakeProbabilityNumeric
            // 
            this.MistakeProbabilityNumeric.DecimalPlaces = 2;
            this.MistakeProbabilityNumeric.Location = new System.Drawing.Point(12, 227);
            this.MistakeProbabilityNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MistakeProbabilityNumeric.Name = "MistakeProbabilityNumeric";
            this.MistakeProbabilityNumeric.Size = new System.Drawing.Size(120, 20);
            this.MistakeProbabilityNumeric.TabIndex = 13;
            this.MistakeProbabilityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество повторов";
            // 
            // SelectionSizeNumeric
            // 
            this.SelectionSizeNumeric.Location = new System.Drawing.Point(12, 266);
            this.SelectionSizeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SelectionSizeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectionSizeNumeric.Name = "SelectionSizeNumeric";
            this.SelectionSizeNumeric.Size = new System.Drawing.Size(120, 20);
            this.SelectionSizeNumeric.TabIndex = 15;
            this.SelectionSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // StepTimesDataGridView
            // 
            this.StepTimesDataGridView.AllowUserToAddRows = false;
            this.StepTimesDataGridView.AllowUserToDeleteRows = false;
            this.StepTimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StepTimesDataGridView.Location = new System.Drawing.Point(305, 244);
            this.StepTimesDataGridView.Name = "StepTimesDataGridView";
            this.StepTimesDataGridView.Size = new System.Drawing.Size(171, 187);
            this.StepTimesDataGridView.TabIndex = 17;
            this.StepTimesDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.StepTimesDataGridView_EditingControlShowing);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Матрица времени на вершинах";
            // 
            // ProbabilityMatrixDataGridView2
            // 
            this.ProbabilityMatrixDataGridView2.AllowUserToAddRows = false;
            this.ProbabilityMatrixDataGridView2.AllowUserToDeleteRows = false;
            this.ProbabilityMatrixDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProbabilityMatrixDataGridView2.Location = new System.Drawing.Point(550, 25);
            this.ProbabilityMatrixDataGridView2.Name = "ProbabilityMatrixDataGridView2";
            this.ProbabilityMatrixDataGridView2.Size = new System.Drawing.Size(238, 187);
            this.ProbabilityMatrixDataGridView2.TabIndex = 21;
            this.ProbabilityMatrixDataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ProbabilityMatrixDataGridView_EditingControlShowing);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Матрица маршрутов 2 подтемы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Количество маршрутов 2 подтемы";
            // 
            // Routes2NumberNumeric
            // 
            this.Routes2NumberNumeric.Location = new System.Drawing.Point(12, 71);
            this.Routes2NumberNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Routes2NumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Routes2NumberNumeric.Name = "Routes2NumberNumeric";
            this.Routes2NumberNumeric.Size = new System.Drawing.Size(120, 20);
            this.Routes2NumberNumeric.TabIndex = 23;
            this.Routes2NumberNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Routes2NumberNumeric.ValueChanged += new System.EventHandler(this.Routes2NumberNumeric_ValueChanged);
            // 
            // RouteProbablityDataGrid1
            // 
            this.RouteProbablityDataGrid1.AllowUserToAddRows = false;
            this.RouteProbablityDataGrid1.AllowUserToDeleteRows = false;
            this.RouteProbablityDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteProbablityDataGrid1.Location = new System.Drawing.Point(500, 269);
            this.RouteProbablityDataGrid1.Name = "RouteProbablityDataGrid1";
            this.RouteProbablityDataGrid1.Size = new System.Drawing.Size(126, 162);
            this.RouteProbablityDataGrid1.TabIndex = 25;
            this.RouteProbablityDataGrid1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.StepTimesDataGridView_EditingControlShowing);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(499, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 39);
            this.label10.TabIndex = 26;
            this.label10.Text = "Матрица вероятнестей \r\nвыбора маршрута\r\n1 подтемы";
            // 
            // RouteProbablityDataGrid2
            // 
            this.RouteProbablityDataGrid2.AllowUserToAddRows = false;
            this.RouteProbablityDataGrid2.AllowUserToDeleteRows = false;
            this.RouteProbablityDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RouteProbablityDataGrid2.Location = new System.Drawing.Point(632, 269);
            this.RouteProbablityDataGrid2.Name = "RouteProbablityDataGrid2";
            this.RouteProbablityDataGrid2.Size = new System.Drawing.Size(126, 162);
            this.RouteProbablityDataGrid2.TabIndex = 27;
            this.RouteProbablityDataGrid2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.StepTimesDataGridView_EditingControlShowing);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 39);
            this.label12.TabIndex = 28;
            this.label12.Text = "Матрица вероятнестей \r\nвыбора маршрута\r\n1 подтемы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RouteProbablityDataGrid2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RouteProbablityDataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Routes2NumberNumeric);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProbabilityMatrixDataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StepTimesDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SelectionSizeNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MistakeProbabilityNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MistakeTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubthemeProbablityNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RouteLengthNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Routes1NumberNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProbabilityMatrixDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes1NumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubthemeProbablityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MistakeProbabilityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Routes2NumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteProbablityDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteProbablityDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProbabilityMatrixDataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Routes1NumberNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RouteLengthNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SubthemeProbablityNumeric;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox MistakeTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MistakeProbabilityNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown SelectionSizeNumeric;
        private System.Windows.Forms.DataGridView StepTimesDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ProbabilityMatrixDataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Routes2NumberNumeric;
        private System.Windows.Forms.DataGridView RouteProbablityDataGrid1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView RouteProbablityDataGrid2;
        private System.Windows.Forms.Label label12;
    }
}

