using DCLib.ByteHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace com.loader.item
{
    public class FileLoader
    {
        private string url;
        private FileStream loader;
        public FileLoader()
        {
        }
        public void load(string url, bool forceRemote = false)
        {
			this.url = GameParameters.getInstance().resourceHost + url;
			if (File.Exists(this.url) == false)
            {
                return;
            }           
			loader = File.OpenRead(this.url);
        }

        public void readAll(ByteArray tarByte)
        {
            byte[] tarByteList = new byte[loader.Length];
            loader.Read(tarByteList, 0, (int)loader.Length);
			tarByte.writeBytes(tarByteList);
        }
    }
}
