using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Models.RequestModels;
using Conference.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Conference.WebClient.Pages.Speakers
{
    public class CreateSpeakerModel : PageModel
    {
        [BindProperty]
        public SpeakerRequestModel SpeakerRequest { get; set; }
        private readonly IHttpService _clientService;
        public CreateSpeakerModel(IHttpService clientService)
        {
            _clientService = clientService;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {

            var url = "speaker/AddSpeaker";
            var result = await _clientService.PostAsync<StatusResponseModel>(url, SpeakerRequest);

            return RedirectToPage("Index");



        }
    }
}
