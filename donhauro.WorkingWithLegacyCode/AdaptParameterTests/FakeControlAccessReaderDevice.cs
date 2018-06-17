using AdaptParameter.Common;

namespace AdaptParameterTests
{
    public class FakeControlAccessReaderDevice: IControlAccessReaderDevice
    {
        public string GetMemberId()
        {
            return "01919";
        }

        public string GetHardwareToken()
        {
            return "0303033003";
        }
    }
}
