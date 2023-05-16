
using Db.Entities;

namespace TestTaskRSS.UI
{
    /// <summary>
    /// Шаблоны создания UI компонентов
    /// </summary>
    public static class HelperUI
    {
        // Оборачивание продуктов в Label для view
        public static List<Label> CreateProductLabels(List<Product> products,
            List<Status> statuses = null)
        {
            List<Label> labels = new List<Label>();

            int[] Location1 = new int[] { 196, 115 };
            int[] Location2 = new int[] { 472, 115 };
            int[] Size = new int[] { 211, 221 };

            if (products == null)
            {
                return new List<Label>();
            }

            for (int index = 0; index < products.Count; index++)
            {
                Label label;
                if (statuses  is null)
                {
                    label = HelperUI.CreateLabelProduct(products[index], Size, index);
                }
                else
                {
                    label = HelperUI.CreateLabelProductWithDate(products[index], Size, index,
                        statuses[index]);
                }
                
                if (index % 2 == 0)
                {
                    label.Location = new System.Drawing.Point(Location1[0], Location1[1]);
                }
                else
                {
                    label.Location = new System.Drawing.Point(Location2[0], Location2[1]);
                }

                labels.Add(label);
            }

            return labels;
        }

        // Вывод продуктов с датами смены статуса
        private static Label CreateLabelProductWithDate(Product product, int[] size,
            int indexProducts, Status status)
        {
            string dateTime = $"Дата принятия {status.AdoptedTime}\n" +
                $"Дата попадание на склад ";

            dateTime += status.WarehouseTime is not null ? 
                $"{status.WarehouseTime}\n" : "-\n";

            dateTime += "Дата продажи ";
            dateTime += status.SellTime is not null ?
                $"{status.SellTime}\n" : "-\n";

            Label label = new Label
            {
                Name = "ProductLabel" + indexProducts,
                Text = $"Название: {product.Name}\n" +
                            $"Описание: {product.Description}\n" +
                            $"Кол-во: {product.Count}\n" +
                            $"Цена: {product.Price}\n " +
                            $"{dateTime}",
                Size = new System.Drawing.Size(size[0], size[1]),
            };

            return label;
        }
        // Вывод без статуса
        private static Label CreateLabelProduct(Product product, int[] size,int indexProducts)
        {
            Label label = new Label
            {
                Name = "ProductLabel" + indexProducts,
                Text = $"Название: {product.Name}\n" +
                            $"Описание: {product.Description}\n" +
                            $"Кол-во: {product.Count}\n" +
                            $"Цена: {product.Price}\n",
                Size = new System.Drawing.Size(size[0], size[1]),
            };

            return label;
        }

        public static Button CreateNextButton()
        {
            Button button = new Button
            {
                Name = "NextButton",
                Location = new System.Drawing.Point(666, 385),
                Size = new System.Drawing.Size(100, 43),
                Text = "Далее"
            };

            return button;
        }

        public static Button CreatePreviousButton()
        {
            Button button = new Button
            {
                Name = "PreviousButton",
                Location = new System.Drawing.Point(560, 385),
                Size = new System.Drawing.Size(100, 43),
                Text = "Назад"
            };

            return button;
        }
    }
}
