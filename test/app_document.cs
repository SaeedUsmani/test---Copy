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
    
    public partial class app_document
    {
        public int ad_ID { get; set; }
        public Nullable<int> d_ID { get; set; }
        public Nullable<int> app_ID { get; set; }
    
        public virtual application_ application_ { get; set; }
        public virtual document document { get; set; }
    }
}
