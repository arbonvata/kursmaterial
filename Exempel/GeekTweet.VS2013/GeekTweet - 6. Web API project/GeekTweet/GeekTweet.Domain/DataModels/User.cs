//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeekTweet.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Tweets = new HashSet<Tweet>();
        }
    
        public int UserId { get; set; }
        public System.DateTime NextUpdate { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ScreenName { get; set; }
    
        public virtual ICollection<Tweet> Tweets { get; set; }
    }
}
