using System.Linq;
using System.Web.Http;
using DataAccess;
using DataAccess.Contexts;
using Microsoft.AspNet.Identity;

namespace URMAC_Server.Controllers
{
    public class PurchaseInformationController : ApiController
    {
        [Authorize]
        public string Get(int id)
        {
            using (var context = new UrmacContext())
            {
                if (id != 0)
                {
                    return context.PurchaseInformation.SingleOrDefault(i => i.Id == id).Location;
                }

                return "couldnt find";
            }
        }
    }
}
