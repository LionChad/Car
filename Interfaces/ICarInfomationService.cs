using Car.Model;

namespace Car.Interfaces
{
    public interface ICarInfomationService
    {
        /// <summary>
        /// 取得供應商訂單資訊
        /// </summary>
        /// <param name="pBookingForm"></param>
        /// <returns></returns>
        CarInfomationModel GetCarInfomation(object pBookingForm);
    }
}
