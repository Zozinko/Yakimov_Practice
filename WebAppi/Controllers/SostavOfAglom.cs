using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppi.Models;
using WebAppi.Sevices;

namespace WebAppi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SostavOfAglom(AglomCalcService aglomCalcService) : ControllerBase
    {
        [HttpPost]
        public async Task<JsonResult> Test(InputDTO inputDTO)
        {
            return new JsonResult(aglomCalcService.CalcAglom(inputDTO));
        }

        [HttpGet]
        public async Task<IActionResult> CreatePreset()
        {
            await aglomCalcService.CreateDefaultPreset();
            return Ok();
        }

        [HttpGet]
        public async Task<JsonResult> GetPreset()
        {
            return new JsonResult(await aglomCalcService.UseDefaultPreset());

        }
    }
}
