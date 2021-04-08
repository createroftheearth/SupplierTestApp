using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplierTestApp.Application.Common.Interfaces;

namespace SupplierTestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _service;
        public SupplierController(ISupplierService service)
        {
            _service = service;
        }

        [HttpGet]
        public object GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("GetSupplierOverlaps/{SupplierNumber?}")]
        public object GetSupplierOverlaps(int? SupplierNumber)
        {
            return _service.GetSupplierOverlaps(SupplierNumber);
        }


    }
}
