using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrganisingService
    {
        void Add(OrganisingSpeaker organisingSpeaker);
        void Update(OrganisingSpeaker organisingSpeaker);
        void Delete(OrganisingSpeaker organisingSpeaker);
        List<OrganisingSpeaker> GetAll();
        OrganisingSpeaker Get(int organisingId);
    }
}
