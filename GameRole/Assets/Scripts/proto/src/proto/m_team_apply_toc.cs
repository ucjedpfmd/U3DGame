namespace proto {
	public class m_team_apply_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public double teamer_id = 0;
		public double apply_id = 0;
		public string apply_name = null;
		public int team_id = 0;
		public int pick_type = 1;
		public m_team_apply_toc() {
		}
		public override string getMethodName() {
			return "team_apply";
		}
		public override string getClassName() {
			return "m_team_apply_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"teamer_id", "double", "null"},new string[] {"apply_id", "double", "null"},new string[] {"apply_name", "string", "null"},new string[] {"team_id", "int", "null"},new string[] {"pick_type", "int", "null"}};
		}
	}
}
