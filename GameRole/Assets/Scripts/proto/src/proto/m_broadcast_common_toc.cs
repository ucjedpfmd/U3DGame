namespace proto {
	public class m_broadcast_common_toc : Message
	{
		public int bc_id = 0;
		public int bc_type = 0;
		public int ban_level = 0;
		public object[] strings;
		public object[] nums;
		public m_broadcast_common_toc() {
		}
		public override string getMethodName() {
			return "broadcast_common";
		}
		public override string getClassName() {
			return "m_broadcast_common_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"bc_type", "int", "null"},new string[] {"ban_level", "int", "null"},new string[] {"strings", "array", "string"},new string[] {"nums", "array", "double"}};
		}
	}
}
