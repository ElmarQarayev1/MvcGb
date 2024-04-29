using System;
using MvcGb.Models;

namespace MvcGb.ViewModels
{
	public class HomeViewModel
	{
		public List<Category> Categories { get; set; }

		public List<Project> Projects { get; set; }

		public List<Social> Socials { get; set; }

		public List<Team> Teams { get; set; }
	}
}
