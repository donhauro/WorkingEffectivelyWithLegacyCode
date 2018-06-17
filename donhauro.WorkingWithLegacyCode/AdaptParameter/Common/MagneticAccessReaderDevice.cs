using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptParameter.Common
{
    public class MagneticAccessReaderDevice: IControlAccessReaderDevice
    {
        public ControlAccessReaderDevice Device { get; }

        public MagneticAccessReaderDevice(ControlAccessReaderDevice device)
        {
            Device = device;
        }

        public string GetMemberId()
        {
            return Device.GetMemberId();
        }

        public string GetHardwareToken()
        {
            return Device.GetHardwareToken();
        }
    }
}
