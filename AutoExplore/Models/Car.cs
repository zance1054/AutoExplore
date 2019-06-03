using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoExplore.Models
{
    public class Car
    {
        public long Id { get; set; }
        public string _key;
        [Required]
        [Display(Name = "Make")]
        [StringLength(20,MinimumLength =2,
            ErrorMessage = "You must enter a valid Make for a vehicle" + "\n" + "example: Toyota")]
        public string make { get; set; }
        [Required]
        [Display(Name = "Model")]
        [StringLength(20, MinimumLength = 2,
            ErrorMessage = "You must enter a valid Model for a vehicle" + "\n" + "example: Camry")]
        public string model { get; set; }
        [Required]
        [Display(Name = "Year")]
        [StringLength(4, MinimumLength = 2,
            ErrorMessage = "You must enter a valid Year for a vehicle" + "\n" + "example: 2005")]
        public string year { get; set; }
        
        /*
        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(make.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }

            set { _key = value; }
        }
        */
        public string user { get; set; }
        public DateTime posted { get; set; }

        //Trim info from API
        public string modelID { get; set; }
        public string Body { get; set; }
        public string modelTrim { get; set; }
        public string Transmission { get; set; }
        public string DriveType { get; set; }
        public string seats { get; set; }
        public string doors { get; set; }
        public string weight { get; set; }

        //video result from YouTube API
        public string videoURL { get; set; }
        
    }
}
