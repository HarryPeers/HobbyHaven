using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using HobbyHaven.Shared.DTOs.Havens;
using Microsoft.Extensions.Options;
using HobbyHaven.BackEnd.Images;
using HobbyHaven.BackEnd.Database.Models;

namespace HobbyHaven.BackEnd.Controllers.Images
{

    [ApiController]
    public class HobbyImages : ControllerBase, IDataController
    {

        // Set the datacontext object

        public DataContext _context { get; set; }
        public AuthenticationLinkSettings _authenticationLinkSettings { get; set; }
        public ImageSettings _imageSettings { get; set; }
        public HobbyImages(DataContext context, IOptions<AuthenticationLinkSettings> authSettings, IOptions<ImageSettings> imageSettings)
        {
            _context = context;
            _authenticationLinkSettings = authSettings.Value;
            _imageSettings = imageSettings.Value;
        }


        [Route("api/images/hobbies/{hobbyID}/")]
        [HttpGet]
        public async Task<IActionResult> Get(Guid hobbyID)
        {
            Hobby? hobby = await _context.Hobbies.Include(h => h.PersonalityTags).Include(h => h.Users).Include(h => h.Havens).FirstAsync(h => h.HobbyID == hobbyID);

            if (hobby == null || !hobby.HasImage) return NotFound(); 

            try
            {
                Byte[] b = await System.IO.File.ReadAllBytesAsync($"{_imageSettings.hobbyImagePath}{hobbyID}.png");
                return File(b, "image/png");
            } catch (FileNotFoundException e)
            {
                hobby.HasImage = false;
                await _context.SaveChangesAsync();

                return NotFound();
            }

        }


    }

}
