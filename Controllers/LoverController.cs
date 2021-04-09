using LoveFinderz.Storing;
using Microsoft.AspNetCore.Mvc;

namespace LoveFinders.Controllers
{
    [ApiController]
    public class LoverController:ControllerBase
    {
        private readonly LoveFinderzRepository _repo;

        public LoverController(LoveFinderzRepository repo)
        {
            _repo=repo;
        }
        // Posts a Lover
        [HttpPost("/Lover/{UserName}/{Password}")]
        public IActionResult PostLover(string UserName,string Password)
        {
            _repo.AddLover(UserName,Password);
            return Ok();
        }

        // Gets All Lovers
        [HttpGet("/Lovers")]
        public IActionResult GetLovers()
        {   
           return Ok( _repo.GetAllLovers());
        }
        // Gets A Lover
        [HttpGet("/Lovers/{UserName}")]
        public IActionResult GetLover(string UserName)
        {
            var Lover = _repo.GetLover(UserName);

            return Ok(Lover);
        }
        // Updates a Lovers Lover
        [HttpPut("/Lovers/{UserName}/{LoverName}")]
        public IActionResult UpDateLover(string UserName, string LoverName)
        {
            _repo.UpdateLovers(UserName,LoverName);
            return Ok();
        }
        // Updates Sex and Bio
        [HttpPut("Lovers/{UserName}/{Sex}/{Bio}")]
        public IActionResult SexBio(string UserName,string Sex, string Bio)
        {
            _repo.SexBio(UserName,Sex,Bio);
            return Ok();
        }
        // Deletes a Lover
        [HttpDelete("/Lovers/{UserName}/Delete")]
        public IActionResult RemoveLover(string UserName)
        {
            _repo.DeleteLover(UserName);
            return Ok();
        }
    }

}