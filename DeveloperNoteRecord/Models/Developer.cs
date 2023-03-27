using System;
using System.ComponentModel.DataAnnotations;

namespace DeveloperNoteRecord.Models
{
	public class Developer
	{
		public Developer()
		{
		}
		
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Type { get; set; }

		public ICollection<Notes> Notes { get; set; }
		public ICollection<DeveloperSkill> DeveloperSkills { get; set; }

	}
}

