using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace u23719649_assignment3.Models
{
    public class AuthorTypesBorrows
    {
       
            public IPagedList<author> authors { get; set; }
            public IPagedList<type> types { get; set; }
            public IPagedList<borrow> borrows { get; set; }
        public IEnumerable<borrow> borrow { get; set; }
        
    }
}