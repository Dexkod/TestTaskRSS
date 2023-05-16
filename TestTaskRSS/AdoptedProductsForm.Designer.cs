namespace TestTaskRSS
{
    partial class AdoptedProductsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdoptedButton = new Button();
            InStockButton = new Button();
            SellsButton = new Button();
            ReportsButton = new Button();
            ProductsLabel = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // AdoptedButton
            // 
            AdoptedButton.Location = new Point(1, 0);
            AdoptedButton.Name = "AdoptedButton";
            AdoptedButton.Size = new Size(143, 69);
            AdoptedButton.TabIndex = 0;
            AdoptedButton.Text = "Принят";
            AdoptedButton.UseVisualStyleBackColor = true;
            // 
            // InStockButton
            // 
            InStockButton.Location = new Point(1, 66);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(143, 68);
            InStockButton.TabIndex = 1;
            InStockButton.Text = "На складе";
            InStockButton.UseVisualStyleBackColor = true;
            InStockButton.Click += InStockButton_Click;
            // 
            // SellsButton
            // 
            SellsButton.Location = new Point(1, 131);
            SellsButton.Name = "SellsButton";
            SellsButton.Size = new Size(143, 65);
            SellsButton.TabIndex = 2;
            SellsButton.Text = "Продано";
            SellsButton.UseVisualStyleBackColor = true;
            SellsButton.Click += SellsButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Location = new Point(1, 193);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(143, 65);
            ReportsButton.TabIndex = 3;
            ReportsButton.Text = "Отчеты";
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // ProductsLabel
            // 
            ProductsLabel.Location = new Point(323, 9);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(211, 56);
            ProductsLabel.TabIndex = 4;
            ProductsLabel.Text = "Принятые продукты";
            ProductsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(28, 385);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 43);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AdoptedProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(ProductsLabel);
            Controls.Add(ReportsButton);
            Controls.Add(SellsButton);
            Controls.Add(InStockButton);
            Controls.Add(AdoptedButton);
            Name = "AdoptedProductsForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AdoptedButton;
        private Button InStockButton;
        private Button SellsButton;
        private Button ReportsButton;
        private Label ProductsLabel;
        private Button AddButton;
    }
}