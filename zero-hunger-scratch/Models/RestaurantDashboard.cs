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
    
    public partial class RestaurantDashboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RestaurantDashboard()
        {
            this.RestaurantNGOEnds = new HashSet<RestaurantNGOEnd>();
        }
    
        public int RestaurantDashboardId { get; set; }
        public string RestaurantName { get; set; }
        public string SelectFood { get; set; }
        public Nullable<System.TimeSpan> ByTime { get; set; }
        public string RestaurantLocation { get; set; }
        public Nullable<int> Contact { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantNGOEnd> RestaurantNGOEnds { get; set; }
    }
}