using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_2WpfApp4
{
    public enum ProductCategorys
    {
        Food,
        Applicances
    }
    public class Product // это класс который содержит четыре свойства
    {
        public string ProductName { get; set; }// название
        public decimal ProductPrice { get; set; }// цена
        public string ProductImage { get; set; } // путь к файлу с картинками
        public ProductCategorys ProductCategory { get; set; }// значение перечисление категории
        
    }
}
