using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class MapwithDrivingRoutefromAtoBModel : PageModel
    {
        private readonly ILogger<MapwithDrivingRoutefromAtoBModel> _logger;

        public MapwithDrivingRoutefromAtoBModel(ILogger<MapwithDrivingRoutefromAtoBModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}