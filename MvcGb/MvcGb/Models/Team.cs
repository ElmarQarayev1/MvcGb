﻿using System;
namespace MvcGb.Models
{
	public class Team
	{
		public int Id { get; set; }

	    
		public string ImgPath { get; set;}

		public string Name { get; set; }

		public string Position { get; set; }

		public List<Social> Socials { get; set; }


	}
}
