using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInvitedSpeakerService
    {
        void Add(InvitedSpeaker ınvitedSpeaker);
        void Update(InvitedSpeaker ınvitedSpeaker);
        void Delete(InvitedSpeaker ınvitedSpeaker);
        List<InvitedSpeaker> GetAll();
        InvitedSpeaker Get(int invitedId);
    }
}
