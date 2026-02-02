using System;
using System.Collections.Generic;
using System.Net;
using System.Security.AccessControl;

namespace ET
{
    public class HttpComponentAwakeSystem : AwakeSystem<HttpComponent, string>
    {
        public override void Awake(HttpComponent self, string address)
        {
            try
            {
                self.Load();
                
                self.Listener = new HttpListener();

                foreach (string s in address.Split(';'))
                {
                    if (s.Trim() == "")
                    {
                        continue;
                    }

                    Console.WriteLine(s);   
                    self.Listener.Prefixes.Add(s);
                }

                self.Listener.Start();

                self.Accept().Coroutine();
            }
            catch (HttpListenerException e)
            {
                throw new Exception($"请现在cmd中运行: netsh http add urlacl url=http://*:你的address中的端口/ user=Everyone, address: {address}", e);
            }
        }
    }

    [ObjectSystem]
    public class HttpComponentLoadSystem: LoadSystem<HttpComponent>
    {
        public override void Load(HttpComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class HttpComponentDestroySystem: DestroySystem<HttpComponent>
    {
        public override void Destroy(HttpComponent self)
        {
            self.Listener.Stop();
            self.Listener.Close();
        }
    }
    
    public static class HttpComponentSystem
    {
        public static void Load(this HttpComponent self)
        {
            self.dispatcher = new Dictionary<string, IHttpHandler>();

            List<Type> types = EventSystem.Instance.GetTypes(typeof (HttpHandlerAttribute));

            SceneType sceneType = self.GetParent<Scene>().SceneType;

            foreach (Type type in types)
            {
                object[] attrs = type.GetCustomAttributes(typeof(HttpHandlerAttribute), false);
                if (attrs.Length == 0)
                {
                    continue;
                }

                HttpHandlerAttribute httpHandlerAttribute = (HttpHandlerAttribute)attrs[0];

                if (httpHandlerAttribute.SceneType != sceneType)
                {
                    continue;
                }

                object obj = Activator.CreateInstance(type);

                IHttpHandler ihttpHandler = obj as IHttpHandler;
                if (ihttpHandler == null)
                {
                    throw new Exception($"HttpHandler handler not inherit IHttpHandler class: {obj.GetType().FullName}");
                }
                self.dispatcher.Add(httpHandlerAttribute.Path, ihttpHandler);
            }
        }
        
        public static async ETTask Accept(this HttpComponent self)
        {
            long instanceId = self.InstanceId;
            while (self.InstanceId == instanceId)
            {
                try
                {
                    HttpListenerContext context = await self.Listener.GetContextAsync();
                    self.Handle(context).Coroutine();
                }
                catch (Exception e)
                {
                    Log.Error(e);
                }
            }
        }

        public static async ETTask Handle(this HttpComponent self, HttpListenerContext context)
        {
            string abspath = string.Empty;
            string rawurl = string.Empty;
            try
            {
                IHttpHandler handler;

                if (self.dispatcher.TryGetValue(context.Request.Url.AbsolutePath, out handler))
                {
                    await handler.Handle(self.Domain, context);
                }
                else
                {
                    
                    if (context != null && context.Request != null)
                    {
                        abspath = context.Request.Url.AbsolutePath;
                        rawurl = context.Request.RawUrl;
                    }
                    //Console.WriteLine($"HttpComponent_Handle Failed: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {abspath} {rawurl}");
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
            finally
            {
                // 安全释放资源
                try
                {
                    context.Request.InputStream.Dispose();
                    context.Response.OutputStream.Dispose();
                }
                catch (HttpListenerException ex)
                {
                    Console.WriteLine($"释放 HttpListener 资源时发生网络异常: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {abspath} {rawurl}");
                    // 记录日志但不抛出，避免影响主线程
                    Log.Debug($"释放 HttpListener 资源时发生网络异常: {ex.Message}");
                }
            }
        }
    }
}