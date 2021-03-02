using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InvitedSpeakerManager : IInvitedSpeakerService
    {
        IInvitedSpeakerDal _invitedSpeakerDal;

        public InvitedSpeakerManager(IInvitedSpeakerDal invitedSpeakerDal)
        {
            _invitedSpeakerDal = invitedSpeakerDal;
        }

        public void Add(InvitedSpeaker invitedSpeaker)
        {
            _invitedSpeakerDal.Add(invitedSpeaker);
        }

        public void Delete(InvitedSpeaker invitedSpeaker)
        {
            _invitedSpeakerDal.Delete(invitedSpeaker);
        }

        public InvitedSpeaker Get(int invitedId)
        {
            return _invitedSpeakerDal.Get(x => x.Id == invitedId);
        }

        public List<InvitedSpeaker> GetAll()
        {
            return _invitedSpeakerDal.GetAll();
        }

        public void Update(InvitedSpeaker ınvitedSpeaker)
        {
             _invitedSpeakerDal.Update(ınvitedSpeaker);
        }
    }
}
