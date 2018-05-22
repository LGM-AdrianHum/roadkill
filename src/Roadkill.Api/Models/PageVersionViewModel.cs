﻿using System;

namespace Roadkill.Api.Models
{
	public class PageVersionViewModel
	{
		public Guid Id { get; set; }

		public int PageId { get; set; }

		public string Text { get; set; }

		public string Author { get; set; }

		public DateTime DateTime { get; set; }
	}
}