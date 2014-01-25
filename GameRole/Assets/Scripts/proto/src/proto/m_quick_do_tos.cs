namespace proto {
	public class m_quick_do_tos : Message
	{
		public int id = 0;
		public int times = 0;
		public int op_type = 0;
		public int type_id = 0;
		public int item_num = 0;
		public bool auto_buy = true;
		public m_quick_do_tos() {
		}
		public override string getMethodName() {
			return "quick_do";
		}
		public override string getClassName() {
			return "m_quick_do_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"times", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"item_num", "int", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
