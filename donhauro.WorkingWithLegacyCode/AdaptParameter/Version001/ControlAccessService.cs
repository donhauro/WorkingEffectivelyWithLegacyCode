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

        public bool IsAuthorized(ControlAccessReaderDevice reader)
        {
            var memberId = reader.GetMemberId();
            var securityToken = reader.GetMemberId();

            var member = MemberRepoRespoitory.Get(memberId);
            return member != null && SecurityTokenValidator.IsValid(securityToken);
        } 
    }
}
