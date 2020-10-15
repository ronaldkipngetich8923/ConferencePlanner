using Conference.Data;
using Conference.Data.DataClasses;
using Conference.Logic.Contracts;
using Conference.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.Logic.Implementation
{
    public class SpeakerServices : ISpeakersService
    {
        private readonly ApplicationDbContext _context;

        public SpeakerServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateSpeakerAsync(SpeakerRequestModel speakerRequestModel)
        {
            var speaker = new Speaker()
            {
                Name = speakerRequestModel.Name,
                Bio = speakerRequestModel.Bio,
                SessionId = speakerRequestModel.SessionId,
                WebSite = speakerRequestModel.WebSite
            };
             _context.Speakers.Add(speaker);

            await _context.SaveChangesAsync();

            return speaker.Id;
        }
    }
}
