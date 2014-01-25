namespace proto {
	public class m_team_roles_toc : Message
	{
		public int team_id = 0;
		public object[] team_roles;
		public int pick_type = 1;
		public object[] visible_roles;
		public m_team_roles_toc() {
		}
		public override string getMethodName() {
			return "team_roles";
		}
		public override string getClassName() {
			return "m_team_roles_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"team_id", "int", "null"},new string[] {"team_roles", "array", "p_team_role"},new string[] {"pick_type", "int", "null"},new string[] {"visible_roles", "array", "double"}};
		}
	}
}
