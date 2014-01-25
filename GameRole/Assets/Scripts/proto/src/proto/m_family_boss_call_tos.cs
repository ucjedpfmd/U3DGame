namespace proto {
	public class m_family_boss_call_tos : Message
	{
		public int boss_type = 0;
		public m_family_boss_call_tos() {
		}
		public override string getMethodName() {
			return "family_boss_call";
		}
		public override string getClassName() {
			return "m_family_boss_call_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"boss_type", "int", "null"}};
		}
	}
}
