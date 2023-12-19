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
    public class AccountType : IEntity
    {
        private ICollection<Account> _accounts;
        public AccountType()
        {
            _accounts = new HashSet<Account>();
        }


        [Key]
        public int ID { get; set; }


        [Display(Name = "Account Type")]
        [StringLength(500, ErrorMessage = "Karakter Sinirini Astiniz!!")]
        [Required]
        public string TYPE { get; set; }


        public virtual ICollection<Account> Accounts { get { return _accounts; } set { _accounts = value; } }
    }
}


