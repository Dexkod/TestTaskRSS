using Db.Context.Rep;
using Db.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskRSS.UI;

namespace TestTaskRSS
{
    public partial class SellsForm : Form
    {
        private List<Product> _products;
        private readonly IRepository _repository;
        private List<Label> _productLabels = new List<Label>();
        private int _lastIndexLabelOnView = 0;

        public SellsForm()
        {
            _repository = Repository.Instance;
            GetProductsSell();
        }
        // Получение всех продуктов с стасусом Продан
        private async void GetProductsSell()
        {
            var allProducts = await _repository.Context.GetProductsAsync();
            var allStatuses = await _repository.Context.GetStatusesAsync();
            allStatuses = allStatuses.Where(x => x.Name.Equals("Продан")).ToList();


            _products = allProducts.Where(product => allStatuses
                .Any(status => product.StatusId == status.Id)).ToList();
            CreateProductLabels();
            ViewAddProductLabels();
        }

        private void CreateProductLabels()
        {
            _productLabels = HelperUI.CreateProductLabels(_products);
        }

        private void ViewAddProductLabels()
        {
            if (_productLabels.Count > _lastIndexLabelOnView)
            {
                Controls.Add(_productLabels[_lastIndexLabelOnView++]);
            }
            if (_productLabels.Count > _lastIndexLabelOnView)
            {
                Controls.Add(_productLabels[_lastIndexLabelOnView++]);
            }

            if (_productLabels.Count > _lastIndexLabelOnView)
            {
                if (!Controls.ContainsKey("NextButton"))
                {
                    CreateNextButton();
                }
            }
            else
            {
                if (Controls.ContainsKey("NextButton"))
                {
                    Controls.RemoveByKey("NextButton");
                }
            }

            if (_lastIndexLabelOnView - 2 > 0)
            {
                if (!Controls.ContainsKey("PreviousButton"))
                {
                    CreatePreviousButton();
                }
            }
            else
            {
                if (Controls.ContainsKey("PreviousButton"))
                {
                    Controls.RemoveByKey("PreviousButton");
                }
            }

            InitializeComponent();
        }

        private void CreatePreviousButton()
        {
            Button button = HelperUI.CreatePreviousButton();
            button.Click += MovePrevious;

            Controls.Add(button);
        }

        private void MovePrevious(object sender, EventArgs e)
        {
            RemoveViewProductLabels();
            _lastIndexLabelOnView = _lastIndexLabelOnView > 1 ?
                _lastIndexLabelOnView - 2 : _lastIndexLabelOnView - 1;
            ViewAddProductLabels();
        }

        private void CreateNextButton()
        {
            Button button = HelperUI.CreateNextButton();
            button.Click += MoveNext;

            Controls.Add(button);
        }

        private void MoveNext(object sender, EventArgs e)
        {
            RemoveViewProductLabels();
            _lastIndexLabelOnView = _lastIndexLabelOnView + 2 < _products.Count
                ? _lastIndexLabelOnView + 2 : _lastIndexLabelOnView + 1;
            ViewAddProductLabels();
        }
        private void RemoveViewProductLabels()
        {
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
        }

        private void AdoptedButton_Click(object sender, EventArgs e)
        {
            AdoptedProductsForm adoptedProductsForm = new AdoptedProductsForm();
            adoptedProductsForm.Show();
            this.Hide();
        }

        private void InStockButton_Click(object sender, EventArgs e)
        {
            InStockForm inStockForm = new InStockForm();
            inStockForm.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
            this.Hide();
        }
    }
}
