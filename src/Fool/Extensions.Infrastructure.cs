using System;
using Microsoft.Extensions.DependencyInjection;
using Fool.Dependency;

namespace Fool {
    /// <summary>
    /// 系统扩展 - 基础设施
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 注册Fool基础设施服务
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="configs">依赖配置</param>
        public static IServiceProvider AddFool( this IServiceCollection services, params IConfig[] configs ) {
            return new DependencyConfiguration( services, configs ).Config();
        }
    }
}
