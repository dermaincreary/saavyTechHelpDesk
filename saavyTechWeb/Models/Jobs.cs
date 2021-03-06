//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace saavyTechWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobs
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public int equipmentTypeId { get; set; }
        public int brandId { get; set; }
        public string model { get; set; }
        public string serial { get; set; }
        public string issues { get; set; }
        public Nullable<int> recepId { get; set; }
        public Nullable<System.DateTime> dateIn { get; set; }
        public string techReport { get; set; }
        public Nullable<int> techId { get; set; }
        public Nullable<System.DateTime> dateRepaired { get; set; }
        public int statusId { get; set; }
        public Nullable<System.DateTime> dateCollected { get; set; }
        public string jobNumber { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual equiptmentType equiptmentType { get; set; }
        public virtual status status { get; set; }
    }
}
