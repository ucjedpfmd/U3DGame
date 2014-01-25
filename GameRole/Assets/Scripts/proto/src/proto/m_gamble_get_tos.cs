namespace proto {
	public class m_gamble_get_tos : Message
	{
		public int pf_vip = 0;
		public m_gamble_get_tos() {
		}
		public override string getMethodName() {
			return "gamble_get";
		}
		public override string getClassName() {
			return "m_gamble_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pf_vip", "int", "null"}};
		}
	}
}
