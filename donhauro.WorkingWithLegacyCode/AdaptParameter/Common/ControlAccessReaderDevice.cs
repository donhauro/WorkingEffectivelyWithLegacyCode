using System;

namespace AdaptParameter.Common
{
    public class ControlAccessReaderDevice
    {
        public ControlAccessReaderDevice()
        {
            throw new Exception("HardwareDectionError");
        }

        public string GetMemberId()
        {
            return "0001";
        }

        public string GetHardwareToken()
        {
            return Guid.NewGuid().ToString("D");
        }
    }
}