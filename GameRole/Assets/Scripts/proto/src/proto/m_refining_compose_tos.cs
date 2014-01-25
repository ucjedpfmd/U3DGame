namespace proto {
	public class m_refining_compose_tos : Message
	{
		public int op_type = 0;
		public object[] material;
		public m_refining_compose_tos() {
		}
		public override string getMethodName() {
			return "refining_compose";
		}
		public override string getClassName() {
			return "m_refining_compose_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"material", "array", "p_refining"}};
		}
	}
}
