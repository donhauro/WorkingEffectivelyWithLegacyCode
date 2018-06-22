using System;
using AdaptParameter.Common;

namespace AdaptParameter.Version001
{
    public class ControlAccessService
    {
        private readonly MemberRespoitory MemberRepoRespoitory;
        private readonly SecurityTokenValidator SecurityTokenValidator;

        public ControlAccessService(MemberRespoitory memberRepoRespoitory,
            SecurityTokenValidator securityTokenValidator)
        {
            MemberRepoRespoitory = memberRepoRespoitory;
            SecurityTokenValidator = securityTokenValidator;
        }

        public bool IsAuthorized(IControlAccessReaderDevice reader)
        {
            var memberId = reader.GetMemberId();
            var securityToken = reader.GetHardwareToken();

            Console.WriteLine("Access control is running...");

            var member = MemberRepoRespoitory.Get(memberId);
            return member != null && SecurityTokenValidator.IsValid(securityToken);
        }

    }
}
