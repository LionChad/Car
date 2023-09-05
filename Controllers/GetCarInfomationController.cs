using Microsoft.AspNetCore.Mvc;
using Car.Model;

[Route("api/[controller]")]
[ApiController]
public class GetCarInfomationController : ControllerBase
{
    [HttpPost]
    public IActionResult Post(GetCarInfomationRequestModel model)
    {
        GetCarInfomationModel getCarInfomationModel = new GetCarInfomationModel();
        var returnData = getCarInfomationModel.GetCarInfomation(model);
        return Ok(new { message = "Car information received successfully." });
    }
}