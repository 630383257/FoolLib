﻿using System.Collections.Generic;

namespace Fool.Events.Handlers {
    /// <summary>
    /// 事件处理器服务
    /// </summary>
    public interface IEventHandlerManager {
        /// <summary>
        /// 获取事件处理器列表
        /// </summary>
        /// <typeparam name="TEvent">事件类型</typeparam>
        List<IEventHandler<TEvent>> GetHandlers<TEvent>() where TEvent : IEvent;
        /// <summary>
        /// 获取同步事件处理器列表
        /// </summary>
        /// <typeparam name="TEvent">事件类型</typeparam>
        List<ISyncEventHandler<TEvent>> GetSyncHandlers<TEvent>() where TEvent : IEvent;
    }
}
