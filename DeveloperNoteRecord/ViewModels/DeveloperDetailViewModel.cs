using System;
using DeveloperNoteRecord.Models;

namespace DeveloperNoteRecord.ViewModels
{
	public class DeveloperDetailViewModel
	{
		public DeveloperDetailViewModel()
		{
		}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Efficiency { get; set; }
        public List<CheckBoxItem> Skills { get; set; }
    }
}

