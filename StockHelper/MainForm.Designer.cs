namespace StockHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MenuChartBtn = new System.Windows.Forms.Button();
            this.MenuDataBtn = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.StockSearchGB = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ChartSearchBtn = new System.Windows.Forms.Button();
            this.StockDataTB = new System.Windows.Forms.TextBox();
            this.StockNameLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.rulePage = new System.Windows.Forms.TabPage();
            this.apiPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SecuritiesApiGB = new System.Windows.Forms.GroupBox();
            this.SecuritiesLoginBtn = new System.Windows.Forms.Button();
            this.LsCertTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LsPwTb = new System.Windows.Forms.TextBox();
            this.LsIdTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KiwoomCertTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KiwoomPwTB = new System.Windows.Forms.TextBox();
            this.KiwoomIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecuritiesIdLbl = new System.Windows.Forms.Label();
            this.LsLbl = new System.Windows.Forms.Label();
            this.KiwoomLbl = new System.Windows.Forms.Label();
            this.MenuRuleBtn = new System.Windows.Forms.Button();
            this.MenuApiBtn = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainTabControl.SuspendLayout();
            this.chartPage.SuspendLayout();
            this.StockSearchGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.apiPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SecuritiesApiGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuChartBtn
            // 
            this.MenuChartBtn.Location = new System.Drawing.Point(12, 12);
            this.MenuChartBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MenuChartBtn.Name = "MenuChartBtn";
            this.MenuChartBtn.Size = new System.Drawing.Size(131, 66);
            this.MenuChartBtn.TabIndex = 0;
            this.MenuChartBtn.Text = "1. 차트";
            this.MenuChartBtn.UseVisualStyleBackColor = true;
            this.MenuChartBtn.Click += new System.EventHandler(this.MenuChartBtn_Click);
            // 
            // MenuDataBtn
            // 
            this.MenuDataBtn.Location = new System.Drawing.Point(12, 78);
            this.MenuDataBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MenuDataBtn.Name = "MenuDataBtn";
            this.MenuDataBtn.Size = new System.Drawing.Size(131, 66);
            this.MenuDataBtn.TabIndex = 1;
            this.MenuDataBtn.Text = "2. 데이터";
            this.MenuDataBtn.UseVisualStyleBackColor = true;
            this.MenuDataBtn.Click += new System.EventHandler(this.MenuDataBtn_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.chartPage);
            this.MainTabControl.Controls.Add(this.dataPage);
            this.MainTabControl.Controls.Add(this.rulePage);
            this.MainTabControl.Controls.Add(this.apiPage);
            this.MainTabControl.ItemSize = new System.Drawing.Size(10, 20);
            this.MainTabControl.Location = new System.Drawing.Point(146, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1050, 616);
            this.MainTabControl.TabIndex = 2;
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.chart2);
            this.chartPage.Controls.Add(this.StockSearchGB);
            this.chartPage.Controls.Add(this.chart1);
            this.chartPage.Location = new System.Drawing.Point(4, 24);
            this.chartPage.Name = "chartPage";
            this.chartPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartPage.Size = new System.Drawing.Size(1042, 588);
            this.chartPage.TabIndex = 0;
            this.chartPage.Text = "chartPage";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // StockSearchGB
            // 
            this.StockSearchGB.Controls.Add(this.button2);
            this.StockSearchGB.Controls.Add(this.ChartSearchBtn);
            this.StockSearchGB.Controls.Add(this.StockDataTB);
            this.StockSearchGB.Controls.Add(this.StockNameLbl);
            this.StockSearchGB.Location = new System.Drawing.Point(6, 6);
            this.StockSearchGB.Name = "StockSearchGB";
            this.StockSearchGB.Size = new System.Drawing.Size(735, 121);
            this.StockSearchGB.TabIndex = 1;
            this.StockSearchGB.TabStop = false;
            this.StockSearchGB.Text = "종목 검색";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChartSearchBtn
            // 
            this.ChartSearchBtn.Location = new System.Drawing.Point(415, 18);
            this.ChartSearchBtn.Name = "ChartSearchBtn";
            this.ChartSearchBtn.Size = new System.Drawing.Size(120, 29);
            this.ChartSearchBtn.TabIndex = 2;
            this.ChartSearchBtn.Text = "조회";
            this.ChartSearchBtn.UseVisualStyleBackColor = true;
            this.ChartSearchBtn.Click += new System.EventHandler(this.ChartSearchBtn_Click);
            // 
            // StockDataTB
            // 
            this.StockDataTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StockDataTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StockDataTB.Location = new System.Drawing.Point(111, 20);
            this.StockDataTB.Name = "StockDataTB";
            this.StockDataTB.Size = new System.Drawing.Size(100, 21);
            this.StockDataTB.TabIndex = 1;
            this.StockDataTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockNameTB_KeyDown);
            // 
            // StockNameLbl
            // 
            this.StockNameLbl.AutoSize = true;
            this.StockNameLbl.Location = new System.Drawing.Point(6, 26);
            this.StockNameLbl.Name = "StockNameLbl";
            this.StockNameLbl.Size = new System.Drawing.Size(99, 12);
            this.StockNameLbl.TabIndex = 0;
            this.StockNameLbl.Text = "종목명(종목코드)";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 142);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(727, 236);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataPage
            // 
            this.dataPage.Location = new System.Drawing.Point(4, 24);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(1042, 588);
            this.dataPage.TabIndex = 1;
            this.dataPage.Text = "dataPage";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // rulePage
            // 
            this.rulePage.Location = new System.Drawing.Point(4, 24);
            this.rulePage.Name = "rulePage";
            this.rulePage.Size = new System.Drawing.Size(1042, 588);
            this.rulePage.TabIndex = 2;
            this.rulePage.Text = "rulePage";
            this.rulePage.UseVisualStyleBackColor = true;
            // 
            // apiPage
            // 
            this.apiPage.Controls.Add(this.groupBox1);
            this.apiPage.Controls.Add(this.SecuritiesApiGB);
            this.apiPage.Location = new System.Drawing.Point(4, 24);
            this.apiPage.Name = "apiPage";
            this.apiPage.Size = new System.Drawing.Size(1042, 588);
            this.apiPage.TabIndex = 3;
            this.apiPage.Text = "apiPage";
            this.apiPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(20, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 159);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ChatGPT API";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID";
            // 
            // SecuritiesApiGB
            // 
            this.SecuritiesApiGB.Controls.Add(this.SecuritiesLoginBtn);
            this.SecuritiesApiGB.Controls.Add(this.LsCertTB);
            this.SecuritiesApiGB.Controls.Add(this.label3);
            this.SecuritiesApiGB.Controls.Add(this.LsPwTb);
            this.SecuritiesApiGB.Controls.Add(this.LsIdTB);
            this.SecuritiesApiGB.Controls.Add(this.label4);
            this.SecuritiesApiGB.Controls.Add(this.label5);
            this.SecuritiesApiGB.Controls.Add(this.KiwoomCertTB);
            this.SecuritiesApiGB.Controls.Add(this.label2);
            this.SecuritiesApiGB.Controls.Add(this.KiwoomPwTB);
            this.SecuritiesApiGB.Controls.Add(this.KiwoomIdTB);
            this.SecuritiesApiGB.Controls.Add(this.label1);
            this.SecuritiesApiGB.Controls.Add(this.SecuritiesIdLbl);
            this.SecuritiesApiGB.Controls.Add(this.LsLbl);
            this.SecuritiesApiGB.Controls.Add(this.KiwoomLbl);
            this.SecuritiesApiGB.Location = new System.Drawing.Point(20, 21);
            this.SecuritiesApiGB.Name = "SecuritiesApiGB";
            this.SecuritiesApiGB.Size = new System.Drawing.Size(707, 159);
            this.SecuritiesApiGB.TabIndex = 1;
            this.SecuritiesApiGB.TabStop = false;
            this.SecuritiesApiGB.Text = "증권사 API";
            // 
            // SecuritiesLoginBtn
            // 
            this.SecuritiesLoginBtn.Location = new System.Drawing.Point(417, 82);
            this.SecuritiesLoginBtn.Name = "SecuritiesLoginBtn";
            this.SecuritiesLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.SecuritiesLoginBtn.TabIndex = 14;
            this.SecuritiesLoginBtn.Text = "로그인";
            this.SecuritiesLoginBtn.UseVisualStyleBackColor = true;
            // 
            // LsCertTB
            // 
            this.LsCertTB.Location = new System.Drawing.Point(233, 116);
            this.LsCertTB.Name = "LsCertTB";
            this.LsCertTB.Size = new System.Drawing.Size(121, 21);
            this.LsCertTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cert";
            // 
            // LsPwTb
            // 
            this.LsPwTb.Location = new System.Drawing.Point(233, 84);
            this.LsPwTb.Name = "LsPwTb";
            this.LsPwTb.Size = new System.Drawing.Size(121, 21);
            this.LsPwTb.TabIndex = 11;
            // 
            // LsIdTB
            // 
            this.LsIdTB.Location = new System.Drawing.Point(233, 52);
            this.LsIdTB.Name = "LsIdTB";
            this.LsIdTB.Size = new System.Drawing.Size(121, 21);
            this.LsIdTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "PW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // KiwoomCertTB
            // 
            this.KiwoomCertTB.Location = new System.Drawing.Point(53, 116);
            this.KiwoomCertTB.Name = "KiwoomCertTB";
            this.KiwoomCertTB.Size = new System.Drawing.Size(121, 21);
            this.KiwoomCertTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cert";
            // 
            // KiwoomPwTB
            // 
            this.KiwoomPwTB.Location = new System.Drawing.Point(53, 84);
            this.KiwoomPwTB.Name = "KiwoomPwTB";
            this.KiwoomPwTB.Size = new System.Drawing.Size(121, 21);
            this.KiwoomPwTB.TabIndex = 5;
            // 
            // KiwoomIdTB
            // 
            this.KiwoomIdTB.Location = new System.Drawing.Point(53, 52);
            this.KiwoomIdTB.Name = "KiwoomIdTB";
            this.KiwoomIdTB.Size = new System.Drawing.Size(121, 21);
            this.KiwoomIdTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "PW";
            // 
            // SecuritiesIdLbl
            // 
            this.SecuritiesIdLbl.AutoSize = true;
            this.SecuritiesIdLbl.Location = new System.Drawing.Point(22, 57);
            this.SecuritiesIdLbl.Name = "SecuritiesIdLbl";
            this.SecuritiesIdLbl.Size = new System.Drawing.Size(16, 12);
            this.SecuritiesIdLbl.TabIndex = 2;
            this.SecuritiesIdLbl.Text = "ID";
            // 
            // LsLbl
            // 
            this.LsLbl.AutoSize = true;
            this.LsLbl.Location = new System.Drawing.Point(231, 31);
            this.LsLbl.Name = "LsLbl";
            this.LsLbl.Size = new System.Drawing.Size(44, 12);
            this.LsLbl.TabIndex = 1;
            this.LsLbl.Text = "LS증권";
            // 
            // KiwoomLbl
            // 
            this.KiwoomLbl.AutoSize = true;
            this.KiwoomLbl.Location = new System.Drawing.Point(51, 31);
            this.KiwoomLbl.Name = "KiwoomLbl";
            this.KiwoomLbl.Size = new System.Drawing.Size(53, 12);
            this.KiwoomLbl.TabIndex = 0;
            this.KiwoomLbl.Text = "키움증권";
            // 
            // MenuRuleBtn
            // 
            this.MenuRuleBtn.Location = new System.Drawing.Point(12, 144);
            this.MenuRuleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MenuRuleBtn.Name = "MenuRuleBtn";
            this.MenuRuleBtn.Size = new System.Drawing.Size(131, 66);
            this.MenuRuleBtn.TabIndex = 3;
            this.MenuRuleBtn.Text = "3. 조건식";
            this.MenuRuleBtn.UseVisualStyleBackColor = true;
            this.MenuRuleBtn.Click += new System.EventHandler(this.MenuRuleBtn_Click);
            // 
            // MenuApiBtn
            // 
            this.MenuApiBtn.Location = new System.Drawing.Point(12, 210);
            this.MenuApiBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MenuApiBtn.Name = "MenuApiBtn";
            this.MenuApiBtn.Size = new System.Drawing.Size(131, 66);
            this.MenuApiBtn.TabIndex = 4;
            this.MenuApiBtn.Text = "4. API";
            this.MenuApiBtn.UseVisualStyleBackColor = true;
            this.MenuApiBtn.Click += new System.EventHandler(this.MenuApiBtn_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 384);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(727, 119);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 640);
            this.Controls.Add(this.MenuApiBtn);
            this.Controls.Add(this.MenuRuleBtn);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MenuDataBtn);
            this.Controls.Add(this.MenuChartBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.chartPage.ResumeLayout(false);
            this.StockSearchGB.ResumeLayout(false);
            this.StockSearchGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.apiPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SecuritiesApiGB.ResumeLayout(false);
            this.SecuritiesApiGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuChartBtn;
        private System.Windows.Forms.Button MenuDataBtn;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage chartPage;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage rulePage;
        private System.Windows.Forms.TabPage apiPage;
        private System.Windows.Forms.Button MenuRuleBtn;
        private System.Windows.Forms.Button MenuApiBtn;
        private System.Windows.Forms.GroupBox StockSearchGB;
        private System.Windows.Forms.Label StockNameLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ChartSearchBtn;
        public System.Windows.Forms.TextBox StockDataTB;
        private System.Windows.Forms.GroupBox SecuritiesApiGB;
        private System.Windows.Forms.TextBox KiwoomPwTB;
        private System.Windows.Forms.TextBox KiwoomIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SecuritiesIdLbl;
        private System.Windows.Forms.Label LsLbl;
        private System.Windows.Forms.Label KiwoomLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KiwoomCertTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SecuritiesLoginBtn;
        private System.Windows.Forms.TextBox LsCertTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LsPwTb;
        private System.Windows.Forms.TextBox LsIdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

