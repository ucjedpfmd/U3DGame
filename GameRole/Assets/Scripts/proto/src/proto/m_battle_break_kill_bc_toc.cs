namespace proto {
	public class m_battle_break_kill_bc_toc : Message
	{
		public int bc_id = 0;
		public double role_id = 0;
		public string role_name = null;
		public double con_id = 0;
		public string con_name = null;
		public m_battle_break_kill_bc_toc() {
		}
		public override string getMethodName() {
			return "battle_break_kill_bc";
		}
		public override string getClassName() {
			return "m_battle_break_kill_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"con_id", "double", "null"},new string[] {"con_name", "string", "null"}};
		}
	}
}
