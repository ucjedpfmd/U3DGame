namespace proto {
	public class m_role_slave_behaviour_toc : Message
	{
		public int err_code = 0;
		public int pet_skill_exp = 0;
		public int op_type = 0;
		public int option = 0;
		public double role_id = 0;
		public m_role_slave_behaviour_toc() {
		}
		public override string getMethodName() {
			return "role_slave_behaviour";
		}
		public override string getClassName() {
			return "m_role_slave_behaviour_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_skill_exp", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"option", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
