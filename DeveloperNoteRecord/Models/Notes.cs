using System;
namespace DeveloperNoteRecord.Models
{
	public class Notes
	{
		public Notes()
		{
		}
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreatedDate{ get; set; }

		public int DeveloperId { get; set; }
		public Developer Developer { get; set; }
		
	}
}

