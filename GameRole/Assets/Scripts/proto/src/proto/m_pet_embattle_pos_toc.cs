namespace proto {
	public class m_pet_embattle_pos_toc : Message
	{
		public int op_type = 0;
		public int err_code = 0;
		public string reason = null;
		public object[] embattle_info;
		public m_pet_embattle_pos_toc() {
		}
		public override string getMethodName() {
			return "pet_embattle_pos";
		}
		public override string getClassName() {
			return "m_pet_embattle_pos_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"embattle_info", "array", "p_pet_brief"}};
		}
	}
}
