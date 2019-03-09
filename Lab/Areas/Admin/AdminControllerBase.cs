using Lab.Database;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Areas.Admin
{
    [Area("Admin")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public abstract class AdminControllerBase : Controller
    {
        protected AdminDbContext _adminDbContext;

        protected AdminControllerBase(AdminDbContext adminDbContext)
        {
            _adminDbContext = adminDbContext;
        }
    }
}