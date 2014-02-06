using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module
{
    public class ModuleCommand
    {
        /**场景**/
        public static string ENTER_GAME = "ENTER_GAME";
        public static string CHANGE_MAP = "CHANGE_MAP";
        public static string START_UP_SCENE = "START_UP_SCENE";
        public static string OPEN_NPC_PANEL = "OPEN_NPC_PANEL";

        /**配置文件加载**/
        public static string BATCH_ITEM_PROGRESS = "batchItemProgress";
        public static string BATCH_ITEM_COMPLETE = "batchItemComplete";
        public static string BATCH_COMPLETE = "batchComplete";
        public static string BATCH_ITEM_IO_ERROR = "batchItemIOError";
    }

}
