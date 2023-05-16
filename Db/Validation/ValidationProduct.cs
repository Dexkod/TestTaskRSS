using Db.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Validation
{
    /// <summary>
    /// Валидация добавления продуктов
    /// </summary>
    public static class ValidationProduct
    {
        public static bool IsValidationAdd(Product product, out string message)
        {
            if(product.Name.IsNullOrEmpty())
            {
                message = "Имя не может быть пустым";
                return false;
            }
            else if(product.Price <= 0)
            {
                message = "Неверно поставлена цена";
                return false;
            }
            else if (product.Count <= 0)
            {
                message = "Неверно поставлено кол-во ";
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
