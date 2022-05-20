using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class LocalGovernmentArea:BaseEntity
    {
        [Required]
        public string name { get; set; }
        public string StateId { get; set; }
        public State State { get; set; }//Navigational Property
    }
}