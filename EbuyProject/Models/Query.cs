using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbuyProject.Models
{
    public class Query
    {
		public string Title { get; set; }
		public string Author { get; set; }
		public string Keywords { get; set; }
		public DateTime SpecificDate { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool IsSpecifiedChecked { get; set; }
	}
}
