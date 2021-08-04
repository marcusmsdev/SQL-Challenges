﻿using SQLChallenges.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges
{
    public class Order
    {
        
    
            public int OrderId { get; set; }

            // This is the foreign key
                        
            public int CustomerId { get; set; }

            public Customer Customer { get; set; }

            public short OrderStatus { get; set; }

            public DateTime OrderDate { get; set; }
            
            public DateTime RequiredDate { get; set; }
            
            public DateTime ShippedDate { get; set; }

            public int StoredId { get; set; }

            public int StaffId { get; set; }
    
    }
}


