namespace TestTaskRSS
{
    partial class ReportsForm
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
            StatusLabel = new Label();
            ReportsButton = new Button();
            SellsButton = new Button();
            InStockButton = new Button();
            AdoptedButton = new Button();
            AllCheckBox = new CheckBox();
            AdoptedCheckBox = new CheckBox();
            SellsCheckBox = new CheckBox();
            InStockCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.Location = new Point(200, 5);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(211, 56);
            StatusLabel.TabIndex = 18;
            StatusLabel.Text = "Статус";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportsButton
            // 
            ReportsButton.Location = new Point(1, 193);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(143, 65);
            ReportsButton.TabIndex = 17;
            ReportsButton.Text = "Отчеты";
            ReportsButton.UseVisualStyleBackColor = true;
            // 
            // SellsButton
            // 
            SellsButton.Location = new Point(1, 131);
            SellsButton.Name = "SellsButton";
            SellsButton.Size = new Size(143, 65);
            SellsButton.TabIndex = 16;
            SellsButton.Text = "Продано";
            SellsButton.UseVisualStyleBackColor = true;
            SellsButton.Click += SellsButton_Click;
            // 
            // InStockButton
            // 
            InStockButton.Location = new Point(1, 66);
            InStockButton.Name = "InStockButton";
            InStockButton.Size = new Size(143, 68);
            InStockButton.TabIndex = 15;
            InStockButton.Text = "На складе";
            InStockButton.UseVisualStyleBackColor = true;
            InStockButton.Click += InStockButton_Click;
            // 
            // AdoptedButton
            // 
            AdoptedButton.Location = new Point(1, 0);
            AdoptedButton.Name = "AdoptedButton";
            AdoptedButton.Size = new Size(143, 69);
            AdoptedButton.TabIndex = 14;
            AdoptedButton.Text = "Принят";
            AdoptedButton.UseVisualStyleBackColor = true;
            AdoptedButton.Click += AdoptedButton_Click;
            // 
            // AllCheckBox
            // 
            AllCheckBox.AutoSize = true;
            AllCheckBox.Location = new Point(417, 7);
            AllCheckBox.Name = "AllCheckBox";
            AllCheckBox.Size = new Size(55, 24);
            AllCheckBox.TabIndex = 19;
            AllCheckBox.Text = "Все";
            AllCheckBox.UseVisualStyleBackColor = true;
            AllCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // AdoptedCheckBox
            // 
            AdoptedCheckBox.AutoSize = true;
            AdoptedCheckBox.Location = new Point(417, 37);
            AdoptedCheckBox.Name = "AdoptedCheckBox";
            AdoptedCheckBox.Size = new Size(83, 24);
            AdoptedCheckBox.TabIndex = 20;
            AdoptedCheckBox.Text = "Принят";
            AdoptedCheckBox.UseVisualStyleBackColor = true;
            AdoptedCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // SellsCheckBox
            // 
            SellsCheckBox.AutoSize = true;
            SellsCheckBox.Location = new Point(524, 37);
            SellsCheckBox.Name = "SellsCheckBox";
            SellsCheckBox.Size = new Size(85, 24);
            SellsCheckBox.TabIndex = 21;
            SellsCheckBox.Text = "Продан";
            SellsCheckBox.UseVisualStyleBackColor = true;
            SellsCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // InStockCheckBox
            // 
            InStockCheckBox.AutoSize = true;
            InStockCheckBox.Location = new Point(524, 7);
            InStockCheckBox.Name = "InStockCheckBox";
            InStockCheckBox.Size = new Size(100, 24);
            InStockCheckBox.TabIndex = 22;
            InStockCheckBox.Text = "На складе";
            InStockCheckBox.UseVisualStyleBackColor = true;
            InStockCheckBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InStockCheckBox);
            Controls.Add(SellsCheckBox);
            Controls.Add(AdoptedCheckBox);
            Controls.Add(AllCheckBox);
            Controls.Add(StatusLabel);
            Controls.Add(ReportsButton);
            Controls.Add(SellsButton);
            Controls.Add(InStockButton);
            Controls.Add(AdoptedButton);
            Name = "ReportsForm";
            Text = "ReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatusLabel;
        private Button ReportsButton;
        private Button SellsButton;
        private Button InStockButton;
        private Button AdoptedButton;
        private CheckBox AllCheckBox;
        private CheckBox AdoptedCheckBox;
        private CheckBox SellsCheckBox;
        private CheckBox InStockCheckBox;
    }
}