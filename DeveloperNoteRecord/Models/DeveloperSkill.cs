using System;
namespace DeveloperNoteRecord.Models
{
	public class DeveloperSkill
	{
		public DeveloperSkill()
		{
		}
		public int DeveloperId { get; set; }
		public Developer Developer { get; set; }

		public int SkillSetId { get; set; }
		public SkillSet SkillSet { get; set; }

		public string Efficiency { get; set; }
	}
}

