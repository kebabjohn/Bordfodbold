using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bordfodbold.Models
{
    public class Spiller
    {
    [HiddenInput(DisplayValue = false)]
    public int SpillerID { get; set; }

    [Required(ErrorMessage = "Please enter a name")]
    public string Spiller_Name { get; set; }

    [Required]
    [Range(0-100, int.MaxValue, ErrorMessage = "Please enter number of goals")]
    public int Spiller_Maal { get; set; }

    [Required]
    [Range(0 - 100, int.MaxValue, ErrorMessage = "Please enter number of games played")]
    public int Spiller_Kampe { get; set; }


    }
}