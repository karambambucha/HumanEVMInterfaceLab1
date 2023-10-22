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
            this.ProbabilityMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RouteTypeNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RoutesNumberNumeric = new System.Windows.Forms.NumericUpDown();
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
            this.RouteTypeNumberNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ProbabilityMatrixDataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.StepTimesDataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteTypeNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoutesNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteLengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubthemeProbablityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MistakeProbabilityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteTypeNumberNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProbabilityMatrixDataGridView
            // 
            this.ProbabilityMatrixDataGridView.AllowUserToAddRows = false;
            this.ProbabilityMatrixDataGridView.AllowUserToDeleteRows = false;
            this.ProbabilityMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProbabilityMatrixDataGridView.Location = new System.Drawing.Point(305, 25);
            this.ProbabilityMatrixDataGridView.Name = "ProbabilityMatrixDataGridView";
            this.ProbabilityMatrixDataGridView.Size = new System.Drawing.Size(238, 187);
            this.ProbabilityMatrixDataGridView.TabIndex = 0;
            this.ProbabilityMatrixDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ProbabilityMatrixDataGridView_EditingControlShowing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RouteTypeNumberNumeric
            // 
            this.RouteTypeNumberNumeric.Location = new System.Drawing.Point(15, 25);
            this.RouteTypeNumberNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric.Name = "RouteTypeNumberNumeric";
            this.RouteTypeNumberNumeric.Size = new System.Drawing.Size(120, 20);
            this.RouteTypeNumberNumeric.TabIndex = 2;
            this.RouteTypeNumberNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric.ValueChanged += new System.EventHandler(this.RouteTypeNumberNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество вершин в 1 теме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Матрица вероятностей 1 подтемы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество маршрутов";
            // 
            // RoutesNumberNumeric
            // 
            this.RoutesNumberNumeric.Location = new System.Drawing.Point(15, 100);
            this.RoutesNumberNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RoutesNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoutesNumberNumeric.Name = "RoutesNumberNumeric";
            this.RoutesNumberNumeric.Size = new System.Drawing.Size(120, 20);
            this.RoutesNumberNumeric.TabIndex = 5;
            this.RoutesNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина маршрутов";
            // 
            // RouteLengthNumeric
            // 
            this.RouteLengthNumeric.Location = new System.Drawing.Point(15, 139);
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
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вероятность выбора 1 подтемы";
            // 
            // SubthemeProbablityNumeric
            // 
            this.SubthemeProbablityNumeric.DecimalPlaces = 2;
            this.SubthemeProbablityNumeric.Location = new System.Drawing.Point(15, 178);
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
            this.MistakeTypeComboBox.Location = new System.Drawing.Point(15, 217);
            this.MistakeTypeComboBox.Name = "MistakeTypeComboBox";
            this.MistakeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.MistakeTypeComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тип ошибки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Вероятность ошибки";
            // 
            // MistakeProbabilityNumeric
            // 
            this.MistakeProbabilityNumeric.DecimalPlaces = 2;
            this.MistakeProbabilityNumeric.Location = new System.Drawing.Point(15, 257);
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
            this.label8.Location = new System.Drawing.Point(12, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество повторов";
            // 
            // SelectionSizeNumeric
            // 
            this.SelectionSizeNumeric.Location = new System.Drawing.Point(15, 296);
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
            // RouteTypeNumberNumeric2
            // 
            this.RouteTypeNumberNumeric2.Location = new System.Drawing.Point(15, 61);
            this.RouteTypeNumberNumeric2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric2.Name = "RouteTypeNumberNumeric2";
            this.RouteTypeNumberNumeric2.Size = new System.Drawing.Size(120, 20);
            this.RouteTypeNumberNumeric2.TabIndex = 19;
            this.RouteTypeNumberNumeric2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RouteTypeNumberNumeric2.ValueChanged += new System.EventHandler(this.RouteTypeNumberNumeric2_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Количество вершин в 2 теме";
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Матрица вероятностей 2 подтемы";
            // 
            // StepTimesDataGridView2
            // 
            this.StepTimesDataGridView2.AllowUserToAddRows = false;
            this.StepTimesDataGridView2.AllowUserToDeleteRows = false;
            this.StepTimesDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StepTimesDataGridView2.Location = new System.Drawing.Point(485, 244);
            this.StepTimesDataGridView2.Name = "StepTimesDataGridView2";
            this.StepTimesDataGridView2.Size = new System.Drawing.Size(171, 187);
            this.StepTimesDataGridView2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(482, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Матрица времени на вершинах 2 пути";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StepTimesDataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProbabilityMatrixDataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RouteTypeNumberNumeric2);
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
            this.Controls.Add(this.RoutesNumberNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteTypeNumberNumeric);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProbabilityMatrixDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteTypeNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoutesNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteLengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubthemeProbablityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MistakeProbabilityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RouteTypeNumberNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityMatrixDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepTimesDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProbabilityMatrixDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown RouteTypeNumberNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RoutesNumberNumeric;
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
        private System.Windows.Forms.NumericUpDown RouteTypeNumberNumeric2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ProbabilityMatrixDataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView StepTimesDataGridView2;
        private System.Windows.Forms.Label label12;
    }
}

