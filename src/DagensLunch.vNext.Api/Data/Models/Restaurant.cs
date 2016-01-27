using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DagensLunch.vNext.Api.Data.Models
{
    public class Restaurant
    {
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public string OlleISkogen { get; set; }


		public virtual List<UserRestaurantRole> UserRestaurantRoles { get; set; }
	}
}
