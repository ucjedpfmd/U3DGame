namespace proto {
	public class m_refining_decompose_tos : Message
	{
		public int op_type = 0;
		public object[] id_list;
		public m_refining_decompose_tos() {
		}
		public override string getMethodName() {
			return "refining_decompose";
		}
		public override string getClassName() {
			return "m_refining_decompose_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"id_list", "array", "int"}};
		}
	}
}
