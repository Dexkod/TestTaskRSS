using Db.Context.Rep;
using Db.Entities;
using Db.Validation;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskRSS
{
    public partial class AddProductForm : Form
    {
        IRepository _repository;
        public AddProductForm()
        {
            InitializeComponent();
            _repository = Repository.Instance;
        }

        /// <summary>
        /// Сохранение созданных продуктов
        /// </summary>
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (Controls.ContainsKey("ErorMessageLabel"))
            {
                Controls.RemoveByKey("ErorMessageLabel");
            }

            if (PriceTextBox.Text.Any(ch => char.IsLetter(ch)) || PriceTextBox.Text.IsNullOrEmpty())
            {
                PriceTextBox.Text = "0";
            }
            if (CountTextBox.Text.Any(ch => char.IsLetter(ch)) || CountTextBox.Text.IsNullOrEmpty())
            {
                CountTextBox.Text = "0";
            }
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            int count = Convert.ToInt32(CountTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);

            Product product = new Product(name, description, price, count);

            if (!ValidationProduct.IsValidationAdd(product, out string message))
            {
                CreateLabelErrorMessage(message);
                return;
            }

            //Создаем сразу статус и прикрепляем к продукту
            DateTime now = DateTime.Now;

            await _repository.AddStatusAsync(new Status("Принят", now));
            await _repository.SaveChangesAsync();

            int id = (await _repository.GetStatusesAsync())
                .FirstOrDefault(x => x.AdoptedTime.Equals(now)).Id;

            product.StatusId = id;
            await _repository.AddProductAsync(product);
            await _repository.SaveChangesAsync();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void CreateLabelErrorMessage(string message)
        {
            Label label = new Label
            {
                Location = new System.Drawing.Point(DescriptionTextBox.Location.X,
                    DescriptionTextBox.Location.Y + 40),
                ForeColor = Color.Red,
                AutoSize = true,
                Text = message,
                Name = "ErorMessageLabel"
            };

            Controls.Add(label);
        }

      
    }


}
