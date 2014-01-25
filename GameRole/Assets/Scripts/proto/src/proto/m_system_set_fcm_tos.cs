namespace proto {
	public class m_system_set_fcm_tos : Message
	{
		public string name = null;
		public string card = null;
		public m_system_set_fcm_tos() {
		}
		public override string getMethodName() {
			return "system_set_fcm";
		}
		public override string getClassName() {
			return "m_system_set_fcm_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"name", "string", "null"},new string[] {"card", "string", "null"}};
		}
	}
}
