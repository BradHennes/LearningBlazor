using LearningBlazor.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LearningBlazor.Pages.GuestForm
{
    public class GuestFormBase : ComponentBase
    {
        [Inject]
        protected HttpClient HttpClient { get; set; }

        protected Backend Backend { get; set; }
        public Guest CurrentGuest { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Backend = new Backend();
            CurrentGuest = Backend.GetGuest();
        }
    }
}
