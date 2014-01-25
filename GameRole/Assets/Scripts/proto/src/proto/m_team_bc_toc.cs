namespace proto {
	public class m_team_bc_toc : Message
	{
		public int bc_id = 0;
		public double role_id = 0;
		public string role_name = null;
		public int map_id = 0;
		public int op_type = 0;
		public m_team_bc_toc() {
		}
		public override string getMethodName() {
			return "team_bc";
		}
		public override string getClassName() {
			return "m_team_bc_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bc_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"map_id", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
