//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> PostID { get; set; }
        public string İmage { get; set; }
        public string Content { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
