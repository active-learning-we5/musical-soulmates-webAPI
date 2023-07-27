using System;
using System.ComponentModel.DataAnnotations;

namespace MusicalSoulmates.Data
{
    public class Language
    {
        [Key]
        [MaxLength(2)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }









        public bool IsRTL { get; set; }
    }
}
