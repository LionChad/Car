using System.ComponentModel;
using Car.Interfaces;
using Car.Service;
using Car.Service.AMCService;
using Car.Service.TeslaService;
using Car.Service.VOLVOService;

namespace Car.SupplierService
{
    public class SupplierServiceBuilder
    {
        #region -Enum-
        public enum EnumSupplierCode
        {
            [Description("")]
            NoData,
            [Description("富豪")]
            VOLVO,
            [Description("美國汽車")]
            AMC,
            [Description("特斯拉")]
            Tesla,
        }
        #endregion

        #region -Properties-

        #endregion

        #region -建構子-
        #endregion

        #region -Methods-

        #region 公有方法
        public ICarInfomationService GetCarInfomationService(string local)
        {
            return GetServices(local);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 取得供應商服務
        /// </summary>
        /// <param name="pLocal"></param>
        /// <returns></returns>
        private CarInfomationService GetServices(string pLocal)
        {
            CarInfomationService lHotelService = null;

            EnumSupplierCode enumReturn = new EnumSupplierCode();
            //字串比對Enum的Description，找到對應的枚舉
            foreach (var item in Enum.GetValues(typeof(EnumSupplierCode)))
            {
                if (GetDescription(item) == pLocal.ToUpper())
                {
                    enumReturn = (EnumSupplierCode)item;
                    break;
                }
            }

            switch (enumReturn)
            {
                case EnumSupplierCode.VOLVO:
                    lHotelService = new VOLVOService();
                    break;
                case EnumSupplierCode.AMC:
                    lHotelService = new AMCService();
                    break;
                case EnumSupplierCode.Tesla:
                    lHotelService = new TeslaService();
                    break;
            }

            return lHotelService;
        }

        private string GetDescription(object T)
        {
            var type = T.GetType();
            var members = type.GetMember(T.ToString());
            var attributes = members[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            var description = ((DescriptionAttribute)attributes[0]).Description;

            return description;
        }
        #endregion

        #endregion
    }
}
