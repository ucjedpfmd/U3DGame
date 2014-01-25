namespace proto {
	public class m_pet_soul_call_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int npc_id = 0;
		public m_pet_soul_call_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_call";
		}
		public override string getClassName() {
			return "m_pet_soul_call_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"npc_id", "int", "null"}};
		}
	}
}
