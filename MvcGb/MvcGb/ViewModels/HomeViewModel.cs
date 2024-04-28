using System;
using MvcGb.Models;

namespace MvcGb.ViewModels
{
	public class HomeViewModel
	{
		public List<Category> Categories { get; set; }

		public List<Project> Projects { get; set; }
	}
}
