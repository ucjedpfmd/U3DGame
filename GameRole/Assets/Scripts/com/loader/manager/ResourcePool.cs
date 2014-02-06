using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.loader.manager
{
    public class ResourcePool
    {
        private static Dictionary<string,object> sources = new Dictionary<string,object>();

		//除地图以外的资源，都添加到缓存
		public static void add(string url, object source) {
			sources[url] = source;
		}

		public static object get(string url) {
			return sources[url];
		}

		public static object remove(string url) {
			object source = get(url);
            sources.Remove(url);
			return source;
		}

		public static bool hasResource(string url) {
           return sources.ContainsKey(url);
		}

		public static object getClass(string url, string name) {
			
			return null;
		}

		public static void dispose() {
			sources = null;
		}

		public static Dictionary<string,object> getSource() {
			return sources;
		}
    }
}
