using AdaptParameter.Common;

namespace AdaptParameter.Version002
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
            var securityToken = reader.GetMemberId();

            var member = MemberRepoRespoitory.Get(memberId);
            return member != null && SecurityTokenValidator.IsValid(securityToken);
        } 
    }
}
