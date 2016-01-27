using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DagensLunch.vNext.Api.Data.Models
{
	[Table("UserRestaurantRoles")]
	public class UserRestaurantRole
    {
		[Key]
		public int Id { get; set; }

		public string UserId { get; set; }
		[ForeignKey("UserId")]
		public User User { get; set; }

		public string RestaurantId { get; set; }
		[ForeignKey("RestaurantId")]
		public Restaurant Restaurant { get; set; }
	}
}
