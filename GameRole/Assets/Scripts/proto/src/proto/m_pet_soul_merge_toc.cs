namespace proto {
	public class m_pet_soul_merge_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] update_souls;
		public object[] delete_souls;
		public m_pet_soul_merge_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_merge";
		}
		public override string getClassName() {
			return "m_pet_soul_merge_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"update_souls", "array", "p_pet_soul"},new string[] {"delete_souls", "array", "p_pet_soul"}};
		}
	}
}
