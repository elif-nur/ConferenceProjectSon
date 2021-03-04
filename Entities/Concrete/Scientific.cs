using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Scientific:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "bos bıraklamaz")]
        public string FullName { get; set; }
    }
}
