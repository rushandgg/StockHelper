using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StockHelper
{
    public class LoadData
    {
        // 데이터를 불러올 때 쓸 class
        // CreateDirectory() 저장할 폴더가 없을 경우 폴더를 생성해줌
        // Master() 국내주식 마스터 정보 불러오기
        // DayPrice() 국내주식 일별 주가 불러오기
        // News() 국내주식 종목별 뉴스 불러오기
        // Keyword() 국내주식 종목별 키워드 불러오기
        // SearchFormula() 조건식 불러오기
        // TradingRule() 매매규칙 불러오기
        
        // DB 입력정보
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=1111;Database=krx";

        public void CreateDirectory()
        {

            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string stockHelperPath = Path.Combine(myDocumentsPath, "StockHelper");
            string searchFormulasPath = Path.Combine(stockHelperPath, "SearchFormulas");
            string tradingRulesPath = Path.Combine(stockHelperPath, "TradingRules");

            // StockHelper 폴더 생성
            if (!Directory.Exists(stockHelperPath))
            {
                Directory.CreateDirectory(stockHelperPath);
            }

            // SearchFormulas 폴더 생성
            if (!Directory.Exists(searchFormulasPath))
            {
                Directory.CreateDirectory(searchFormulasPath);
            }

            // TradingRules 폴더 생성
            if (!Directory.Exists(tradingRulesPath))
            {
                Directory.CreateDirectory(tradingRulesPath);
            }
        }


        public DataTable Master(string market)
        {   // 국내주식 마스터 정보를 가져옴
            // name(종목명), code(종목코드), sector(업종), industry(산업)

            DataTable masterData = new DataTable();
            string masterSql = "";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    if (market == "kospi")
                    {
                        masterSql = "SELECT name, code, sector, industry FROM krx_schema.kospi_master;";
                    }
                    else if (market == "kosdaq")
                    {
                        masterSql = "SELECT name, code, sector, industry FROM krx_schema.kosdaq_master;";
                    }
                    
                    using (NpgsqlDataAdapter masterAdapter = new NpgsqlDataAdapter(masterSql, conn))
                    {
                        masterAdapter.Fill(masterData);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return masterData;
        }

        public DataTable DayPrice(string market)
        {   // 국내주식 일별 주가 정보를 가져옴
            // name(종목명), code(종목코드), date(날짜), open(시가), high(고가), low(저가), close(종가), volume(거래량), rate(등락률)
            
            DataTable dayPriceData = new DataTable();
            string dayPriceSql = "";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    if (market == "kospi")
                    {
                        dayPriceSql = "SELECT name, code, date, open, high, low, close, volume, rate FROM krx_schema.kospi;";
                    }
                    else if (market == "kosdaq")
                    {
                        dayPriceSql = "SELECT name, code, date, open, high, low, close, volume, rate FROM krx_schema.kosdaq;";
                    }
                    
                    using (NpgsqlDataAdapter dayPriceAdapter = new NpgsqlDataAdapter(dayPriceSql, conn))
                    {
                        dayPriceAdapter.Fill(dayPriceData);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dayPriceData;
        }

        public DataTable News(string market)
        {   // 국내주식 종목별 뉴스 정보를 가져옴
            // name(종목명), code(종목코드), date(날짜), title(뉴스제목)

            DataTable newsData = new DataTable();
            string newsSql = "";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    if (market == "kospi")
                    {
                        newsSql = "SELECT name, code, date, title FROM krx_schema.kospi_news;";
                    }
                    else if (market == "kosdaq")
                    {
                        newsSql = "SELECT name, code, date, title FROM krx_schema.kosdaq_news;";
                    }

                    using (NpgsqlDataAdapter newsAdapter = new NpgsqlDataAdapter(newsSql, conn))
                    {
                        newsAdapter.Fill(newsData);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return newsData;
        }

        public DataTable Keyword(string market)
        {   // 국내주식 종목별 뉴스 키워드 정보를 가져옴
            // name(종목명), code(종목코드), date(날짜), word1,2,3,4,5(키워드)

            DataTable keywordData = new DataTable();
            string keywordSql = "";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    if (market == "kospi")
                    {
                        keywordSql = "SELECT name, code, date, word1, word2, word3, word4, word5 FROM krx_schema.kospi_keyword;";
                    }
                    else if (market == "kosdaq")
                    {
                        keywordSql = "SELECT name, code, date, word1, word2, word3, word4, word5 FROM krx_schema.kosdaq_keyword;";
                    }

                    using (NpgsqlDataAdapter keywordAdapter = new NpgsqlDataAdapter(keywordSql, conn))
                    {
                        keywordAdapter.Fill(keywordData);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return keywordData;
        }
        /*
        public Dictionary<string, string> SearchFormula()
        {

        }
        */
    }
}
