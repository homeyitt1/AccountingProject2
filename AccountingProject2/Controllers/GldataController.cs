using AccountingProject2.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AccountingProject2.Controllers
{
    public class GldataController : Controller
    {
        recontestEntities gldataDB = new recontestEntities();
        // GET: Gldata
        //public ActionResult Index()
        //{
        //    var gldata = gldataDB.gldatas.ToListAsync();
        //    return View(gldata);
        //}
        public async Task<ActionResult> Index()
        {
            return View(await gldataDB.gldatas.ToListAsync());
        }


        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }
    }
}