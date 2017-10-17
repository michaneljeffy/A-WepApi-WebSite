using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gma.QrCodeNet;

namespace RedBox.BLL.Services.ShowsServices
{
    public class QRCodeService
    {
        const int QRCODE_SZIE= 350;

        const string ORCODE_EXTEND = ".png";

        const string PRE = "wechat/machine?machine_code=";

        public static string GetQRCodeByMachineCode()
        {
            return "";
        }

        private void GenerateQRCode()
        {
            
        }
    }
}
