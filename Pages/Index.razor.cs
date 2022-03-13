using Microsoft.AspNetCore.Components;
using ShotenerBlazor.Data;
using System.Threading.Tasks;
using ShotenerBlazor.Data.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;



namespace ShotenerBlazor.Pages
{
    public partial class Index
    {
        [Inject] public IUrlShorteningService ShortenService { get; set; }
        
        [Inject] public ShotenerDataContext DataContext { get; set; }


        private Url Url { get; set; }
        protected override Task OnInitializedAsync()
        {
            Url = new Url();
            return base.OnInitializedAsync();
        }

        private async void ShortenUrl()
        {
            var shortUrl = ShortenService.QuickShort( new Uri(Url.Value));
            DataContext.ShortUrls.Add(shortUrl);
            await DataContext.SaveChangesAsync();
            Url.Value = shortUrl.Value.ToString();
            StateHasChanged();
            
        }


    }
}
