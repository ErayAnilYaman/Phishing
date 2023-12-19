
using System.ComponentModel.DataAnnotations;
using System;
using WAP.DATAACCESS.Models.Abstract;

namespace WAP.DATAACCESS.Models
{
    public class TestResult : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int EPOSTID { get; set; }
        public bool Success { get; set; }
        public DateTime Date { get; set; }
        public virtual EPost EPost { get; set; }
    }
}