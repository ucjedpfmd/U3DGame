namespace proto {
	public class m_bubble_msg_toc : Message
	{
		public int actor_type = 0;
		public double actor_id = 0;
		public string actor_name = null;
		public int actor_sex = 0;
		public int actor_faction = 0;
		public int action_type = 0;
		public string msg = null;
		public double to_role_id = 0;
		public int actor_category = 1;
		public object[] titles;
		public m_bubble_msg_toc() {
		}
		public override string getMethodName() {
			return "bubble_msg";
		}
		public override string getClassName() {
			return "m_bubble_msg_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_type", "int", "null"},new string[] {"actor_id", "double", "null"},new string[] {"actor_name", "string", "null"},new string[] {"actor_sex", "int", "null"},new string[] {"actor_faction", "int", "null"},new string[] {"action_type", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"to_role_id", "double", "null"},new string[] {"actor_category", "int", "null"},new string[] {"titles", "array", "int"}};
		}
	}
}
