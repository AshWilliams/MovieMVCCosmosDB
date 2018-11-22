using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MovieMVC.Models
{
    public class Movie
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [JsonProperty(PropertyName = "movieName")]
        public string MovieName { get; set; }

        [Required]
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
    ErrorMessageResourceName = "Required")]
        [Display(Name = "Fecha de Estreno")]
        [JsonProperty(PropertyName = "releaseDate")]
        public DateTime ReleaseDate { get; set; }
    }
}