namespace proto {
	public class m_refining_extra_tos : Message
	{
		public int op_type = 0;
		public p_refining equip = null;
		public object[] extra_stone;
		public object[] lock_stat;
		public bool auto_buy = true;
		public bool bind_first = true;
		public m_refining_extra_tos() {
		}
		public override string getMethodName() {
			return "refining_extra";
		}
		public override string getClassName() {
			return "m_refining_extra_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"equip", "p_refining", "null"},new string[] {"extra_stone", "array", "p_refining"},new string[] {"lock_stat", "array", "int"},new string[] {"auto_buy", "bool", "null"},new string[] {"bind_first", "bool", "null"}};
		}
	}
}
