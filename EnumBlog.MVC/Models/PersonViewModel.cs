using System.ComponentModel.DataAnnotations;

namespace EnumBlog.MVC.Models
{
    public enum AirlinePreference
    {        
        BritishAirways,     
        EasyJet,
        RyanAir,
        Virgin
    }

    public class PersonViewModel 
    {
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Airline Preference")]
        public AirlinePreference? AirlinePreference { get; set; }
    }
}
