using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SPT.eCommerce.Cart.Container.Controllers
{
    /// <summary>
    /// Cart Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public IActionResult CreateCart()
        {
            return Ok(new { message = "Cart Created successfully!" });
        }
    }
}
