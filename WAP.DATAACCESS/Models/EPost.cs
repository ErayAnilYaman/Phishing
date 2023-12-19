using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WAP.DATAACCESS.Models.Abstract;

namespace WAP.DATAACCESS.Models
{
    public class EPost : IEntity
    {
        private ICollection<TestResult> _testResults;
        public EPost()
        {
            _testResults = new HashSet<TestResult>();
        }
        [Key]
        public int ID { get; set; }


        [Required]
        [StringLength(500, ErrorMessage = "Karakter siniri asildi")]
        [Display(Name = "TITLE")]
        public string TITLE { get; set; }


        [Required]
        [StringLength(500, ErrorMessage = "Karakter siniri asildi")]
        [Display(Name = "DESCRIPTION")]
        public string DESCRIPTION { get; set; }


        [Required]
        public int USERID { get; set; }


        public virtual User User { get; set; }


        public virtual ICollection<TestResult> TestResults { get { return _testResults; } set { _testResults = value; } }
    }
}