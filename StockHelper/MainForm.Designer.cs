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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MenuChartBtn = new System.Windows.Forms.Button();
            this.MenuDataBtn = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.chartPage = new System.Windows.Forms.TabPage();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.rulePage = new System.Windows.Forms.TabPage();
            this.apiPage = new System.Windows.Forms.TabPage();
            this.MenuRuleBtn = new System.Windows.Forms.Button();
            this.MenuApiBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockSearchGB = new System.Windows.Forms.GroupBox();
            this.StockNameLbl = new System.Windows.Forms.Label();
            this.StockNameTB = new System.Windows.Forms.TextBox();
            this.ChartSearchBtn = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.chartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.StockSearchGB.SuspendLayout();
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
            this.MainTabControl.ItemSize = new System.Drawing.Size(2, 1);
            this.MainTabControl.Location = new System.Drawing.Point(146, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1050, 616);
            this.MainTabControl.TabIndex = 2;
            // 
            // chartPage
            // 
            this.chartPage.Controls.Add(this.StockSearchGB);
            this.chartPage.Controls.Add(this.chart1);
            this.chartPage.Location = new System.Drawing.Point(4, 5);
            this.chartPage.Name = "chartPage";
            this.chartPage.Padding = new System.Windows.Forms.Padding(3);
            this.chartPage.Size = new System.Drawing.Size(1042, 607);
            this.chartPage.TabIndex = 0;
            this.chartPage.Text = "chartPage";
            this.chartPage.UseVisualStyleBackColor = true;
            // 
            // dataPage
            // 
            this.dataPage.Location = new System.Drawing.Point(4, 5);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(1042, 607);
            this.dataPage.TabIndex = 1;
            this.dataPage.Text = "dataPage";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // rulePage
            // 
            this.rulePage.Location = new System.Drawing.Point(4, 5);
            this.rulePage.Name = "rulePage";
            this.rulePage.Size = new System.Drawing.Size(1042, 607);
            this.rulePage.TabIndex = 2;
            this.rulePage.Text = "rulePage";
            this.rulePage.UseVisualStyleBackColor = true;
            // 
            // apiPage
            // 
            this.apiPage.Location = new System.Drawing.Point(4, 5);
            this.apiPage.Name = "apiPage";
            this.apiPage.Size = new System.Drawing.Size(1042, 607);
            this.apiPage.TabIndex = 3;
            this.apiPage.Text = "apiPage";
            this.apiPage.UseVisualStyleBackColor = true;
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
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(14, 169);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(325, 201);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // StockSearchGB
            // 
            this.StockSearchGB.Controls.Add(this.ChartSearchBtn);
            this.StockSearchGB.Controls.Add(this.StockNameTB);
            this.StockSearchGB.Controls.Add(this.StockNameLbl);
            this.StockSearchGB.Location = new System.Drawing.Point(6, 6);
            this.StockSearchGB.Name = "StockSearchGB";
            this.StockSearchGB.Size = new System.Drawing.Size(735, 121);
            this.StockSearchGB.TabIndex = 1;
            this.StockSearchGB.TabStop = false;
            this.StockSearchGB.Text = "종목 검색";
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
            // StockNameTB
            // 
            this.StockNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StockNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.StockNameTB.Location = new System.Drawing.Point(111, 20);
            this.StockNameTB.Name = "StockNameTB";
            this.StockNameTB.Size = new System.Drawing.Size(100, 21);
            this.StockNameTB.TabIndex = 1;
            this.StockNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockNameTB_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.StockSearchGB.ResumeLayout(false);
            this.StockSearchGB.PerformLayout();
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
        public System.Windows.Forms.TextBox StockNameTB;
    }
}

