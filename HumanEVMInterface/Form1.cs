using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
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
        public int RoutesNumber1; //колво маршрутов 1 подтемы
        public int RoutesNumber2; //колво маршрутов 2 подтемы
        public int RouteLength; //макс длина маршрутов
        public List<List<int>> RouteMatrix1;
        public List<List<int>> RouteMatrix2;
        public HashSet<int> UniqueNodes;
        public List<double[]> StepTimes; //время ходьбы через каждую вершину
        public double[] SubthemeProbablity; //вероятность выбора 1ой подтемы
        public List<double> RouteProbablity1; //вероятность выбора маршрутов в 1 подтеме
        public List<double> RouteProbablity2; //вероятность выбора маршрутов в 2 подтеме
        public double MistakeProbablity; //вероятность ошибки
        public MistakeType MistakeType; //тип ошибки
        public int SelectionSize; //размер выборки (колво прогонов программы)
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            StepTimesDataGridView.Columns.Add("Column 1", "1");
            RouteProbablityDataGrid1.Columns.Add("Column 1", "1");
            RouteProbablityDataGrid2.Columns.Add("Column 1", "1");
            StepTimesDataGridView.Columns.Add("Column 2", "2");
            StepTimesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProbabilityMatrixDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProbabilityMatrixDataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RouteProbablityDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RouteProbablityDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProbabilityMatrixDataGridView1.Rows.Clear();
            ProbabilityMatrixDataGridView1.Columns.Clear();
            ProbabilityMatrixDataGridView2.Rows.Clear();
            ProbabilityMatrixDataGridView2.Columns.Clear();
            if (int.TryParse(RouteLengthNumeric.Text, out int nodeCount))
            {
                for (int i = 0; i < nodeCount; i++)
                {
                    StepTimesDataGridView.Rows.Add();
                    StepTimesDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    ProbabilityMatrixDataGridView1.Columns.Add("Column" + i, "" + (i + 1));
                    ProbabilityMatrixDataGridView2.Columns.Add("Column" + i, "" + (i + 1));
                }
            }
            if (int.TryParse(Routes1NumberNumeric.Text, out int rowCount))
            {
                
                for (int i = 0; i < rowCount; i++)
                {
                    ProbabilityMatrixDataGridView1.Rows.Add();
                    ProbabilityMatrixDataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    RouteProbablityDataGrid1.Rows.Add();
                    RouteProbablityDataGrid1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
            if (int.TryParse(Routes2NumberNumeric.Text, out int rowCount1))
            {
                for (int i = 0; i < rowCount1; i++)
                {
                    ProbabilityMatrixDataGridView2.Rows.Add();
                    ProbabilityMatrixDataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    RouteProbablityDataGrid2.Rows.Add();
                    RouteProbablityDataGrid2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
           
        }

        private void readParameters()
        {
            RouteMatrix1 = new List<List<int>>();
            RouteMatrix2 = new List<List<int>>();
            RouteProbablity1 = new List<double>();
            RouteProbablity2 = new List<double>();
            UniqueNodes = new HashSet<int>();
            SubthemeProbablity = new double[2];
            StepTimes = new List<double[]>();
            RouteLength = (int)RouteLengthNumeric.Value;

            if (MistakeTypeComboBox.Text == "")
            {
                throw new Exception("Тип ошибки не выбран!");
            }
            for (int row = 0; row < StepTimesDataGridView.RowCount; row++)
            {
                if (!double.TryParse((string)StepTimesDataGridView.Rows[row].Cells[0].Value, out double cellValue1))
                    throw new Exception("Матрица времен не полностью записана!");
                if (!double.TryParse((string)StepTimesDataGridView.Rows[row].Cells[1].Value, out double cellValue2))
                    throw new Exception("Матрица времен не полностью записана!");
                StepTimes.Add(new double[] { cellValue1, cellValue2 });
            }
            for (int row = 0; row < ProbabilityMatrixDataGridView1.Rows.Count; row++)
            {
                RouteMatrix1.Add(new List<int>());
                for (int col = 0; col < ProbabilityMatrixDataGridView1.Columns.Count; col++)
                {
                    if ((string)ProbabilityMatrixDataGridView1.Rows[row].Cells[col].Value != null)
                    {
                        if (!int.TryParse((string)ProbabilityMatrixDataGridView1.Rows[row].Cells[col].Value, out int cellValue))
                            throw new Exception("Не верно записаны вершины матрицы маршрутов!");
                        RouteMatrix1[row].Add(cellValue);
                        UniqueNodes.Add(cellValue);
                        if (UniqueNodes.Count > RouteLength)
                            throw new Exception("Количество вершин больше длины маршрута!");
                    }
                }
            }
            for (int row = 0; row < ProbabilityMatrixDataGridView2.Rows.Count; row++)
            {
                RouteMatrix2.Add(new List<int>());
                for (int col = 0; col < ProbabilityMatrixDataGridView2.Columns.Count; col++)
                {
                    if ((string)ProbabilityMatrixDataGridView2.Rows[row].Cells[col].Value != null)
                    {
                        if (!int.TryParse((string)ProbabilityMatrixDataGridView2.Rows[row].Cells[col].Value, out int cellValue))
                            throw new Exception("Не верно записаны вершины матрицы маршрутов!");
                        RouteMatrix2[row].Add(cellValue);
                        UniqueNodes.Add(cellValue);
                        if (UniqueNodes.Count > RouteLength)
                            throw new Exception("Количество вершин больше длины маршрута!");
                    }
                }
            }
            foreach (var row in RouteMatrix1)
            {
                if (row[0] != 1)
                    throw new Exception("Не все пути начинаются с 1!");
            }
            foreach (var row in RouteMatrix2)
            {
                if (row[0] != 1)
                    throw new Exception("Не все пути начинаются с 1!");
            }
            for (int i = 0; i < RouteProbablityDataGrid1.Rows.Count; i++)
            {
                if (!double.TryParse((string)RouteProbablityDataGrid1.Rows[i].Cells[0].Value, out double cellValue))
                    throw new Exception("Не верно записаны вероятности выбора маршрутов!");
                RouteProbablity1.Add(cellValue);
            }
            for (int i = 0; i < RouteProbablityDataGrid2.Rows.Count; i++)
            {
                if (!double.TryParse((string)RouteProbablityDataGrid2.Rows[i].Cells[0].Value, out double cellValue))
                    throw new Exception("Не верно записаны вероятности выбора маршрутов!");
                RouteProbablity2.Add(cellValue);
            }
            if (RouteProbablity1.Sum() != 1 || RouteProbablity2.Sum() != 1)
                throw new Exception("Суммы вероятностей равны 1!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                readParameters();
                var firstThemeTimes = new List<double>();
                var secondThemeTimes = new List<double>();
                
                for (int i = 0; i < SelectionSize; i++)
                {
                    double probability = random.NextDouble();
                    List<List<int>> currentMatrix;
                    List<double> currentProbMatrix;
                    if (probability < SubthemeProbablity[0])
                    {
                        currentMatrix = RouteMatrix1;
                        currentProbMatrix = RouteProbablity1;
                        firstThemeTimes.Add(Imitation(currentMatrix, StepTimes, MistakeType, MistakeProbablity, currentProbMatrix));
                    }
                    else
                    {
                        currentMatrix = RouteMatrix2;
                        currentProbMatrix = RouteProbablity2;
                        secondThemeTimes.Add(Imitation(currentMatrix, StepTimes, MistakeType, MistakeProbablity, currentProbMatrix));
                    }
                }
                var totalTimes = firstThemeTimes.Concat(secondThemeTimes).ToArray();
                Graphs graphs = new Graphs(totalTimes);
                graphs.Show();
                MessageBox.Show($"Среднее время подтемы 1: {firstThemeTimes.Average()}, среднее время подтемы 2: {secondThemeTimes.Average()}, общее время {firstThemeTimes.Sum() + secondThemeTimes.Sum()}");
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double Imitation(List<List<int>> matrix, List<double[]> times, MistakeType mistakeType, double mistakeProbablity, List<double> probablityMatrix)
        {
            int currentNode = 0;
            RouteMatrix routeMatrix = new RouteMatrix(matrix, times, random);
            int currentRoute = 0;
            double cumulativeProbability = 0.0;
            double randomValue = random.NextDouble();
            for (int i = 0; i < probablityMatrix.Count; i++)
            {
                cumulativeProbability += probablityMatrix[i];

                if (randomValue < cumulativeProbability)
                {
                    currentRoute = i;
                    break;
                }
            }

            for (int i = 0; i < matrix[currentRoute].Count;)
            {
                int previousNode = currentNode;
                Console.Write($"Step {i + 1}: Route {currentRoute + 1}, Node {matrix[currentRoute][currentNode]}, ");
                currentNode = routeMatrix.MakeTransition(currentRoute, currentNode);
                if (random.NextDouble() < mistakeProbablity && currentNode != matrix[currentRoute].Count - 1)
                {
                    switch (mistakeType)
                    {
                        case MistakeType.Repeat:
                            Console.WriteLine("Repeat the node");
                            currentNode = previousNode;
                            i = previousNode;
                            break;
                        case MistakeType.TurnBack:
                            Console.WriteLine("Turn back");
                            currentNode = previousNode - 1;
                            if (currentNode < 0)
                                currentNode = 0;
                            i = currentNode;
                            break;
                        case MistakeType.Restart:
                            Console.WriteLine("Restart");
                            currentNode = 0;
                            i = 0;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    i++;
                }
            }
            return routeMatrix.totalTime;
        }

        private void ProbabilityMatrixDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        private void StepTimesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress1);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar)))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }
        void tb_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')))
                if (e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
        }

        private void Routes1NumberNumeric_ValueChanged(object sender, EventArgs e)
        {
            string _oldValue = ((UpDownBase)sender).Text;
            int.TryParse(_oldValue, out int oldValue);
            int.TryParse(((NumericUpDown)sender).Value.ToString(), out int newValue);
            if (oldValue > newValue)
            {
                ProbabilityMatrixDataGridView1.Rows.RemoveAt(oldValue - 1);
                RouteProbablityDataGrid1.Rows.RemoveAt(oldValue - 1);
            }
            else
            {
                ProbabilityMatrixDataGridView1.Rows.Add();
                ProbabilityMatrixDataGridView1.Rows[newValue - 1].HeaderCell.Value = (newValue).ToString();
                RouteProbablityDataGrid1.Rows.Add();
                RouteProbablityDataGrid1.Rows[newValue - 1].HeaderCell.Value = (newValue).ToString();
            }
        }

        private void Routes2NumberNumeric_ValueChanged(object sender, EventArgs e)
        {
            string _oldValue = ((UpDownBase)sender).Text;
            int.TryParse(_oldValue, out int oldValue);
            int.TryParse(((NumericUpDown)sender).Value.ToString(), out int newValue);
            if (oldValue > newValue)
            {
                ProbabilityMatrixDataGridView2.Rows.RemoveAt(oldValue - 1);
                RouteProbablityDataGrid2.Rows.RemoveAt(oldValue - 1);
            }
            else
            {
                ProbabilityMatrixDataGridView2.Rows.Add();
                ProbabilityMatrixDataGridView2.Rows[newValue - 1].HeaderCell.Value = (newValue).ToString();
                RouteProbablityDataGrid2.Rows.Add();
                RouteProbablityDataGrid2.Rows[newValue - 1].HeaderCell.Value = (newValue).ToString();
            }
        }

        private void RouteLengthNumeric_ValueChanged(object sender, EventArgs e)
        {
            string _oldValue = ((UpDownBase)sender).Text;
            int.TryParse(_oldValue, out int oldValue);
            int.TryParse(((NumericUpDown)sender).Value.ToString(), out int newValue);
            if (oldValue > newValue)
            {
                StepTimesDataGridView.Rows.RemoveAt(oldValue - 1);
                ProbabilityMatrixDataGridView1.Columns.RemoveAt(oldValue - 1);
                ProbabilityMatrixDataGridView2.Columns.RemoveAt(oldValue - 1);
            }
            else
            {
                StepTimesDataGridView.Rows.Add();
                StepTimesDataGridView.Rows[newValue - 1].HeaderCell.Value = (newValue).ToString();
                ProbabilityMatrixDataGridView1.Columns.Add("Column" + (newValue - 1), "" + (newValue));
                ProbabilityMatrixDataGridView2.Columns.Add("Column" + (newValue - 1), "" + (newValue));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readParameters();
            double lambdaCustomers = (double)lambda1Numeric.Value;
            double lambdaFail = (double)lambda2Numeric.Value;
            double failTime = 1.0 / lambdaFail;
            double totalTimeWork = 0;
            double totalTimeRecover = 0;
            for (int i = 0; i < SelectionSize; i++)
            {
                totalTimeWork += StartModeling(failTime, lambdaCustomers);
                totalTimeRecover += Imitation(RouteMatrix2, StepTimes, MistakeType, MistakeProbablity, RouteProbablity2);
            }
            double price1 = (double)price1Numeric.Value;
            double price2 = (double)price2Numeric.Value;
            double sum = (price1 * totalTimeWork + price2 * totalTimeRecover) / (failTime * SelectionSize + totalTimeRecover);
            MessageBox.Show($"Время работы до отказа: {failTime}, всего работало: {totalTimeWork}, время восстановления: {totalTimeRecover}, коэффициент: {sum}");
        }

        private double StartModeling(double modelingTime, double lambda)
        {
            Random random = new Random();
            double currentTime = 0.0;
            double totalServingTime = 0;
            Queue<double> arrivalTimes = new Queue<double>();
            double serviceCompletionTime = double.PositiveInfinity;
            bool isBusy = false;
            while (currentTime < modelingTime)
            {
                double interarrivalTime = -Math.Log(random.NextDouble()) / lambda;
                arrivalTimes.Enqueue(currentTime + interarrivalTime);
                if (arrivalTimes.Count > 0 && currentTime >= arrivalTimes.Peek())
                {
                    arrivalTimes.Dequeue();
                    if (currentTime >= serviceCompletionTime && serviceCompletionTime < modelingTime)
                        isBusy = false;

                    if (!isBusy)
                    {
                        double serviceTime = Imitation(RouteMatrix1, StepTimes, MistakeType, MistakeProbablity, RouteProbablity1);
                        serviceCompletionTime = currentTime + serviceTime;
                        isBusy = true;
                        if (serviceCompletionTime < modelingTime)
                            totalServingTime += serviceTime;
                    }
                }
                currentTime = arrivalTimes.Peek();
            }
            return totalServingTime;
        }

    }
}
