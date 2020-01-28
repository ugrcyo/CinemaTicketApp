using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Common.DTOS
{
    public class SaloonDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Row_Count { get; set; }
        public int Seat_Count { get; set; }
        public bool Status { get; set; }
    }
}
