using System;
namespace MvcGb.Models
{
	public class Project
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime Date { get; set; }

		public string Client { get; set; }

		public string ProjejtUrl { get; set; }

		public int CategoryId { get; set; }

		public Category Category { get; set; }

        public List<ProjectImage> ProjectImages { get; set; }
    }
}

