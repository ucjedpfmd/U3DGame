namespace proto {
	public class m_refining_stone_tos : Message
	{
		public int op_type = 0;
		public p_refining equip = null;
		public p_refining stone = null;
		public bool auto_buy = true;
		public bool bind_first = true;
		public m_refining_stone_tos() {
		}
		public override string getMethodName() {
			return "refining_stone";
		}
		public override string getClassName() {
			return "m_refining_stone_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"equip", "p_refining", "null"},new string[] {"stone", "p_refining", "null"},new string[] {"auto_buy", "bool", "null"},new string[] {"bind_first", "bool", "null"}};
		}
	}
}
