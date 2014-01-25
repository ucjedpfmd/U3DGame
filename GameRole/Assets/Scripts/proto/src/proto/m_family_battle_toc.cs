namespace proto {
	public class m_family_battle_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] role_list;
		public string family_name = null;
		public int score = 0;
		public m_family_battle_toc() {
		}
		public override string getMethodName() {
			return "family_battle";
		}
		public override string getClassName() {
			return "m_family_battle_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"role_list", "array", "p_family_battle_role"},new string[] {"family_name", "string", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
