using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using System.Linq.Expressions;

namespace NZWalks.API.Controllers
{
    //https://localhost:1245/api/regions
    //GET ALL REGIONS
    //GET: https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland region",
                    Code = "AKL",
                    RegionImageUrl = "https://media.istockphoto.com/id/691610536/photo/aucklands-skyline-at-dawn.jpg?s=1024x1024&w=is&k=20&c=7hoz9PnQjs4HGkFzDJL0AAPoY1a3duT3rbtwEaEPxXE="
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = " Wellington region",
                    Code = "WLG",
                    RegionImageUrl = " https://media.istockphoto.com/id/464378599/photo/wellington-bay-and-harbour.jpg?s=1024x1024&w=is&k=20&c=di_6JaJbuVdJeirBctyHO6QJJFzw2LM3kkCU6J5JTFU="
                }

            };
            return Ok(regions);

        }
    }
}

