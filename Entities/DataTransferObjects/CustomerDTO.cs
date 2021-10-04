using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
   public class CustomerDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

       
        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
