using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class FilterProductData
    {
        public int ProductId { get; set; } = -1;
        public string Keyword { get; set; } = string.Empty;
        public decimal MinPrice { get; set; } = Decimal.MinusOne;
        public decimal MaxPrice { get; set; } = Decimal.MinusOne;
        public int MinUnit { get; set; } = -1;
        public int MaxUnit { get; set; } = -1;

        public void Reset()
        {
            ProductId = -1;
            Keyword = string.Empty;
            MinPrice = Decimal.MinusOne;
            MaxPrice = decimal.MinusOne;
            MinUnit = -1;
            MaxUnit = -1;
        }
    }
}
