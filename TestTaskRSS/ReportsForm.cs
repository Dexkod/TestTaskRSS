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
    public partial class ReportsForm : Form
    {
        private CheckBox _currentCheckBox;
        private List<Product> _allProducts;
        private List<Product> _currentProducts;
        private List<Status> _statuses;
        private readonly IRepository _repository;
        private List<Label> _productLabels = new List<Label>();
        private int _lastIndexLabelOnView = 0;

        public ReportsForm()
        {
            _repository = Repository.Instance;
            GetProductsAndStatus();
            InitializeComponent();
            _currentCheckBox = AllCheckBox;
            _currentCheckBox.Checked = true;
        }

        // конструктор для внутреннего вызова при смене фильтрации
        private ReportsForm(CheckBox checkBox, List<Product> allProducts,
            List<Status> statuses, List<Product> currentProducts)
        {
            
            _currentProducts = currentProducts;
            _repository = Repository.Instance;
            _allProducts = allProducts;
            _statuses = statuses;
            CreateProductLabels();
            ViewAddProductLabels();
            InitializeComponent();
            Controls.RemoveByKey(checkBox.Name);
            Controls.Add(checkBox);
            _currentCheckBox = checkBox;
        }
        //Получение всех продуктов и статусов
        private async void GetProductsAndStatus()
        {
            _allProducts = (await _repository.Context.GetProductsAsync())
                .OrderBy(x => x.StatusId).ToList();
            _statuses = (await _repository.Context.GetStatusesAsync())
                .OrderBy(x => x.Id).ToList();

            _currentProducts = _allProducts;
            CreateProductLabels();
            ViewAddProductLabels();
        }
        private void CreateProductLabels()
        {
            _productLabels = HelperUI.CreateProductLabels(_currentProducts);
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
            _lastIndexLabelOnView = _lastIndexLabelOnView + 2 < _currentProducts.Count
                ? _lastIndexLabelOnView + 2 : _lastIndexLabelOnView + 1;
            ViewAddProductLabels();
        }
        private void RemoveViewProductLabels()
        {
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
        }
        // получение продуктов, которые подходят под фильтрацию
        private void GetCurrentProducts()
        {
            if (_currentCheckBox.Text.Equals("Все"))
            {
                _currentProducts = _allProducts;
            }
            else
            {
                List<Product> products = new List<Product>();

                for (int i = 0; i < _allProducts.Count; i++)
                {
                    if (_statuses[i].Name.Equals(_currentCheckBox.Text))
                    {
                        products.Add(_allProducts[i]);
                    }
                }

                _currentProducts = products;
            }

           
            ReportsForm reportsForm = new ReportsForm(_currentCheckBox, _allProducts
                , _statuses, _currentProducts);
            reportsForm.Show();
            this.Hide();
        }

        private void AdoptedButton_Click(object sender, EventArgs e)
        {
            AdoptedProductsForm adoptedProductsForm = new AdoptedProductsForm();
            adoptedProductsForm.Show();
            this.Hide();
        }

        // Событие по смене фильтрации
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox != _currentCheckBox)
            {
                if (checkBox is null || checkBox.Checked == false)
                {
                    _currentCheckBox = AllCheckBox;
                    GetCurrentProducts();
                }
                else
                {
                    _currentCheckBox = checkBox;
                    GetCurrentProducts();
                }
            }
        }

        private void InStockButton_Click(object sender, EventArgs e)
        {
            InStockForm inStockForm = new InStockForm();
            inStockForm.Show();
            this.Hide();
        }

        private void SellsButton_Click(object sender, EventArgs e)
        {
            SellsForm sellsForm = new SellsForm();
            sellsForm.Show();
            this.Hide();
        }
    }
}
