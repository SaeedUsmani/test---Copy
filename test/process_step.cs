//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test
{
    using System;
    using System.Collections.Generic;
    
    public partial class process_step
    {
        public int ps_ID { get; set; }
        public Nullable<int> s_ID { get; set; }
        public Nullable<int> p_ID { get; set; }
        public string ps_status { get; set; }
        public int ps_priority { get; set; }
    
        public virtual process process { get; set; }
        public virtual step step { get; set; }
    }
}
