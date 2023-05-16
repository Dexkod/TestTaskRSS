namespace TestTaskRSS
{
    partial class InStockForm
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
            ReportsButton = new Button();
            SellsButton = new Button();
            InStockButton = new Button();
            AdoptedButton = new Button();
            ProductsLabel = new Label();
            SuspendLayout();
            // 
            // ReportsButton
            // 
            ReportsButton.Location = new Point(1, 194);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(143, 65);
            ReportsButton.TabIndex = 7;
            ReportsButton.Text = "Отчеты";
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // SellsButton
            // 
            SellsButton.Location = new Point(1, 132);
            SellsButton.Name = "SellsButton";
            SellsButton.Size = new Size(143, 65);
            SellsButton.TabIndex = 6;
            SellsButton.Text = "Продано";
            SellsButton.UseVisualStyleBackColor = true;
            SellsButton.Click += SellsButton_Click;
            // 
            // InStockButton
            // 
            InStockButton.Location = new Point(1, 67);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(143, 68);
            InStockButton.TabIndex = 5;
            InStockButton.Text = "На складе";
            InStockButton.UseVisualStyleBackColor = true;
            // 
            // AdoptedButton
            // 
            AdoptedButton.Location = new Point(1, 1);
            AdoptedButton.Name = "AdoptedButton";
            AdoptedButton.Size = new Size(143, 69);
            AdoptedButton.TabIndex = 4;
            AdoptedButton.Text = "Принят";
            AdoptedButton.UseVisualStyleBackColor = true;
            AdoptedButton.Click += AdoptedButton_Click;
            // 
            // ProductsLabel
            // 
            ProductsLabel.Location = new Point(329, 7);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(211, 56);
            ProductsLabel.TabIndex = 8;
            ProductsLabel.Text = "Продукты на складе";
            ProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductsLabel);
            Controls.Add(ReportsButton);
            Controls.Add(SellsButton);
            Controls.Add(InStockButton);
            Controls.Add(AdoptedButton);
            Name = "InStockForm";
            Text = "InStockForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ReportsButton;
        private Button SellsButton;
        private Button InStockButton;
        private Button AdoptedButton;
        private Label ProductsLabel;
    }
}