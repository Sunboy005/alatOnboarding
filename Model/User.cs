using Microsoft.AspNet.Identity.EntityFramework;

namespace Model
{
    public class User : IdentityUser
    {
        public string LocalGovernmentAreaId { get; set; }
        public LocalGovernmentArea LocalGovernmentArea { get; set; }//Naigation Property

    }
}