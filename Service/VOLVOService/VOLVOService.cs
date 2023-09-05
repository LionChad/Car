using Car.Model;

namespace Car.Service.VOLVOService
{
    public class VOLVOService : CarInfomationService
    {
        #region - 取得富豪汽車資訊 -
        /// <summary>
        /// 取得富豪汽車資訊
        /// </summary>
        /// <param name="updateSupplierStaticDataReq"></param>
        protected override CarInfomationModel GetCarInfomationAPI(object pBookingForm)
        {
            return new VOLVOCarInfomationModel();
        }
        #endregion
    }
}