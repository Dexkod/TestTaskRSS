namespace TestTaskRSS
{
    partial class SellsForm
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
            ProductsLabel = new Label();
            ReportsButton = new Button();
            SellsButton = new Button();
            InStockButton = new Button();
            AdoptedButton = new Button();
            SuspendLayout();
            // 
            // ProductsLabel
            // 
            ProductsLabel.Location = new Point(329, 6);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(211, 56);
            ProductsLabel.TabIndex = 13;
            ProductsLabel.Text = "Проданные продукты";
            ProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportsButton
            // 
            ReportsButton.Location = new Point(1, 193);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(143, 65);
            ReportsButton.TabIndex = 12;
            ReportsButton.Text = "Отчеты";
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // SellsButton
            // 
            SellsButton.Location = new Point(1, 131);
            SellsButton.Name = "SellsButton";
            SellsButton.Size = new Size(143, 65);
            SellsButton.TabIndex = 11;
            SellsButton.Text = "Продано";
            SellsButton.UseVisualStyleBackColor = true;
            // 
            // InStockButton
            // 
            InStockButton.Location = new Point(1, 66);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(143, 68);
            InStockButton.TabIndex = 10;
            InStockButton.Text = "На складе";
            InStockButton.UseVisualStyleBackColor = true;
            InStockButton.Click += InStockButton_Click;
            // 
            // AdoptedButton
            // 
            AdoptedButton.Location = new Point(1, 0);
            AdoptedButton.Name = "AdoptedButton";
            AdoptedButton.Size = new Size(143, 69);
            AdoptedButton.TabIndex = 9;
            AdoptedButton.Text = "Принят";
            AdoptedButton.UseVisualStyleBackColor = true;
            AdoptedButton.Click += AdoptedButton_Click;
            // 
            // SellsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductsLabel);
            Controls.Add(ReportsButton);
            Controls.Add(SellsButton);
            Controls.Add(InStockButton);
            Controls.Add(AdoptedButton);
            Name = "SellsForm";
            Text = "SellsForm";
            ResumeLayout(false);
        }

        #endregion

        private Label ProductsLabel;
        private Button ReportsButton;
        private Button SellsButton;
        private Button InStockButton;
        private Button AdoptedButton;
    }
}