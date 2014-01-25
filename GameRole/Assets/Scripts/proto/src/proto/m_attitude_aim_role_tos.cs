namespace proto {
	public class m_attitude_aim_role_tos : Message
	{
		public double role_id = 0;
		public int optype = 0;
		public m_attitude_aim_role_tos() {
		}
		public override string getMethodName() {
			return "attitude_aim_role";
		}
		public override string getClassName() {
			return "m_attitude_aim_role_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"optype", "int", "null"}};
		}
	}
}
