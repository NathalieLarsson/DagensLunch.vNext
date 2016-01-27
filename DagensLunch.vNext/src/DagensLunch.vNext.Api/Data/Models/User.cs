using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DagensLunch.vNext.Api.Data.Models
{
    public class User
    {
		public int Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public virtual bool EmailConfirmed { get; set; }
		public virtual string NormalizedEmail { get; set; }
		public virtual string NormalizedUserName { get; set; }
	}
}
