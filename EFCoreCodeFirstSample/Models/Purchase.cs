using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirstSample.Models
{
	public class Purchase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int productId { get; set; }
		public int userId { get; set; }
		public int price { get; set; }
		public DateTime date { get; set; }
		public DateTime updateDate { get; set; }
	}
}

