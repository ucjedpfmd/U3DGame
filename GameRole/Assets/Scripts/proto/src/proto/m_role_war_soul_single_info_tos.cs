namespace proto {
	public class m_role_war_soul_single_info_tos : Message
	{
		public double role_id = 0;
		public int index = 0;
		public m_role_war_soul_single_info_tos() {
		}
		public override string getMethodName() {
			return "role_war_soul_single_info";
		}
		public override string getClassName() {
			return "m_role_war_soul_single_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"index", "int", "null"}};
		}
	}
}
