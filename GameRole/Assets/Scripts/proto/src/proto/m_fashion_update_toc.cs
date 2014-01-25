namespace proto {
	public class m_fashion_update_toc : Message
	{
		public p_fashion fashion = null;
		public m_fashion_update_toc() {
		}
		public override string getMethodName() {
			return "fashion_update";
		}
		public override string getClassName() {
			return "m_fashion_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fashion", "p_fashion", "null"}};
		}
	}
}
