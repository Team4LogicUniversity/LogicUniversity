//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicUni.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollectionPoint
    {
        public CollectionPoint()
        {
            this.Departments = new HashSet<Department>();
        }
    
        public int CollectionPointId { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longtitude { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Department> Departments { get; set; }
    }
}
