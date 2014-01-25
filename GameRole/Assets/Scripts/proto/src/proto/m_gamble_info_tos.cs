namespace proto {
	public class m_gamble_info_tos : Message
	{
		public int pf_vip = 0;
		public m_gamble_info_tos() {
		}
		public override string getMethodName() {
			return "gamble_info";
		}
		public override string getClassName() {
			return "m_gamble_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pf_vip", "int", "null"}};
		}
	}
}
