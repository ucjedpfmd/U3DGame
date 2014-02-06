using com.globals;
using com.loader.manager;
using DCLib.ByteHelper;
using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

namespace com.loader
{
    public class CommonLocator
    {
        private static Dictionary<string,object> map;
        public static bool parseXMLFile() {
			ByteArray bytes = ResourcePool.remove(GameConfig.XML_LIB_URL) as ByteArray;
			if (bytes != null) {
				try {
					bytes.Uncompress();
				} catch (Exception e) {
				}
				
				map = new Dictionary<string,object>();
				while (bytes.Length != bytes.Postion) {
					string name = bytes.readUTF();
					if(name == "fish.xml"){
						Debug.Log(name);
					}
					int size = bytes.readInt();
                    if (size > bytes.Length)
                    {
						return false;
					}
                    ByteArray xmlData;
                    byte[] xmlDataList = new byte[size];
                    bytes.readBytes(xmlDataList, 0, (uint)size);
                    xmlData = new ByteArray(xmlDataList);
					map[name] = xmlData;
				}
				return true;
			}
			return false;
		}
        public static XmlDocument getXML(string fileName)
        {
            XmlDocument xml;
            if (map[fileName] is XmlDocument)
            {
                return map[fileName] as XmlDocument;
			} else {
                ByteArray byteArr = map[fileName] as ByteArray;
                xml = new XmlDocument();
                xml.Load(byteArr.MemoryStream);
                map[fileName] = xml;
				Debug.Log(xml.ToString());
			}
            return map[fileName] as XmlDocument;
		}

    }
}
