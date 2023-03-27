using System;
namespace DeveloperNoteRecord.Models
{
	public class SkillSet
	{
		public SkillSet()
		{
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsChecked { get; set; }
        public ICollection<DeveloperSkill> DeveloperSkills { get; set; }

    }
}

