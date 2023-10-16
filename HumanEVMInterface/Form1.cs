using System;
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
        public double[,] ProbabiltyMatrix;
        public double[,] StepTimes; //время ходьбы через каждую вершину
        public double[] SubthemeProbablity; //вероятность выбора подтемы
        public double MistakeProbablity; //вероятность ошибки
        public MistakeType MistakeType; //тип ошибки
        public int SelectionSize; //размер выборки (колво прогонов программы)

        public Form1()
        {
            InitializeComponent();
            StepTimesDataGridView.Columns.Add("Column 1", "1");
            StepTimesDataGridView.Columns.Add("Column 2", "2");
            StepTimesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            ProbabilityMatrixDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
        }
        bool CheckDiagonalZero(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (matrix[i, i] != 0)
                    return false;
            return true;
        }
        bool CheckMatrix(double[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            double[] rowSums = new double[rowCount];
            double[] colSums = new double[colCount];

            for (int row = 0; row < rowCount; row++)
                for (int col = 0; col < colCount; col++)
                {
                    rowSums[row] += matrix[row, col];
                    colSums[col] += matrix[row, col];
                }

            for (int i = 0; i < rowCount; i++)
                if (rowSums[i] != 1)
                    return false;

            for (int j = 0; j < colCount; j++)
                if (colSums[j] != 1)
                    return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SubthemeProbablity = new double[2];
                StepTimes = new double[2, (int)RouteTypeNumberNumeric.Value];
                ProbabiltyMatrix = new double[(int)RouteTypeNumberNumeric.Value, (int)RouteTypeNumberNumeric.Value];
                if (MistakeTypeComboBox.Text == "")
                {
                    throw new Exception("Тип ошибки не выбран!");
                }
                for (int row = 0; row < StepTimesDataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < StepTimesDataGridView.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)StepTimesDataGridView.Rows[row].Cells[col].Value, out double cellValue))
                        {
                            throw new Exception("Матрица длины шагов не полностью записана!");
                        }
                        StepTimes[col, row] = cellValue;
                    }
                }
                for (int row = 0; row < ProbabilityMatrixDataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < ProbabilityMatrixDataGridView.Columns.Count; col++)
                    {
                        if (!double.TryParse((string)ProbabilityMatrixDataGridView.Rows[row].Cells[col].Value, out double cellValue))
                        {
                            throw new Exception("Матрица вероятностей не полностью записана!");
                        }
                        ProbabiltyMatrix[col, row] = cellValue;
                    }
                }
                if (!CheckMatrix(ProbabiltyMatrix))
                    throw new Exception("Суммы строк и столбцов НЕ равны 1.");
                if (!CheckDiagonalZero(ProbabiltyMatrix))
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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
