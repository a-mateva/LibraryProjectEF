using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        
        public virtual List<BookLoan> RentedBooks { get; set; }
    }
}
