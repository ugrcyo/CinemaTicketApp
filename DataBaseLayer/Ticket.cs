//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int ID { get; set; }
        public int Film_ID { get; set; }
        public int Seat_ID { get; set; }
        public int Ticket_Price_ID { get; set; }
        public int Saloon_ID { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Saloon Saloon { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual Ticket_Price Ticket_Price { get; set; }
    }
}
