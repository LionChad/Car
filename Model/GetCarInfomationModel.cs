using Car.SupplierService;

namespace Car.Model
{
    public partial class GetCarInfomationModel
    {
        #region Properties
        #endregion Properties

        #region Constructor
        public GetCarInfomationModel()
        {
        }
        #endregion

        #region GetCarInfomation
        public CarInfomationModel GetCarInfomation(object model)
        {
            #region 宣告
            string Local = string.Empty;
            CarInfomationModel result = null;
            #endregion 宣告

            #region 流程

            #region 取得供應商資訊
            var lHotelItineraryService = new SupplierServiceBuilder().GetCarInfomationService(Local);

            if (lHotelItineraryService != null)
            {
                result = lHotelItineraryService.GetCarInfomation(model);
            }

            return result;
            #endregion 取得供應商資訊

            #endregion 流程
        }
        #endregion

    }
}