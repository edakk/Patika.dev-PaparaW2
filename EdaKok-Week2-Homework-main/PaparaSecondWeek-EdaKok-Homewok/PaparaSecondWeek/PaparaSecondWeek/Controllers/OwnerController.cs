using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaSecondWeek.Attributes;
using PaparaSecondWeek.Models;
using PaparaSecondWeek.Services;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using System;

namespace PaparaSecondWeek.Controllers
{
    //[ValidateModelState]  
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerServices _ownerServices;

        public OwnerController(IOwnerServices ownerServices)
        {
            _ownerServices = ownerServices;
        }
        private List<Owner> OwnerList = new List<Owner>()
        {
            new Owner{
                Id=2,
                Name= "Eda",
                Description= "abc",
                CreateDate = new DateTime(1998,04,22),
                Color = (ColorEnum)1,
            },
            new Owner{
                Id=3,
                Name= "Eda",
                Description= "abc",
                CreateDate = new DateTime(1998,04,22),
                Color =(ColorEnum)2
            },
            new Owner{
                Id=4,
                Name= "Eda",
                Description= "abc",
                CreateDate = new DateTime(1998,04,22),
                Color = (ColorEnum)3,
            },

        };


        [HttpPost("Create")]
        public IActionResult Post()
        {
            var result = _ownerServices.Add();
            return Ok(result);
        }

        [HttpGet("{number}")]              // test when number equals zero, result will return internal server error
        public int Deneme(int number)
        {
            int result = 12 / number;
            return result;
        }

       

        [HttpDelete("DeleteOwner")]
        public IActionResult Delete()
        {
            var result = _ownerServices.Delete();
            return Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Owner))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:int}")]
        
        public IActionResult DeleteById(int id)              //test if id is not found
        {
            
            var ownerList = OwnerList.OrderBy(x => x.Id).ToList<Owner>();
            var owner = ownerList.FirstOrDefault(x => x.Id == id);
            if (owner.Id== id && owner != null)

                ownerList.Remove(owner);
            return Ok(ownerList);
        }
    }

}

    
 

