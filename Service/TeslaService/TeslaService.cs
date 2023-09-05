using Car.Model;

namespace Car.Service.TeslaService
{
    public class TeslaService : CarInfomationService
    {
        #region - 取得特斯拉汽車資訊 -
        /// <summary>
        /// 取得特斯拉汽車資訊
        /// </summary>
        /// <param name="updateSupplierStaticDataReq"></param>
        protected override CarInfomationModel GetCarInfomationAPI(object pBookingForm)
        {
            return new TeslaCarInfomationModel();
        }
        #endregion
    }
}