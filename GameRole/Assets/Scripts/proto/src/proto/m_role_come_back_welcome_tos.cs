namespace proto {
	public class m_role_come_back_welcome_tos : Message
	{
		public double role_id = 0;
		public m_role_come_back_welcome_tos() {
		}
		public override string getMethodName() {
			return "role_come_back_welcome";
		}
		public override string getClassName() {
			return "m_role_come_back_welcome_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
