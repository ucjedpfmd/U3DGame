namespace proto {
	public class m_family_donate_tos : Message
	{
		public int donate_time = 0;
		public m_family_donate_tos() {
		}
		public override string getMethodName() {
			return "family_donate";
		}
		public override string getClassName() {
			return "m_family_donate_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"donate_time", "int", "null"}};
		}
	}
}
