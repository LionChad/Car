using Car.Model;

namespace Car.Service.AMCService
{
    public class AMCService : CarInfomationService
    {
        #region - 取得美國汽車資訊 -
        /// <summary>
        /// 取得美國汽車資訊
        /// </summary>
        /// <param name="updateSupplierStaticDataReq"></param>
        protected override CarInfomationModel GetCarInfomationAPI(object pBookingForm)
        {
            var restut = new AMCCarInfomationModel();
            restut.Move();
            var test = AMCCarInfomationModel.MovingDistance(1, 2);
            return restut;
        }
        #endregion
    }
}