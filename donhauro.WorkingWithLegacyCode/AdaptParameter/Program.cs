using System;
using AdaptParameter.Common;
using AdaptParameter.Version002;

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

            var isAuthorized = service.IsAuthorized(new MagneticAccessReaderDevice(device));
            Console.WriteLine(isAuthorized);
            Console.ReadKey();
        }
    }
}
