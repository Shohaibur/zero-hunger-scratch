//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zero_hunger_scratch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Panel
    {
        public int Paneld { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantLocation { get; set; }
        public System.TimeSpan TimeAssigned { get; set; }
        public string StatusDetail { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}