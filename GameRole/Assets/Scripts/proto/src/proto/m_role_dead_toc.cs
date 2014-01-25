namespace proto {
	public class m_role_dead_toc : Message
	{
		public string killer = null;
		public int killer_power = 0;
		public int killer_type = 0;
		public int relive_silver = 0;
		public int dead_type = 0;
		public int drop_silver = 0;
		public object[] drop_items;
		public m_role_dead_toc() {
		}
		public override string getMethodName() {
			return "role_dead";
		}
		public override string getClassName() {
			return "m_role_dead_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"killer", "string", "null"},new string[] {"killer_power", "int", "null"},new string[] {"killer_type", "int", "null"},new string[] {"relive_silver", "int", "null"},new string[] {"dead_type", "int", "null"},new string[] {"drop_silver", "int", "null"},new string[] {"drop_items", "array", "int"}};
		}
	}
}
