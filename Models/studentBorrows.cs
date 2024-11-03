using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23719649_assignment3.Models
{
    public class studentBorrows
    {
        public List<borrow> borrows { get; set; } // or whatever your borrow model is
        public List<student> students { get; set; } // Add this property
    }
}