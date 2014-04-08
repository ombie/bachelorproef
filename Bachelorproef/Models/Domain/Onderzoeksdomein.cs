using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bachelorproef.Models.Domain
{
    public class Onderzoeksdomein
    {
        #region properties
        [Key]
        public string OnderzoeksId { get; set; }
        #endregion

        #region constructors
        public Onderzoeksdomein(string onderzoeksId)
        {
            OnderzoeksId = onderzoeksId;
        }
        #endregion
    }
}