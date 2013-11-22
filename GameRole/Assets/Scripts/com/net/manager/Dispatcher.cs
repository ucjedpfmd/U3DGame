using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public delegate void function(params object[] arg);
class Dispatcher
{
    //public static delegate void function(params function arg);
    private static Dictionary<string, List<function>> observers = new Dictionary<string, List<function>>(); //KEY是消息名，值是数组，放函数
    private static Dictionary<function, function[]> mapping = new Dictionary<function, function[]>();//KEY是函数，值是类名和函数名

    public static void register(String type, function call, String module = null, String method = null)
    {       
        List<function> funcs;
        //mapping[function] = {"module": module, "method": method};
        
        if (observers.ContainsKey(type) == false)
        {
            funcs = new List<function>();
            observers[type] = funcs;
        }
        else
        {
            funcs = observers[type];
        }
        if (funcs.IndexOf(call) == -1)
        {
            funcs.Add(call);
        }
    }

    public static void remove(String type, function call)
    {
        List<function> funcs = observers[type];
        if (funcs != null)
        {
            int index = funcs.IndexOf(call);
            if (index != -1)
            {
                funcs.RemoveAt(index);
            }
        }
    }

    public static void dispatch(String type, params object[] arg)
    {
        List<function> funcs;
        if (observers.ContainsKey(type) == false)
        {
            return;
        }
        funcs = observers[type];
        for (int i = 0; i < funcs.Count; i++)
        {
            function call = funcs.ElementAt(i);
            if (arg.Length == 0 || (arg.Length == 1 && arg[0] == null))
            {
                call(null);
            }
            else
            {
                call(arg);
            }
        }
    }

}
