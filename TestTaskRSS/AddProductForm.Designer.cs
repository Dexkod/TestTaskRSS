namespace TestTaskRSS
{
    partial class AddProductForm
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
            SaveButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CountTextBox = new TextBox();
            CountLabel = new Label();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(676, 376);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 53);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(327, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(107, 42);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Имя";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(316, 54);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(143, 27);
            NameTextBox.TabIndex = 2;
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(316, 129);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(143, 27);
            CountTextBox.TabIndex = 4;
            CountTextBox.Text = "0";
            // 
            // CountLabel
            // 
            CountLabel.Location = new Point(327, 84);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(107, 42);
            CountLabel.TabIndex = 3;
            CountLabel.Text = "Кол-во";
            CountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(316, 220);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(143, 27);
            PriceTextBox.TabIndex = 8;
            PriceTextBox.Text = "0";
            // 
            // PriceLabel
            // 
            PriceLabel.Location = new Point(327, 175);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(107, 42);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "Цена";
            PriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(287, 305);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(186, 27);
            DescriptionTextBox.TabIndex = 12;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Location = new Point(325, 260);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(107, 42);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Описание";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DescriptionTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(PriceTextBox);
            Controls.Add(PriceLabel);
            Controls.Add(CountTextBox);
            Controls.Add(CountLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(SaveButton);
            Name = "AddProductForm";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox CountTextBox;
        private Label CountLabel;
        private TextBox PriceTextBox;
        private Label PriceLabel;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}