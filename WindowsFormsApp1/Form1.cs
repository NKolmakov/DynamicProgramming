using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int previousOrganizationsAmount;
        private int previousYearsAmount;
        private int previousColumnsAmount;        

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            numericOrganizations.ValueChanged += NumericOrganizations_ValueChanged;
            dgUserData.RowsAdded += new DataGridViewRowsAddedEventHandler(DataGridView1_RowsAdded);
            dgUserData.RowsRemoved += new DataGridViewRowsRemovedEventHandler(DataGridView1_RowsRemoved);
            dgUserData.ColumnAdded += DataGridView1_ColumnAdded;
            dgUserData.ColumnRemoved += DataGridView1_ColumnRemoved;
            numericColumns.ValueChanged += NumericColumns_ValueChanged;
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[dgUserData.RowCount, dgUserData.ColumnCount - 1];
            if (ValidateData())
            {
                FillMatrix(matrix);
                StartCount(matrix);
            }
            else
            {
                MessageBox.Show("Ошибка! Заданные значения не соответствуют заданным требованиям:" +
                    "\n\n* Ячейки должны содержать числа;" +
                    "\n\n* Дробная часть десятичных чисел должна быть разделена точкой", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void StartCount(double[,] filledMatrix)
        {
            //матрица для хранения вычислений суммирования коэф-тов прибыли двух предприятий
            double[,] matrix = new double[filledMatrix.GetLength(0) - 1, filledMatrix.GetLength(1)];

            //массив для хранения максимальных элементов диагонали
            //состоит из двумерных матриц, каждая из которых имеет следующее содержание
            //
            //------------------ 1-я строка----------------------------
            //
            //зарезервирована для хранения найденных максимальных элементов каждой диагонали
            //номер столбца соответствует номеру каждой диагонали матрицы, полученной в результате суммирования
            //коэффициентов прибыли двух предприятий
            //
            //----------------- 2-я строка ------------------------------
            //
            //зарезервирована для хранения выделяемой суммы, соответствующей максимальному коэффициенту
            double[][,] result = new double[filledMatrix.GetLength(0) - 2][,];

            //общий цикл с количеством проходов, равных количеству предприятий -1
            for (int i = 0; i < filledMatrix.GetLength(0) - 2; i++)
            {
                //если это первый проход берутся коэффициенты из начальной таблицы предприятий
                if (i == 0)
                {
                    double[] first = new double[filledMatrix.GetLength(1)];
                    double[] second = new double[filledMatrix.GetLength(1)];

                    for (int j = 0; j < 1; j++)
                    {
                        for (int k = 0; k < filledMatrix.GetLength(1); k++)
                        {
                            first[k] = filledMatrix[1, k];
                            second[k] = filledMatrix[2, k];
                        }
                    }

                    matrix = Summ(first, second);
                    result[i] = GetResult(matrix, filledMatrix);
                }
                else
                {
                    //если не первый проход брать коэффициенты для суммирования из таблицы с результатом
                    //и таблицы с предприятиями
                    double[] first = new double[filledMatrix.GetLength(1)];
                    double[] second = new double[filledMatrix.GetLength(1)];

                    for (int j = 0; j < 1; j++)
                    {
                        for (int k = 0; k < result[i - 1].GetLength(1); k++)
                        {
                            first[k] = result[i - 1][0, k];
                            second[k] = filledMatrix[i + 2, k];
                        }
                    }

                    matrix = Summ(first, second);
                    result[i] = new double[2, filledMatrix.GetLength(1)];
                    result[i] = GetResult(matrix, filledMatrix);
                }
            }

            Analyze(result,filledMatrix);
        }

        private void Analyze(double[][,] result, double[,] filledMatrix)
        {
            double[] summs = new double[result.GetLength(0)+1];
            double commonSumm = filledMatrix[0, filledMatrix.GetLength(1) - 1];
            double currentSumm = 0;
            double profit = 0;
            double temp = 0;
            int years = Convert.ToInt32(numericYears.Value);

            for (int i = result.GetLength(0) - 1; i >= 0; i--)
            {
                double max = result[0][0, 0];
                for (int j = 0; j < result[i].GetLength(0); j++)
                {
                    for (int k = 0; k < result[i].GetLength(1); k++)
                    {
                        if (max < result[i][0, k])
                        {
                            if (i == result.GetLength(0) - 1)
                            {
                                max = result[i][0, k];
                                profit = max*years;
                                currentSumm = result[i][1, k];
                                commonSumm = filledMatrix[0, filledMatrix.GetLength(1) - 1];
                                summs[i+1] = currentSumm;
                                commonSumm -= summs[i+1];
                            }
                            else
                            {
                                if (filledMatrix[0, k] == commonSumm)
                                {
                                    summs[i+1] = result[i][1, k];
                                    commonSumm -= result[i][1, k];
                                    k = result[i].GetLength(1);
                                    j = result[i].GetLength(0);
                                }
                            }

                        }
                    }
                }
                
            }
            summs[0] = commonSumm;

            for (int i = 0; i < summs.Length; i++)
            {
                summs[i] *= years; 
            }

            previousYearsAmount = Convert.ToInt32(numericYears.Value);
            ShowReport showReport = new ShowReport(summs,previousYearsAmount,profit);
            showReport.Owner = this;
            showReport.Show();
            this.Hide();
        }

        private double[,] GetResult(double[,] matrix, double[,] filledMatrix)
        {
            double[,] result = new double[2, filledMatrix.GetLength(1)];

            for (int j = 0; j < filledMatrix.GetLength(1); j++)
            {
                double max = 0;
                double sum = 0;

                int counterRow = j;
                int counterCol = 0;

                for (int l = 0; l <= j; l++)
                {
                    if (max < matrix[counterRow, counterCol])
                    {
                        max = matrix[counterRow, counterCol];
                       // sum = filledMatrix[0, counterCol];
                        sum = filledMatrix[0, counterRow];
                    }
                    counterRow--;
                    counterCol++;
                }

                result[0, j] = max;
                result[1, j] = sum;

            }

            return result;

        }

        private double[,] Summ(double[] firstOrganiz, double[] secondOrganiz)
        {
            double[,] matrix = new double[firstOrganiz.Length, secondOrganiz.Length];

            //переменная, декрементируемая после каждой итерации для получения треугольного вида матрицы
            //изначально принимает значение, равное количеству столбцов
            int temp = matrix.GetLength(1);

            //суммирование коэф-тов первого и второго предприятия
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < temp; k++)
                {
                    ////первое предприятие. Индекс i+1 т.к на первой строке расположены выделяемые суммы
                    //double firstVar = matrix[i + 1, k];

                    ////второе предприятие
                    //double secondVar = matrix[i + 2, j];

                    double firstVar = firstOrganiz[k];
                    double secondVar = secondOrganiz[j];

                    matrix[j, k] = firstVar + secondVar;
                }
                temp--;
            }

            return matrix;

        }

        /// <summary>
        /// Метод возвращает матрицу, заполненную пользователем
        /// Данные берутся из элемента управления DataGridView и представляются как массив
        /// Расположение элементов:
        /// --------------------- 1-я строка-------------------------------
        /// Располагаются выделяемые предприятиям суммы
        /// --------------------- Оставшиеся строки -----------------------
        /// Располагаются коэффициенты прироста мощности
        /// </summary>
        /// <param name="matrix"></param>
        private void FillMatrix(double[,] matrix)
        {
            for (int i = 0; i < dgUserData.RowCount; i++)
            {
                for (int j = 0; j < dgUserData.ColumnCount - 1; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dgUserData.Rows[i].Cells[j + 1].Value);
                }
            }
        }

        private bool ValidateData()
        {
            try
            {
                for (int i = 0; i < dgUserData.RowCount; i++)
                {
                    for (int j = 1; j < dgUserData.ColumnCount; j++)
                    {
                        if (dgUserData.Rows[i].Cells[j].Value.ToString() == "")
                        {
                            dgUserData.Rows[i].Cells[j].Value = 0;
                        }
                        else
                        {
                            Convert.ToDouble(dgUserData.Rows[i].Cells[j].Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private void NumericColumns_ValueChanged(object sender, EventArgs e)
        {
            int currentColumnsAmount = Convert.ToInt32(numericColumns.Value);
            if (previousColumnsAmount < currentColumnsAmount)
            {
                dgUserData.Columns.Add("Column" + currentColumnsAmount, "");
                previousColumnsAmount++;
            }
            else
            {
                previousColumnsAmount--;
                dgUserData.Columns.RemoveAt(previousColumnsAmount);
            }
        }

        private void DataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            ChangeWidth();
        }

        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            ChangeWidth();
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ChangeHeight();
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChangeHeight();
        }

        private void ChangeHeight()
        {
            dgUserData.Height = dgUserData.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
        }

        private void ChangeWidth()
        {
            dgUserData.Width = dgUserData.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 20;
        }

        /// <summary>
        /// Метод для изменения размеров отображаемой таблицы в зависимости от операции со строками
        /// При добавлении строки таблица изменит размер на высоту одной строки
        /// При удалении строки таблица уменьшится на размер одной строки
        /// </summary>        
        private void NumericOrganizations_ValueChanged(object sender, EventArgs e)
        {
            int currentOrganizationsAmount = Convert.ToInt32(numericOrganizations.Value);
            if (previousOrganizationsAmount < currentOrganizationsAmount)
            {
                dgUserData.Rows.Add();
                int i = previousOrganizationsAmount++;
                dgUserData.Rows[i + 1].Cells[0].Value = "f" + (i + 1) + "(X" + (i + 1) + ")";
            }
            else
            {
                dgUserData.Rows.Remove(dgUserData.Rows[dgUserData.Rows.Count - 1]);
                int i = --previousOrganizationsAmount - 1;
                dgUserData.Rows[i + 1].Cells[0].Value = "f" + (i + 1) + "(X" + (i + 1) + ")";
            }
        }

        private void InitializeForm()
        {
            //инициализация количества строк по умолчанию
            previousOrganizationsAmount = Convert.ToInt32(numericOrganizations.Value);
            previousYearsAmount = Convert.ToInt32(numericYears.Value);
            previousColumnsAmount = Convert.ToInt32(numericColumns.Value);

            //первый столбец первой строки зарезервирован под описание столбца
            //запрещен для редактирования
            dgUserData.Rows.Add();
            dgUserData.Rows[0].Cells[0].Value = "Xi";

            //количество строк зависит от количество организаций
            for (int i = 0; i < numericOrganizations.Value; i++)
            {
                dgUserData.Rows.Add();
                dgUserData.Rows[i + 1].Cells[0].Value = "f" + (i + 1) + "(X" + (i + 1) + ")";
            }

            //количество столбцов зависит от выделяемой суммы
            for (int i = 0; i < numericColumns.Value; i++)
            {
                dgUserData.Columns.Add("Column" + (i + 1), "0");
            }
        }
    }
}


