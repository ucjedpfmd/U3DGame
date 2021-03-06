//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoopManager : MonoBehaviour
{
	private static bool _isInited; //是否已经初始化完毕
	private static int _currentFrame; //当前第几帧
	public static int currentTime = 0; //当前时间
	private static int lastTime; //用于计算帧频
	//private static var frameRates:Array = []; //存放帧频
	private static double _realFrameRate = 30; //实际帧频
	private static Dictionary<object, function> frameLoopDic; //放循环函数

	//////////////////////////////////
	private static Dictionary<int, Dictionary<string,object>> timeoutDic; //放setTimeout函数
	private static Dictionary<object, function> timeLoopDic; //放定时器执行函数
	private static int delayIDKey; //键值
	/////////////////////////////////
	private static Dictionary<object, function> SecondLoopDic; //放定时器执行函数

	public LoopManager ()
	{
	}

	public static void init() {
		if (_isInited == false) {
			frameLoopDic = new Dictionary<object, function>(); //放循环函数
			timeoutDic = new Dictionary<int, Dictionary<string,object>>(); //放setTimeout函数
			timeLoopDic = new Dictionary<object, function>(); //放定时器执行函数	Rmap
			SecondLoopDic = new Dictionary<object, function>(); //放秒循环函数
			_isInited = true;
		}
	}

	public static void update(){
        frameLoop();
	}

	private static void frameLoop() {
        if (frameLoopDic == null)
        {
            return;
        }
        var buffer = new List<object>(frameLoopDic.Keys);
		foreach (var key in buffer) {
			function f = frameLoopDic[key];
			if (GameParameters.isDebug == true) {
				f();
			} else {
				f();
			}
		}
		//UISystem.upDate();
		//doFrameRate(); //计算帧频
	}

	public static void addToFrame(object key, function fun) {
        if (frameLoopDic.ContainsKey(key) == false)
        {
            frameLoopDic[key] = fun;
        }
	}

	public static void removeFromFrame(object key) {
		 if (frameLoopDic.ContainsKey(key) == true)
         {
              frameLoopDic.Remove(key);
         }
	}

    public static int setTimeout(function fun, int delay, object[] args = null) {
			if (delay == 0) {
                fun(args);
				return 0;
			}
			delayIDKey++;
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict["key"] = delayIDKey;
            dict["startTime"] = Time.time;
            dict["count"] = delay;
            dict["handler"] = fun;
            dict["arg"] = args;
            if (timeoutDic.ContainsKey(delayIDKey) == false)
            {
                timeoutDic[delayIDKey] = dict;
            }
			return delayIDKey;
		}

		/**
		 * 清除setTimeout
		 * @param id
		 *
		 */
		public static void clearTimeout(int id) {
            if (timeoutDic.ContainsKey(id) == true)
            {
                timeoutDic.Remove(id);
            }
		}

		public static bool hasTimeout(int id) {
            return timeoutDic.ContainsKey(id);
		}
}

