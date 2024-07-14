using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using OxyPlot;
using OxyPlot.Series;

namespace StockHelper
{
    public partial class MainForm : Form
    {
        List<string> kospiStockNameList = new List<string>();
        List<string> kosdaqStockNameList = new List<string>();
        List<string> kospiStockCodeList = new List<string>();
        List<string> kosdaqStockCodeList = new List<string>();

        ChartExtendForm chartExtendForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 저장 폴더 생성
            LoadData loadData = new LoadData();
            loadData.CreateDirectory();

            // 마스터 정보 불러오기
            MakeSource makeSource = new MakeSource();
            kospiStockNameList = makeSource.StockList("kospi", "name");
            kospiStockCodeList = makeSource.StockList("kospi", "code");
            kosdaqStockNameList = makeSource.StockList("kosdaq", "name");
            kosdaqStockCodeList = makeSource.StockList("kosdaq", "code");

            // 자동완성 소스 목록 구성
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(kospiStockNameList.ToArray());
            autoCompleteCollection.AddRange(kospiStockCodeList.ToArray());
            autoCompleteCollection.AddRange(kosdaqStockNameList.ToArray());
            autoCompleteCollection.AddRange(kosdaqStockCodeList.ToArray());

            // 자동완성 소스 채우기
            StockDataTB.AutoCompleteCustomSource = autoCompleteCollection;
        }


        private void MenuChartBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 0;
        }

        private void MenuDataBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 1;
        }

        private void MenuRuleBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 2;
        }

        private void MenuApiBtn_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedIndex = 3;
        }

        private void StockNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string stockData = StockDataTB.Text;
                string[] stockDataArray = DetermineNameCode(stockData);

                DrawChart drawChart = new DrawChart();
                drawChart.Basic(stockDataArray);
            }
        }

        private void ChartSearchBtn_Click(object sender, EventArgs e)
        {
            string stockData = StockDataTB.Text;
            string[] stockDataArray = DetermineNameCode(stockData);
            
            DrawChart drawChart = new DrawChart();
            drawChart.Basic(stockDataArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {   // 테스트용
            LoadData loadData = new LoadData();
            DataTable master = loadData.Master("kospi");

            Console.WriteLine(master.Rows.Count);
        }

        public string[] DetermineNameCode(string stockData)
        {   // TextBox에 있는 내용이 코스피인지 코스닥인지, 종목명인지 종목코드인지 판별해서 넘겨줌

            string[] stockDataArray = new string[3];
            stockDataArray[2] = stockData;

            if (kospiStockNameList.Contains(stockData))
            {
                stockDataArray[0] = "kospi";
                stockDataArray[1] = "name";
            }
            else if (kospiStockCodeList.Contains(stockData))
            {
                stockDataArray[0] = "kospi";
                stockDataArray[1] = "code";
            }
            else if (kosdaqStockNameList.Contains(stockData))
            {
                stockDataArray[0] = "kosdaq";
                stockDataArray[1] = "name";
            }
            else if (kosdaqStockCodeList.Contains(stockData))
            {
                stockDataArray[0] = "kosdaq";
                stockDataArray[1] = "code";
            }

            return stockDataArray;
        }

        private void ChartExtendBtn_Click(object sender, EventArgs e)
        {
            if (chartExtendForm == null || chartExtendForm.IsDisposed)
            {
                chartExtendForm = new ChartExtendForm();
                chartExtendForm.StartPosition = FormStartPosition.Manual;
                chartExtendForm.Location = new System.Drawing.Point(this.Right, this.Top);
                chartExtendForm.Show();
            }
            else
            {
                chartExtendForm.BringToFront(); // Form2를 맨 앞으로 가져옴
                chartExtendForm.WindowState = FormWindowState.Normal; // 최소화 상태일 경우 복원
                chartExtendForm.Focus(); 
            }
        }
    }
}
