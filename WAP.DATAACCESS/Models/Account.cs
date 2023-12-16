
namespace WAP.DATAACCESS.Models
{
    #region usings
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WAP.DATAACCESS.Models.Abstract;

    #endregion
    public class Account : IEntity
    {
        [Key]
        public int ACCOUNTID { get; set; }
        
        [Required]
        public string NAME { get; set; }
        
        [Required]
        public string LASTNAME { get; set; }
        
        [Required]
        public string EMAIL { get; set; }
        
        [Required]
        public string PASSWORD { get; set; }

    }
}
