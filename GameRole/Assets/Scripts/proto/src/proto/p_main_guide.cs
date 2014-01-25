namespace proto {
	public class p_main_guide : Message
	{
		public int id = 0;
		public string name = null;
		public int npc_id = 0;
		public int type = 0;
		public int group_id = 0;
		public int order = 0;
		public int min_level = 0;
		public int max_level = 0;
		public int times = 0;
		public int max_times = 0;
		public p_main_guide() {
		}
		public override string getClassName() {
			return "p_main_guide";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"name", "string", "null"},new string[] {"npc_id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"group_id", "int", "null"},new string[] {"order", "int", "null"},new string[] {"min_level", "int", "null"},new string[] {"max_level", "int", "null"},new string[] {"times", "int", "null"},new string[] {"max_times", "int", "null"}};
		}
	}
}
