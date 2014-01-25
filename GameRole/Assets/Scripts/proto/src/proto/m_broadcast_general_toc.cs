namespace proto {
	public class m_broadcast_general_toc : Message
	{
		public object[] type;
		public int sub_type = 0;
		public int ban_level = 0;
		public string content = null;
		public m_broadcast_general_toc() {
		}
		public override string getMethodName() {
			return "broadcast_general";
		}
		public override string getClassName() {
			return "m_broadcast_general_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "array", "int"},new string[] {"sub_type", "int", "null"},new string[] {"ban_level", "int", "null"},new string[] {"content", "string", "null"}};
		}
	}
}
