namespace proto {
	public class m_refining_quality_tos : Message
	{
		public int op_type = 0;
		public p_refining equip = null;
		public object[] material;
		public bool auto_buy = true;
		public bool bind_first = true;
		public m_refining_quality_tos() {
		}
		public override string getMethodName() {
			return "refining_quality";
		}
		public override string getClassName() {
			return "m_refining_quality_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"equip", "p_refining", "null"},new string[] {"material", "array", "p_refining"},new string[] {"auto_buy", "bool", "null"},new string[] {"bind_first", "bool", "null"}};
		}
	}
}
