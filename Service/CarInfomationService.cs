using Car.Interfaces;
using Car.Model;

namespace Car.Service
{
    public abstract class CarInfomationService : ICarInfomationService
    {
        #region Implement Interface

        #region 取得汽車資訊
        /// <summary>
        /// 取得汽車資訊
        /// </summary>
        /// <param name="pBookingForm"></param>
        /// <returns></returns>
        public CarInfomationModel GetCarInfomation(object pBookingForm)
        {
            return GetCarInfomationAPI(pBookingForm); ;
        }
        #endregion
        #endregion

        #region Abstract Method
        /// <summary>
        /// 取得汽車資訊 API
        /// </summary>
        /// <param name="pBookingForm"></param>
        /// <returns></returns>
        protected abstract CarInfomationModel GetCarInfomationAPI(object pBookingForm);
        #endregion
    }
}