namespace proto {
	public class m_role_war_soul_move_tos : Message
	{
		public int op_type = 0;
		public object[] move_actions;
		public m_role_war_soul_move_tos() {
		}
		public override string getMethodName() {
			return "role_war_soul_move";
		}
		public override string getClassName() {
			return "m_role_war_soul_move_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"move_actions", "array", "p_war_soul_action"}};
		}
	}
}
