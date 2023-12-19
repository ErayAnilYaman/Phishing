using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WAP.DATAACCESS.Models.Abstract;

namespace WAP.DATAACCESS.Models
{
    public class User : IEntity
    {
        private ICollection<Account> _accounts;
        private ICollection<EPost> _eposts;
        public User()
        {
            _accounts = new HashSet<Account>();
            _eposts = new HashSet<EPost>();

        }
        [Key]
        public int USERID { get; set; }


        [StringLength(500, ErrorMessage = "Karakter siniri asildi")]
        [Required]
        [Display(Name = "Name")]
        public string NAME { get; set; }

        [StringLength(500, ErrorMessage = "Karakter siniri asildi")]
        [Required]
        [Display(Name = "Name")]
        public string LASTNAME { get; set; }


        [Required]
        [Display(Name = "E-Mail")]
        [StringLength(500, ErrorMessage = "Karakter siniri asildi")]

        public string EMAIL { get; set; }

        public virtual ICollection<Account> Accounts { get { return _accounts; } set { _accounts = value; } }
        public virtual ICollection<EPost> EPosts { get { return _eposts; } set { _eposts = value; } }

    }
}