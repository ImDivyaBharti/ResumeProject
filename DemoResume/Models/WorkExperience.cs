//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoResume.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkExperience
    {
        public int ExpId { get; set; }
        public string OrgName { get; set; }
        public string JobTitle { get; set; }
        public Nullable<System.DateTime> FromYear { get; set; }
        public Nullable<System.DateTime> ToYear { get; set; }
        public string ExpDescription { get; set; }
    }
}