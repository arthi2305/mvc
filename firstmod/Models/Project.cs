//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firstmod.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.TimeSheetDetails = new HashSet<TimeSheetDetail>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> Id { get; set; }
    
        public virtual tblLogin tblLogin { get; set; }
        public virtual ICollection<TimeSheetDetail> TimeSheetDetails { get; set; }

        public Projectid Projectid { get; set; }
    }
}
