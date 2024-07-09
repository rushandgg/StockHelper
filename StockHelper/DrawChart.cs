using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace StockHelper
{
    public class DrawChart
    {
        // 차트를 그릴 때 쓸 class
        // Basic() 기본차트 그리기
        // Signal() 매수, 매도 시점 차트에 표시하기
        // News() 뉴스 뜬 날 차트에 표시하기
        // Keyword() 

        MainForm mainForm;

        public void Basic(string[] stockDataArray)
        {
            mainForm = new MainForm();

            string market = stockDataArray[0];
            string dataType = stockDataArray[1];
            string stockData = stockDataArray[2];

            // DB에서 데이터 가져옴
            LoadData loadData = new LoadData();
            DataTable priceTable = loadData.DayPrice(market, dataType, stockData);

            // 가져온 데이터 차트로 그리기
            var plotView = new PlotView { Dock = System.Windows.Forms.DockStyle.Fill };
            var plotModel = new PlotModel { Title = "Candlestick Chart" };

            var candleStickSeries = new CandleStickSeries
            {
                Color = OxyColors.Black,
                IncreasingColor = OxyColors.Green,
                DecreasingColor = OxyColors.Red
            };

            foreach (DataRow row in priceTable.Rows)
            {
                DateTime date = Convert.ToDateTime(row["date"]);
                double open = Convert.ToDouble(row["open"]);
                double high = Convert.ToDouble(row["high"]);
                double low = Convert.ToDouble(row["low"]);
                double close = Convert.ToDouble(row["close"]);

                candleStickSeries.Items.Add(new HighLowItem(date.ToOADate(), high, low, open, close));
            }

            plotModel.Series.Add(candleStickSeries);
            plotView.Model = plotModel;
            
            mainForm.Controls.Add(plotView);

            mainForm.StockDGV.DataSource = priceTable;
        }
    }
}
