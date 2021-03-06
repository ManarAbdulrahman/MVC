using System;
using System.Collections.Generic;

#nullable disable

namespace MyFirstProject.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>(); //initilliz a list 
        }
        
        public int AuthorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; } //relation between Authors and BookAuthoers
        //virtual  works on lazy loading (only retraive what asked)
    }
}
