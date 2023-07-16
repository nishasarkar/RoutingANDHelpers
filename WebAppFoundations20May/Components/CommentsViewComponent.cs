using Microsoft.AspNetCore.Mvc;

namespace WebAppFoundations20May.Components
{
    public class CommentsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            // TO DO:
            List<string> comments = new List<string> { "Good", "Keep it up" };
            return View("~/views/components/_comments.cshtml",comments);
        }
    }
}
