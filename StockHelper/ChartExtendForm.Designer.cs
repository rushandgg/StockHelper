namespace StockHelper
{
    partial class ChartExtendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TechnicalIndicatorLV = new System.Windows.Forms.ListView();
            this.TIClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TISearchTB = new System.Windows.Forms.TextBox();
            this.TISearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TechnicalIndicatorLV
            // 
            this.TechnicalIndicatorLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TIClass,
            this.TIName});
            this.TechnicalIndicatorLV.FullRowSelect = true;
            this.TechnicalIndicatorLV.GridLines = true;
            this.TechnicalIndicatorLV.HideSelection = false;
            this.TechnicalIndicatorLV.Location = new System.Drawing.Point(12, 49);
            this.TechnicalIndicatorLV.MultiSelect = false;
            this.TechnicalIndicatorLV.Name = "TechnicalIndicatorLV";
            this.TechnicalIndicatorLV.Size = new System.Drawing.Size(215, 389);
            this.TechnicalIndicatorLV.TabIndex = 0;
            this.TechnicalIndicatorLV.UseCompatibleStateImageBehavior = false;
            this.TechnicalIndicatorLV.View = System.Windows.Forms.View.Details;
            // 
            // TIClass
            // 
            this.TIClass.Text = "분류";
            this.TIClass.Width = 80;
            // 
            // TIName
            // 
            this.TIName.Text = "지표이름";
            this.TIName.Width = 120;
            // 
            // TISearchTB
            // 
            this.TISearchTB.Location = new System.Drawing.Point(12, 12);
            this.TISearchTB.Name = "TISearchTB";
            this.TISearchTB.Size = new System.Drawing.Size(133, 21);
            this.TISearchTB.TabIndex = 1;
            // 
            // TISearchBtn
            // 
            this.TISearchBtn.Location = new System.Drawing.Point(151, 12);
            this.TISearchBtn.Name = "TISearchBtn";
            this.TISearchBtn.Size = new System.Drawing.Size(76, 21);
            this.TISearchBtn.TabIndex = 2;
            this.TISearchBtn.Text = "검색";
            this.TISearchBtn.UseVisualStyleBackColor = true;
            // 
            // ChartExtendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 450);
            this.Controls.Add(this.TISearchBtn);
            this.Controls.Add(this.TISearchTB);
            this.Controls.Add(this.TechnicalIndicatorLV);
            this.Name = "ChartExtendForm";
            this.Text = "ChartExtendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView TechnicalIndicatorLV;
        private System.Windows.Forms.ColumnHeader TIClass;
        private System.Windows.Forms.ColumnHeader TIName;
        private System.Windows.Forms.TextBox TISearchTB;
        private System.Windows.Forms.Button TISearchBtn;
    }
}