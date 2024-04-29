using System;
namespace MvcGb.Models
{
	public class Social
	{
		public int Id { get; set; }

		public string Icon { get; set; }

		public string Link { get; set; }

		public int TeamId { get; set; }

		public Team Team { get; set; }
	}
}

