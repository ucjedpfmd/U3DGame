namespace proto {
	public class m_pet_devote_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public p_pet pet_info = null;
		public object[] devote_ids;
		public m_pet_devote_toc() {
		}
		public override string getMethodName() {
			return "pet_devote";
		}
		public override string getClassName() {
			return "m_pet_devote_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"pet_info", "p_pet", "null"},new string[] {"devote_ids", "array", "double"}};
		}
	}
}
