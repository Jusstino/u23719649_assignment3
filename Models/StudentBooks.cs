using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;

namespace u23719649_assignment3.Models
{
    public class StudentBooks
    {
        public IPagedList<student> students { get; set; }
        public IPagedList<book> books { get; set; }
        public IEnumerable<borrow> borrows { get; set; }
    }
}