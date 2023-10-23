using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HumanEVMInterface
{
    public enum MistakeType
    {
        Repeat,
        TurnBack,
        Restart
    };
    public partial class Form1 : Form
    {
        public int RoutesNumber; //колво маршрутов
        public int RouteLength; //длина маршрута
        public int RouteTypeNumbers; //кол-во вершин
        public List<int> RoutesFinish1 = new List<int>();
        public List<int> RoutesFinish2 = new List<int>();
        public double[,] ProbabiltyMatrix;
        public double[,] ProbabiltyMatrix2;
        public double[,] StepTimes; //время ходьбы через каждую вершину 1 подтемы
        public double[,] StepTimes2; //время ходьбы через каждую вершину 2 подтемы
        public double[] SubthemeProbablity; //вероятность выбора подтемы
        public double MistakeProbablity; //вероятность ошибки
        public MistakeType MistakeType; //тип ошибки
        public int SelectionSize; //размер выборки (колво прогонов программы)

        public Form1()
        {
            InitializeComponent();
            StepTimesDataGridView.Columns.Add("Column 1", "1");
            StepTimesDataGridView.Columns.Add("Column 2", "2");
            StepTimesDataGridView2.Columns.Add("Column 1", "1");
            StepTimesDataGridView2.Columns.Add("Column 2", "2");
            StepTimesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            StepTimesDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ProbabilityMatrixDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ProbabilityMatrixDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (int.TryParse(RouteTypeNumberNumeric.Text, out int rowCount))
            {
                ProbabilityMatrixDataGridView.Rows.Clear();
                ProbabilityMatrixDataGridView.Columns.Clear();
                for (int i = 0; i < rowCount; i++)
                    ProbabilityMatrixDataGridView.Columns.Add("Column" + i, "" + (i + 1));

                for (int i = 0; i < rowCount; i++)
                {
                    ProbabilityMatrixDataGridView.Rows.Add();
                    StepTimesDataGridView.Rows.Add();
                }
            }
            if (int.TryParse(RouteTypeNumberNumeric2.Text, out int rowCount1))
            {
                ProbabilityMatrixDataGridView2.Rows.Clear();
                ProbabilityMatrixDataGridView2.Columns.Clear();
                for (int i = 0; i < rowCount1; i++)
                    ProbabilityMatrixDataGridView2.Columns.Add("Column" + i, "" + (i + 1));

                for (int i = 0; i < rowCount1; i++)
                {
                    ProbabilityMatrixDataGridView2.Rows.Add();
                    StepTimesDataGridView2.Rows.Add();
                }
            }
        }
        bool CheckDiagonalZero(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (matrix[i, i] != 0)
                    return false;
            return true;
        }
        bool CheckMatrix(double[,] matrix, int numberSubTheme)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            double[] rowSums = new double[rowCount];
            double[] colSums = new double[colCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    rowSums[row] += matrix[row, col];
                    colSums[col] += matrix[row, col];
                }
            }

            for (int i = 0; i < rowSums.Length; i++)
            {
                if (rowSums[i] == 0)
                {
                    if (numberSubTheme == 1) RoutesFinish1.Add(i);
                    else RoutesFinish2.Add(i);
                    break;
                }
            }


            for (int i = 0; i < rowCount; i++)
            {
                if (rowSums[i] == 0)
                {
                    if (numberSubTheme == 1) RoutesFinish1.Add(i); // Определение конечных вершин
                    else RoutesFinish2.Add(i);
                    break;
                }
                else if (rowSums[i] != 1)
                    return false;
            }

            for (int j = 0; j < colCount; j++)
                if (colSums[j] != 1 && colSums[j] != 0)
                    return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SubthemeProbablity = new double[2];
                StepTimes = new double[(int)RouteTypeNumberNumeric.Value, 2];
                StepTimes2 = new double[(int)RouteTypeNumberNumeric2.Value, 2];
                ProbabiltyMatrix = new double[(int)RouteTypeNumberNumeric.Value, (int)RouteTypeNumberNumeric.Value];
                ProbabiltyMatrix2 = new double[(int)RouteTypeNumberNumeric2.Value, (int)RouteTypeNumberNumeric2.Value];

                if (MistakeTypeComboBox.Text == "")
                {
                    throw new Exception("Тип ошибки не выбран!");
                }
                for (int row = 0; row < StepTimesDataGridView.Rows.Count; row++)
                    for (int col = 0; col < StepTimesDataGridView.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)StepTimesDataGridView.Rows[row].Cells[col].Value, out double cellValue))
                            throw new Exception("Матрица длины шагов не полностью записана!");
                        StepTimes[row, col] = cellValue;
                    }
                for (int row = 0; row < ProbabilityMatrixDataGridView.Rows.Count; row++)
                    for (int col = 0; col < ProbabilityMatrixDataGridView.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)ProbabilityMatrixDataGridView.Rows[row].Cells[col].Value, out double cellValue))
                            throw new Exception("Матрица вероятностей не полностью записана!");
                        ProbabiltyMatrix[row,col] = cellValue;
                    }
                for (int row = 0; row < StepTimesDataGridView2.Rows.Count; row++)
                    for (int col = 0; col < StepTimesDataGridView2.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)StepTimesDataGridView2.Rows[row].Cells[col].Value, out double cellValue))
                            throw new Exception("Матрица длины шагов не полностью записана!");
                        StepTimes2[row, col] = cellValue;
                    }
                for (int row = 0; row < ProbabilityMatrixDataGridView2.Rows.Count; row++)
                    for (int col = 0; col < ProbabilityMatrixDataGridView2.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)ProbabilityMatrixDataGridView2.Rows[row].Cells[col].Value, out double cellValue))
                            throw new Exception("Матрица вероятностей не полностью записана!");
                        ProbabiltyMatrix2[row, col] = cellValue;
                    }
                if (!CheckMatrix(ProbabiltyMatrix, 1) || !CheckMatrix(ProbabiltyMatrix2, 2))
                    throw new Exception("Суммы строк и столбцов НЕ равны 1.");
                if (!CheckDiagonalZero(ProbabiltyMatrix) || !CheckDiagonalZero(ProbabiltyMatrix2))
                    throw new Exception("Не все диагональные ячейки равны 0.");
                RouteTypeNumbers = (int)RouteTypeNumberNumeric.Value;
                RouteLength = (int)RouteLengthNumeric.Value;
                RoutesNumber = (int)RoutesNumberNumeric.Value;
                SubthemeProbablity[0] = (double)SubthemeProbablityNumeric.Value;
                SubthemeProbablity[1] = 1 - SubthemeProbablity[0];
                MistakeProbablity = (double)MistakeProbabilityNumeric.Value;
                switch (MistakeTypeComboBox.Text)
                {
                    case "Повторить шаг":
                        MistakeType = MistakeType.Repeat;
                        break;
                    case "Сделать шаг назад":
                        MistakeType = MistakeType.TurnBack;
                        break;
                    case "Начать заново":
                        MistakeType = MistakeType.Restart;
                        break;
                    default:
                        break;
                }
                SelectionSize = (int)SelectionSizeNumeric.Value;

                Imatation();
            }            

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Imatation()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();

            bool isFirstSubtheme = false;

            if (randomNumber < SubthemeProbablity[0])
            {
                isFirstSubtheme = true;
            }

            double cumulativeProbability = 0.0;

            double totalTime = 0;

            if (isFirstSubtheme)
            {
                for (int i = 0; i < ProbabiltyMatrix.GetLength(0); )
                {
                    if (RoutesFinish1.Contains(i))
                    {
                        if (StepTimes[i, 1] == 0)
                        {
                            totalTime += StepTimes[i, 0];
                        }
                        else
                        {
                            totalTime += StepTimes[i, 0] + random.NextDouble() * (StepTimes[i, 1] - StepTimes[i, 0]);
                        }
                        break;
                    }
                    for (int j = 0; j < ProbabiltyMatrix.GetLength(1); j++)
                    {
                        if (ProbabiltyMatrix[i, j] != 0)
                        {
                            cumulativeProbability += ProbabiltyMatrix[i, j];
                            if (randomNumber < cumulativeProbability)
                            {
                                //int nextRoute = ++j;
                                
                                // Прибавить время прохождения  вершины
                                if (StepTimes[i, 1] == 0)
                                {
                                    totalTime += StepTimes[i, 0];
                                }
                                else
                                {
                                    totalTime += StepTimes[i, 0] + random.NextDouble() * (StepTimes[i, 1] - StepTimes[i, 0]);
                                }
                                i = j;
                                break;
                            }
                        }
                    }

                    // |0   0.3 0.3 0.4 0  |
                    // |0   0   0   0.2 0.8|
                    // |0   0   0   0   1  |
                    // |0   0   0   0   1  |
                    // |0   0   0   0   0  |
                }
            }
            else
            {
                for (int i = 0; i < ProbabiltyMatrix2.GetLength(0); )
                {
                    if (RoutesFinish2.Contains(i))
                    {
                        if (StepTimes2[i, 1] == 0)
                        {
                            totalTime += StepTimes2[i, 0];
                        }
                        else
                        {
                            totalTime += StepTimes2[i, 0] + random.NextDouble() * (StepTimes2[i, 1] - StepTimes2[i, 0]);
                        }
                        break;
                    }
                    for (int j = 0; j < ProbabiltyMatrix2.GetLength(1); j++)
                    {
                        if (ProbabiltyMatrix[i, j] != 0)
                        {
                            cumulativeProbability += ProbabiltyMatrix2[i, j];
                            if (randomNumber < cumulativeProbability)
                            {
                                
                                if (StepTimes[i, 1] == 0)
                                {
                                    totalTime += StepTimes2[i, 0];
                                }
                                else
                                {
                                    totalTime += StepTimes2[i, 0] + random.NextDouble() * (StepTimes2[i, 1] - StepTimes2[i, 0]);
                                }

                                //int nextRoute = j +;
                                i = j;
                                break;
                            }
                        }
                    }
                }
            }

            MessageBox.Show(totalTime.ToString());
            
        }

        private void ProbabilityMatrixDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        private void StepTimesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void RouteTypeNumberNumeric_ValueChanged(object sender, EventArgs e)
        {
            string _oldValue = ((UpDownBase)sender).Text;
            int.TryParse(_oldValue, out int oldValue);
            int.TryParse(((NumericUpDown)sender).Value.ToString(), out int newValue);
            if (oldValue > newValue)
            {
                ProbabilityMatrixDataGridView.Rows.RemoveAt(oldValue - 1);
                ProbabilityMatrixDataGridView.Columns.RemoveAt(oldValue - 1);
                StepTimesDataGridView.Rows.RemoveAt(oldValue - 1);
            }
            else
            {
                ProbabilityMatrixDataGridView.Columns.Add("Column" + (newValue - 1), "" + newValue);
                ProbabilityMatrixDataGridView.Rows.Add();
                StepTimesDataGridView.Rows.Add();
            }
        }

        private void RouteTypeNumberNumeric2_ValueChanged(object sender, EventArgs e)
        {
            string _oldValue = ((UpDownBase)sender).Text;
            int.TryParse(_oldValue, out int oldValue);
            int.TryParse(((NumericUpDown)sender).Value.ToString(), out int newValue);
            if (oldValue > newValue)
            {
                ProbabilityMatrixDataGridView2.Rows.RemoveAt(oldValue - 1);
                ProbabilityMatrixDataGridView2.Columns.RemoveAt(oldValue - 1);
                StepTimesDataGridView2.Rows.RemoveAt(oldValue - 1);
            }
            else
            {
                ProbabilityMatrixDataGridView2.Columns.Add("Column" + (newValue - 1), "" + newValue);
                ProbabilityMatrixDataGridView2.Rows.Add();
                StepTimesDataGridView2.Rows.Add();
            }
        }
    }
}
