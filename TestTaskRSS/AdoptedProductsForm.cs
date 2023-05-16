using Db.Context.Rep;
using Db.Entities;
using TestTaskRSS.UI;

namespace TestTaskRSS
{
    public partial class AdoptedProductsForm : Form
    {
        private List<Product> _products;
        private readonly IRepository _repository;
        private List<Label> _productLabels = new List<Label>();
        private int _lastIndexLabelOnView = 0;
        public AdoptedProductsForm()
        {
            InitializeComponent();
            _repository = Repository.Instance;
            GetProductsAdopted();
        }

        // Переход к форме добавление продуктов
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();

            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                _lastIndexLabelOnView = 0;
                AdoptedProductsForm adoptedProductsForm = new AdoptedProductsForm();
                adoptedProductsForm.Show();
                this.Hide();
            }
        }

        //Создание следующих продуктов в списке
        private void NextButton_Click(object sender, EventArgs e)
        {
            RemoveViewProductLabels();
            _lastIndexLabelOnView += 2;
            ViewAddProductLabels();
        }

        // Получение продуктов с статусом принят
        private async void GetProductsAdopted()
        {
            var allProducts = await _repository.Context.GetProductsAsync();
            var allStatuses = await _repository.Context.GetStatusesAsync();
            allStatuses = allStatuses.Where(x => x.Name.Equals("Принят")).ToList();


            _products = allProducts.Where(product => allStatuses
                .Any(status => product.StatusId == status.Id)).ToList();
            CreateProductLabels();
            ViewAddProductLabels();
        }

        //Добавление продуктов на view и создание кнопок далее и назад
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
            _lastIndexLabelOnView = _lastIndexLabelOnView + 2 < _products.Count
                ? _lastIndexLabelOnView + 2 : _lastIndexLabelOnView + 1;
            ViewAddProductLabels();
        }

        //Удаление с view прошлых продуктов
        private void RemoveViewProductLabels()
        {
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
            Controls.Remove(_productLabels[--_lastIndexLabelOnView]);
        }

        // создание label из продуктов для view
        private void CreateProductLabels()
        {
            _productLabels = HelperUI.CreateProductLabels(_products);
            _productLabels.ForEach(x => x.Click += TransferOnWarehouse);
        }

        //Событие нажатие на продукты, для перехода на новый статус
        private async void TransferOnWarehouse(object sender, EventArgs e)
        {
            if (MessageBox.Show("Переместить продукт на склад?", "Перемещение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Label label = (Label)sender;
                int index = Convert.ToInt32(label.Name[label.Name.Length - 1] + "");

                var statuses = await _repository.GetStatusesAsync();
                Status status = statuses.First(x => x.Id == _products[index].StatusId);
                status.Name = "На складе";
                status.WarehouseTime = DateTime.Now;

                await _repository.PutStatusAsync(status);
                await _repository.SaveChangesAsync();

                AdoptedProductsForm adoptedProductsForm = new AdoptedProductsForm();
                adoptedProductsForm.Show();
                this.Hide();
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

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
           
        }
    }
}