using Microsoft.AspNetCore.Mvc;
using Car.Model;

[Route("api/[controller]")]
[ApiController]
public class GetCarInfomationController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] GetCarInfomationModel model)
    {
        #region 初階面試常見題目回答-繼承-鐵人賽第三日
        ParentClass parentClass = new ParentClass();
        ChildOverwriteClass childOverwriteClass = new ChildOverwriteClass();

        //"Hi"  public 可  protected 不可  private 不可
        string parentClassshadowMessage = parentClass.shadowMessage;

        //"XXX"  public 可  protected 不可  private 不可
        string parentClassoverridMeessage = parentClass.overridMeessage;

        //null  public 可  protected 不可  private 不可
        string parentClassmessage = parentClass.message;

        //"XXX"  public 可  protected 可  private 可
        string parentClassOverridMeessage = parentClass.OverridMeessage;

        //null  public 可  protected 可  private 可
        string parentClassMessage = parentClass.Message;



        //  public 可  protected 可  private 可
        //shadowMessage遮蓋（shadow）父類別中的 message屬性 : null
        string childOverwriteClassshadowMessage = childOverwriteClass.shadowMessage;

        //  public 可  protected 不可  private 不可
        //overridMeessage 調用到父類別 : "XXX"
        string childOverwriteClassoverridMeessage = childOverwriteClass.overridMeessage;

        //  public 可  protected 不可  private 不可
        //message 調用到父類別 由於子類別有建構子 : "OOO"
        string childOverwriteClassmessage = childOverwriteClass.message;

        //  public 可  protected 可  private 可
        //Hello from ChildClass  >> 調用到Overwrite : "Hello from ChildClass"
        string childOverwriteClassOverridMeessage = childOverwriteClass.OverridMeessage;

        //  public 可  protected 可  private 可但因message在建構子不可，所以不可，所以應該要給可
        //Message 調用到父類別 由於子類別有建構子 : "OOO"
        string childOverwriteClassMessage = childOverwriteClass.Message;

        #endregion

        #region 初階面試常見題目回答-OOP設計概念-鐵人賽第五日

        VehicleModel vehicle1 = new CarModel();
        VehicleModel vehicle2 = new Airplane();

        MoveAndPrint(vehicle1);
        MoveAndPrint(vehicle2);
        #endregion

        var returnData = model.GetCarInfomation(model);

        return Ok(new { message = "Car information received successfully." });
    }

    private static void MoveAndPrint(VehicleModel vehicle)
    {
        vehicle.Move();
    }
}