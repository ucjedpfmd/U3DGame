
using DCLib.ByteHelper;
namespace com.loader.item
{
    public class FileData
    {
        public const string SWF = "swf";
		public const string FILE = "file";
		public const string IMAGE = "image";
		public const string MAP = "map";

        public bool saveInPool; //是否保存到资源池中
		public object data;
		public function handler;
		public string url;
		public int priority;
		public bool reload;
		public string sourceType;
		public ByteArray content;
		public bool forceRemote;//是否强行加载远端资源

        		//根据后缀来确定类型，只有4种类型，对应不同的解析方式
		public string type {
            get { return getType(); }
		}

        private string getType()
        {
            //此处匹配如果需要更智能匹配，可以换成正则表达式
			int strLast = url.LastIndexOf(".");
			string endFix = url.Substring(strLast+1, url.Length - strLast-1);
            endFix = endFix.ToLower();
            if (endFix == SWF)
            {
                return SWF;
            }
            else if (endFix == "xml" || endFix == "txt" || endFix == "lib" || endFix == "mcms")
            {
                return FILE;
            }
            else if (endFix == "png" || endFix == "jpg")
            {
                return IMAGE;
            }
            return "非法文件类型！";
        }
    }
}
