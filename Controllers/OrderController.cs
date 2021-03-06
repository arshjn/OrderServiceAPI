using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServicesAssignment4;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServicesAssignment4.Controllers
{
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        static OrderService orderService = new OrderService();

        // GET
        [HttpGet, Route("")]
        public List<OrderInfo> Get()
        {
            return orderService.GetOrders();
        }

        // GET
        [HttpGet, Route("{id}")]
        public Order Get(int id)
        {
            return orderService.GetOrder(id);
        }

        // PATCH
        [Authorize(Roles = "admin")]
        [HttpPatch, Route("id/{id}/tracking/{tno}")]
        public string Patch(int id, string tno)
        {
            return orderService.UpdateTrackingNumber(tno, id);
        }

    }
}
