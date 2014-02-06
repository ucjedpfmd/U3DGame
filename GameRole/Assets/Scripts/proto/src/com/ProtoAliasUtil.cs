using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com
{
	class ProtoAliasUtil
	{
        private static Dictionary<object, object> aliasDic;

		public static string getClassNameByAlias(int alias){
			init();
            if (aliasDic.ContainsKey(alias) == false)
            {
                return null;
            }
			return aliasDic[alias].ToString();
		}
		
		public static int getAliasByClassName(string className){
			init();
			int alias = (int)aliasDic[className];
			return alias;
		}
		
		private static void init(){
			if(aliasDic == null){
                ProtoAlias alias = new ProtoAlias();
                aliasDic = alias.ALIAS;
			}
		}
	}

}
