using System;

namespace AdaptParameter.Common
{
    public class ControlAccessReaderDevice
    {
        public ControlAccessReaderDevice()
        {
            if (!HardwaredongleFound())
                throw new Exception("HardwareDectionError");
        }

        private bool HardwaredongleFound()
        {
            return false;
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