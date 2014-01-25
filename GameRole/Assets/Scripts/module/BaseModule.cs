namespace module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using com;
	using com.net.manager;

    public class BaseModule
    {
        protected Connection2 connect;
        public BaseModule()
        {
            connect = Connection2.getInstance();
            initListeners();
        }

        /**
         * 初始化socket监听器和初始化逻辑间的消息侦听
         */
        protected virtual void initListeners()
        {

        }
        /**
        * 监听来自socket的消息
        * @param type
        * @param handler
        */
        protected void addSocketListener<TMessage>(string type, Action<TMessage> handler) where TMessage : Message
        {
            ConnMgr.addSocketListener<TMessage>(type, handler);
        }

        /**
            * 删除来自socket的消息侦听器
            * @param type
            * @param handler
            */
        protected void removeSocketListener<TMessage>(string type, Action<TMessage> handler) where TMessage : Message
        {
			ConnMgr.removeSocketListener<TMessage>(type, handler);
        }

        /**
            * 向socket发送消息
            */
        protected void sendSocketMessage(Message vo)
        {
            connect.sendMessage(vo);
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

}
