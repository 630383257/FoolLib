using Fool.Domains.Sessions;
using Fool.Logs;
using Fool.Logs.Core;

namespace Fool.Domains.Services {
    /// <summary>
    /// 领域服务
    /// </summary>
    public abstract class DomainServiceBase : IDomainService {
        /// <summary>
        /// 初始化领域服务
        /// </summary>
        protected DomainServiceBase() {
            Log = NullLog.Instance;
            Session = Fool.Domains.Sessions.Session.Null;
        }

        /// <summary>
        /// 日志
        /// </summary>
        public ILog Log { get; set; }

        /// <summary>
        /// 用户会话
        /// </summary>
        public ISession Session { get; set; }
    }
}
