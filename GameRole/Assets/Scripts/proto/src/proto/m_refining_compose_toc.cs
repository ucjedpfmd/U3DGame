namespace proto {
	public class m_refining_compose_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] item_list;
		public int fee = 0;
		public m_refining_compose_toc() {
		}
		public override string getMethodName() {
			return "refining_compose";
		}
		public override string getClassName() {
			return "m_refining_compose_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"item_list", "array", "p_refining"},new string[] {"fee", "int", "null"}};
		}
	}
}
