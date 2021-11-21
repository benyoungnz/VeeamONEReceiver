using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeeamONEReceiver.Pages
{
    public class GettingStartedModel : PageModel
    {
        private readonly ILogger<GettingStartedModel> _logger;

        public GettingStartedModel(ILogger<GettingStartedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
