using System;
using AdaptParameter.Common;
using AdaptParameter.Version001;

namespace AdaptParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new MemberRespoitory();
            var validator = new SecurityTokenValidator();
            var device = new ControlAccessReaderDevice();

            var service = new ControlAccessService(repository, validator);

            var isAuthorized = service.IsAuthorized(
                new ControlAccessReaderDeviceAdpater(device));
            Console.WriteLine(isAuthorized);
            Console.ReadKey();
        }
    }

    public class ControlAccessReaderDeviceAdpater : IControlAccessReaderDevice
    {
        private readonly ControlAccessReaderDevice Device;

        public ControlAccessReaderDeviceAdpater(ControlAccessReaderDevice device)
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
