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

namespace StockHelper
{
    public partial class MainForm : Form
    {
        List<string> kospiStockNameList = new List<string>();
        List<string> kosdaqStockNameList = new List<string>();
        List<string> kospiStockCodeList = new List<string>();
        List<string> kosdaqStockCodeList = new List<string>();

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
            StockNameTB.AutoCompleteCustomSource = autoCompleteCollection;
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

                DrawChart drawChart = new DrawChart();
                drawChart.Basic();
            }
        }

        private void ChartSearchBtn_Click(object sender, EventArgs e)
        {
            DrawChart drawChart = new DrawChart();
            drawChart.Basic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData loadData = new LoadData();
            DataTable master = loadData.Master("kospi");

            Console.WriteLine(master.Rows.Count);
        }
    }
}
