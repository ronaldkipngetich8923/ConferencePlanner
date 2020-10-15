using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Conference.Logic.Contracts;
using Conference.Models.RequestModels;
using Conference.Models.ResponseModels;

namespace Conference.API.Controllers
{
  
    [Route("[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly ISpeakersService _speakersService;
        public SpeakerController(ISpeakersService speakersService)
        {
            _speakersService = speakersService;
        }

        [HttpPost("AddSpeaker")]
        public async Task<IActionResult> AddReportAsync([FromBody] SpeakerRequestModel speakerRequest)
        {
            var res = await _speakersService.CreateSpeakerAsync(speakerRequest);

            var responseStatus = new StatusResponseModel
            {
                Status = true,
                Message = "Speaker added successfully",
                ID = res
            };

            return Ok(responseStatus);
        } 

    }
}
