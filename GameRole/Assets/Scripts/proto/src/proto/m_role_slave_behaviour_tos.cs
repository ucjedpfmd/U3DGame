namespace proto {
	public class m_role_slave_behaviour_tos : Message
	{
		public int op_type = 0;
		public int option = 0;
		public double role_id = 0;
		public m_role_slave_behaviour_tos() {
		}
		public override string getMethodName() {
			return "role_slave_behaviour";
		}
		public override string getClassName() {
			return "m_role_slave_behaviour_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"option", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
