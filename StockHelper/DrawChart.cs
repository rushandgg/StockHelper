using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StockHelper
{
    public class DrawChart
    {
        // 차트를 그릴 때 쓸 class
        // Basic() 기본차트 그리기
        // Signal() 매수, 매도 시점 차트에 표시하기
        // News() 뉴스 뜬 날 차트에 표시하기
        // Keyword() 

        public void Basic(string[] stockDataArray)
        {
            string market = stockDataArray[0];
            string dataType = stockDataArray[1];
            string stockData = stockDataArray[2];

            LoadData loadData = new LoadData();
            DataTable priceTable = loadData.DayPrice(market, dataType, stockData);

        }
    }
}
