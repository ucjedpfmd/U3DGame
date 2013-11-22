using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BaseModule
{
    
    public BaseModule()
    {
        initListeners();
    }

    /**
     * 初始化socket监听器和初始化逻辑间的消息侦听
     */
    protected virtual void initListeners()
    {

    }

    /**
     * 向外部分发消息
     *
     * @param type
     * @param params
     *
     */
    protected virtual void dispatch(String type, object param = null)
    {
        Dispatcher.dispatch(type, param);
    }

    /**
     * 侦听来模块逻辑间的消息
     * @param type
     * @param handler
     *
     */
    protected virtual void addMessageListener(String type, function handler)
    {
        Dispatcher.register(type, handler);
    }

    /**
     * 删除来模块逻辑间的消息
     * @param type
     * @param handler
     */
    protected virtual void removeMessageListener(String type, function handler)
    {
        Dispatcher.remove(type, handler);
    }
}
