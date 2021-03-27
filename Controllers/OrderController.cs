using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServicesAssignment4;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServicesAssignment4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        OrderService orderService = new OrderService();

        // GET
        [HttpGet, Route("")]
        public List<OrderInfo> Get()
        {
            List<OrderInfo> list = orderService.GetOrders();
            return list;
        }

        // GET
        [HttpGet, Route("{id}")]
        public Order Get(int id)
        {
            return orderService.GetOrder(id);
        }

        // PATCH
        [HttpPatch, Route("id/{id}/tracking/{tno}")]
        public string Patch(int id, string tno)
        {
            return orderService.UpdateTrackingNumber(tno, id);
        }

    }
}
