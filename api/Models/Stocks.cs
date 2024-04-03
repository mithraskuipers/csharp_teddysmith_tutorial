using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stocks
    {
		public int MyProperty { get; set; }
		public string Symbol { get; set; } = string.Empty;
		public string Company { get; set; } = string.Empty;
		[Column(TypeName = "decimal(18,2)")] // 18 digits and 2 decimal places
		public decimal Purchase { get; set; }
		[Column(TypeName = "decimal(18,2)")] // 18 digits and 2 decimal places
		public decimal LastDiv { get; set; }
		public string Industry { get; set; } = string.Empty;
		public long MarketCap { get; set; }
		public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}