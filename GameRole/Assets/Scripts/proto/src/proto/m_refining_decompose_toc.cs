namespace proto {
	public class m_refining_decompose_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] item_list;
		public m_refining_decompose_toc() {
		}
		public override string getMethodName() {
			return "refining_decompose";
		}
		public override string getClassName() {
			return "m_refining_decompose_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"item_list", "array", "p_refining_item"}};
		}
	}
}
