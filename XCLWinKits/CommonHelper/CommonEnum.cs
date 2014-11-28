using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CommonHelper
{
    public class CommonEnum
    {
        public enum CodingEnum
        {
            [Description("Unicode")]
            Unicode,
            [Description("UTF-8")]
            UTF8,
            [Description("GB2312")]
            GB2312
        }

        public enum EncryptEnum
        {
            Base64,
            AES,
            DES,
            RC4,
            Rabbit,
            TripleDes,
            迅雷地址,
            快车地址,
            旋风地址
        }
    }
}
