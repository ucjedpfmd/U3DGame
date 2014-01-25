namespace proto {
	public class m_role_compare_power_tos : Message
	{
		public double other_role_id = 0;
		public m_role_compare_power_tos() {
		}
		public override string getMethodName() {
			return "role_compare_power";
		}
		public override string getClassName() {
			return "m_role_compare_power_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"other_role_id", "double", "null"}};
		}
	}
}
