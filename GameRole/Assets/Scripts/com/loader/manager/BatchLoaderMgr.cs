using com.loader.item;
using com.net.manager;
using DCLib.ByteHelper;
using module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.loader.manager
{
    public class BatchLoaderMgr
    {
        private List<FileLoader> loaders;

        private List<FileData> list;
        public int size;
        public int loadCount = 0;

        public BatchLoaderMgr()
        {
            loaders = new List<FileLoader>();
            for(int i=0;i<5;i++){
                FileLoader item = new FileLoader();
                loaders.Add(item);
            }
        }
        public void add(string url, object data = null, bool forceRemote = false)
        {
            if (list == null) {
				list = new List<FileData>();
			}
            FileData item = new FileData();
            item.url = url;
            item.data = data;
            item.forceRemote = forceRemote;
            item.content = new ByteArray();
            list.Add(item);
            size = list.Count;
        }

        public void load() {
//			ThemeTrace.getInstance().appTxt(list == null ? "没有加载序列" : ("加载序列：" + list.length));
			if (list != null && list.Count > 0) {
                while (list.Count > 0)
                {
                    FileLoader loader = getLoader();
                    if (loader != null)
                    {
                        FileData item = list.ElementAt(0);
                        list.RemoveAt(0);
                        loader.load(item.url);
                        loader.readAll(item.content);
                        completeHandler(item);
                    }
                    else
                    {
                        break;
                    }               
                }
			}
		}

        private void completeHandler(FileData item) {
//			ThemeTrace.getInstance().appTxt("加载完成：" + loaderItem.url);
			if (item != null) {
                if (item.type == FileData.SWF || item.type == FileData.IMAGE)
                {

                }
                else if (item.type == FileData.FILE)
                {
                    Dispatcher.dispatch(ModuleCommand.BATCH_ITEM_COMPLETE, item);
					loadCount++;
					if (loadCount == size) {
						loadCount = 0;
                        Dispatcher.dispatch(ModuleCommand.BATCH_COMPLETE);
					}
				}
			}
		}

        private FileLoader getLoader() {
            if (loaders != null && loaders.Count > 0)
            {
                FileLoader item = loaders.ElementAt(0);
				loaders.RemoveAt(0);
                return item;
			}
			return null;
		}
    }
}
