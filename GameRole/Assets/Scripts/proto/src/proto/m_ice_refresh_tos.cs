namespace proto {
	public class m_ice_refresh_tos : Message
	{
		public bool one_key = false;
		public m_ice_refresh_tos() {
		}
		public override string getMethodName() {
			return "ice_refresh";
		}
		public override string getClassName() {
			return "m_ice_refresh_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"one_key", "bool", "null"}};
		}
	}
}
