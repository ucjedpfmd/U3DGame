namespace proto {
	public class p_family_tree_log : Message
	{
		public int type = 0;
		public int item_id = 0;
		public int item_num = 0;
		public string role_name = null;
		public p_family_tree_log() {
		}
		public override string getClassName() {
			return "p_family_tree_log";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"item_id", "int", "null"},new string[] {"item_num", "int", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
