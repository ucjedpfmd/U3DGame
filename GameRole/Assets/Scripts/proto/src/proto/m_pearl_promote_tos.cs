namespace proto {
	public class m_pearl_promote_tos : Message
	{
		public int op_type = 0;
		public int pearl_pos = 0;
		public int type_id = 0;
		public int num = 0;
		public int times = 0;
		public m_pearl_promote_tos() {
		}
		public override string getMethodName() {
			return "pearl_promote";
		}
		public override string getClassName() {
			return "m_pearl_promote_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"pearl_pos", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"times", "int", "null"}};
		}
	}
}
