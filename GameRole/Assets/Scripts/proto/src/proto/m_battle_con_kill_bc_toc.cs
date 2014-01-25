namespace proto {
	public class m_battle_con_kill_bc_toc : Message
	{
		public int bc_id = 0;
		public double role_id = 0;
		public string role_name = null;
		public int kill_num = 0;
		public m_battle_con_kill_bc_toc() {
		}
		public override string getMethodName() {
			return "battle_con_kill_bc";
		}
		public override string getClassName() {
			return "m_battle_con_kill_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"kill_num", "int", "null"}};
		}
	}
}
