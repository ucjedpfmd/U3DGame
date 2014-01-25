namespace proto {
	public class m_role_devote_info_tos : Message
	{
		public double role_id = 0;
		public m_role_devote_info_tos() {
		}
		public override string getMethodName() {
			return "role_devote_info";
		}
		public override string getClassName() {
			return "m_role_devote_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
