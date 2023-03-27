using System;
using DeveloperNoteRecord.Models;

namespace DeveloperNoteRecord.ViewModel
{
	public class NoteDetailViewModel
	{
		public NoteDetailViewModel()
		{
		}
		
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

		public string DeveloperId { get; set; }
        public List<Developer> Developers { get; set; }
		
    }
}

