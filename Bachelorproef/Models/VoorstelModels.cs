using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models
{
    public class VoorstelIndienenModel
    {
        [Required(ErrorMessage = "'{0}' moet ingevuld zijn")]
        [DataType(DataType.Text)]
        [Display(Name = "Titel")]
        public string Titel { get; set; }

        [Required(ErrorMessage = "'{0}' moet ingevuld zijn")]
        [DataType(DataType.Text)]
        [Display(Name = "Onderzoeksdomein 1")]
        public string Onderzoeksdomein1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Onderzoeksdomein 2 (optioneel)")]
        public string Onderzoeksdomein2 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Vrije trefwoorden")]
        public string VrijeTrefwoorden { get; set; }

        [Required(ErrorMessage = "'{0}' moet ingevuld zijn")]
        [DataType(DataType.Text)]
        [Display(Name = "Onderzoeksvraag")]
        public string Onderzoeksvraag { get; set; }

        [Required(ErrorMessage = "'{0}' moet ingevuld zijn")]
        [DataType(DataType.Text)]
        [Display(Name = "Probleemstelling")]
        public string Probleemstelling { get; set; }

        [Required(ErrorMessage = "'{0}' moet ingevuld zijn")]
        [DataType(DataType.Text)]
        [Display(Name = "Plan van aanpak")]
        public string PlanVanAanpak { get; set; }
    }
}