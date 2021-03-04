using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Registration:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Affiliation { get; set; }
        public string Country { get; set; }
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Abstract { get; set; }
        public string Selection { get; set; }
    }
}
