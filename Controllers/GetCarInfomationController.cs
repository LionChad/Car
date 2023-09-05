using Microsoft.AspNetCore.Mvc;
using Car.Model;

[Route("api/[controller]")]
[ApiController]
public class GetCarInfomationController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] GetCarInfomationModel model)
    {
        var returnData = model.GetCarInfomation(model);
        return Ok(new { message = "Car information received successfully." });
    }
}