namespace proto {
	public class m_role_slave_fight_toc : Message
	{
		public int err_code = 0;
		public int catch_type = 0;
		public int op_type = 0;
		public p_pet_embattle_fight_info fight_info = null;
		public m_role_slave_fight_toc() {
		}
		public override string getMethodName() {
			return "role_slave_fight";
		}
		public override string getClassName() {
			return "m_role_slave_fight_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"catch_type", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"fight_info", "p_pet_embattle_fight_info", "null"}};
		}
	}
}
