using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Models
{
    public class Book : BaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string YearPublished { get; set; }
        public string Isbn { get; set; }
        public bool IsAvailable { get; set; }

        public virtual BookLoan Loan { get; set; }
    }
}
