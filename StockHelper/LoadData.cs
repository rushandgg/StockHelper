using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockHelper
{
    public class LoadData
    {
        // 데이터를 불러올 때 쓸 class
        // Master() 국내주식 마스터 정보 불러오기
        // DayPrice() 국내주식 일별 주가 불러오기
        // News() 국내주식 종목별 뉴스 불러오기
        // Keyword() 국내주식 종목별 키워드 불러오기

        readonly string connString = "Host=localhost;" +
            "Username=postgres;" +
            "Password=1111;" +
            "Database=krx";

        private DataTable Master()
        {   // 국내주식 마스터 정보를 가져옴
            // name(종목명), code(종목코드), sector(업종), industry(산업)

            DataTable MasterData = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    DataTable kospiMasterData = new DataTable();
                    DataTable kosdaqMasterData = new DataTable();

                    string kospiMasterSql = "SELECT name, code, sector, industry FROM krx_schema.kospi_master";
                    string kosdaqMasterSql = "SELECT name, code, sector, industry FROM krx_schema.kosdaq_master";

                    // Fill kospiData
                    using (NpgsqlDataAdapter kospiMasterAdapter = new NpgsqlDataAdapter(kospiMasterSql, conn))
                    {
                        kospiMasterAdapter.Fill(kospiMasterData);
                    }

                    // Fill kosdaqData
                    using (NpgsqlDataAdapter kosdaqMasterAdapter = new NpgsqlDataAdapter(kosdaqMasterSql, conn))
                    {
                        kosdaqMasterAdapter.Fill(kosdaqMasterData);
                    }

                    MasterData.Merge(kospiMasterData);
                    MasterData.Merge(kosdaqMasterData);
                    
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
            return MasterData;
        }

        private DataTable DayPrice()
        {
            DataTable DayPriceData = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    DataTable kospiDayPriceData = new DataTable();
                    DataTable kosdaqDayPriceData = new DataTable();

                    string kospiDayPriceSql = "SELECT name, code, date, open, high, low, close, volume, rate FROM krx_schema.kospi";
                    string kosdaqDayPriceSql = "SELECT name, code, date, open, high, low, close, volume, rate FROM krx_schema.kosdaq";

                    // Fill kospiData
                    using (NpgsqlDataAdapter kospiDayPriceAdapter = new NpgsqlDataAdapter(kospiDayPriceSql, conn))
                    {
                        kospiDayPriceAdapter.Fill(kospiDayPriceData);
                    }

                    // Fill kosdaqData
                    using (NpgsqlDataAdapter kosdaqDayPriceAdapter = new NpgsqlDataAdapter(kosdaqDayPriceSql, conn))
                    {
                        kosdaqDayPriceAdapter.Fill(kosdaqDayPriceData);
                    }

                    DayPriceData.Merge(kospiDayPriceData);
                    DayPriceData.Merge(kosdaqDayPriceData);

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            return DayPriceData;
        }

        private DataTable News()
        {

        }

        private DataTable Keyword()
        {
            DataTable KeywordData = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    DataTable kospiKeywordData = new DataTable();
                    DataTable kosdaqKeywordData = new DataTable();

                    string kospiKeywordSql = "SELECT name, code, date, word1, word2, word3, word4, word5 FROM krx_schema.kospi_keyword";
                    string kosdaqKeywordSql = "SELECT name, code, date, word1, word2, word3, word4, word5 FROM krx_schema.kosdaq_keyword";

                    // Fill kospiData
                    using (NpgsqlDataAdapter kospiKeywordAdapter = new NpgsqlDataAdapter(kospiKeywordSql, conn))
                    {
                        kospiKeywordAdapter.Fill(kospiKeywordData);
                    }

                    // Fill kosdaqData
                    using (NpgsqlDataAdapter kosdaqKeywordAdapter = new NpgsqlDataAdapter(kosdaqKeywordSql, conn))
                    {
                        kosdaqKeywordAdapter.Fill(kosdaqKeywordData);
                    }

                    KeywordData.Merge(kospiKeywordData);
                    KeywordData.Merge(kosdaqKeywordData);

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            return KeywordData;
        }
    }
}
