using Microsoft.AspNetCore.Mvc;
using WebAppTagHelpers.Models;

namespace WebAppTagHelpers.ViewComponents
{
    public class SpeakerCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Speaker speaker)
        {
            return View(speaker);
        }
    }
}
