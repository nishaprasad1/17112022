using Tourism;

namespace BasicWebApp.Controllers;

public class TourController : Controller
{
    private ISiteStore store;

    public TourController(ISiteStore store)
    {
        this.store = store;
    }

    public IActionResult Index()
    {
        var model = store.Load("CitiZoo");
        return View(model);
    }
}