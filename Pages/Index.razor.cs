using Microsoft.AspNetCore.Components;
using ShotenerBlazor.Data;
using System.Threading.Tasks;
using ShotenerBlazor.Data.Interfaces;
using System;

namespace ShotenerBlazor.Pages
{
    public partial class Index
    {
        [Inject]
        public IUrlShorteningService ShortenService { get; set; }
        [Inject]
        public ExpressDB Db { get; set; }
        private Url Url { get; set; }
        protected override Task OnInitializedAsync()
        {
            Url = new Url();
            return base.OnInitializedAsync();
        }

        private void ShortenUrl()
        {
            var shortUrl = ShortenService.QuickShort( new Uri(Url.Value));
            Db.ShortUrls.Add(shortUrl);
            Url.Value = shortUrl.Value.ToString();
        }


    }
}
