namespace proto {
	public class m_ice_arrows_toc : Message
	{
		public object[] arrows;
		public m_ice_arrows_toc() {
		}
		public override string getMethodName() {
			return "ice_arrows";
		}
		public override string getClassName() {
			return "m_ice_arrows_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"arrows", "array", "p_ice_arrow"}};
		}
	}
}
