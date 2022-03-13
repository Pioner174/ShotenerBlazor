using Microsoft.AspNetCore.HostFiltering;
using ShotenerBlazor.Data;
using System.Threading.Tasks;

namespace ShotenerBlazor.Pages
{
    public partial class Index
    {
        private Url Url { get; set; }
        protected override Task OnInitializedAsync()
        {
            Url = new Url();
            return base.OnInitializedAsync();
        }

        private void ShortenUrl()
        {
            

        }


    }
}
