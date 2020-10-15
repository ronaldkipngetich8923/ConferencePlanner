using Conference.Models.RequestModels;
using System;
using System.Threading.Tasks;
namespace Conference.Logic.Contracts
{
 public  interface ISpeakersService
    {
        Task<Guid> CreateSpeakerAsync(SpeakerRequestModel speakerRequestModel);
   }
}
