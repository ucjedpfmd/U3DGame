namespace proto {
	public class m_activity_conlogin_fetch_tos : Message
	{
		public int op_type = 0;
		public int param = 0;
		public m_activity_conlogin_fetch_tos() {
		}
		public override string getMethodName() {
			return "activity_conlogin_fetch";
		}
		public override string getClassName() {
			return "m_activity_conlogin_fetch_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"param", "int", "null"}};
		}
	}
}
