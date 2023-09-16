using Microsoft.AspNetCore.Mvc;
using Car.Model;

[Route("api/[controller]")]
[ApiController]
public class GetCarInfomationController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] GetCarInfomationModel model)
    {
        ParentClass parentClass = new ParentClass();
        ChildOverwriteClass childOverwriteClass = new ChildOverwriteClass();

        //"Hi"
        string parentClassshadowMessage = parentClass.shadowMessage;
        //"XXX"
        string parentClassoverridMeessage = parentClass.overridMeessage;
        //null
        string parentClassmessage = parentClass.message;
        //"XXX"
        string parentClassOverridMeessage = parentClass.OverridMeessage;
        //null
        string parentClassMessage = parentClass.Message;

        //shadowMessage遮蓋（shadow）父類別中的 message屬性 : null
        string childOverwriteClassshadowMessage = childOverwriteClass.shadowMessage;
        //overridMeessage 調用到父類別 : "XXX"
        string childOverwriteClassoverridMeessage = childOverwriteClass.overridMeessage;
        //message 調用到父類別 由於子類別有建構子 : "OOO"
        string childOverwriteClassmessage = childOverwriteClass.message;
        //Hello from ChildClass  >> 調用到Overwrite : "Hello from ChildClass"
        string childOverwriteClassOverridMeessage = childOverwriteClass.OverridMeessage;
        //Message 調用到父類別 由於子類別有建構子 : "OOO"
        string childOverwriteClassMessage = childOverwriteClass.Message;

        var returnData = model.GetCarInfomation(model);

        return Ok(new { message = "Car information received successfully." });
    }
}