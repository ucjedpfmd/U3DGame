namespace proto {
	public class m_family_detail_tos : Message
	{
		public double family_id = 0;
		public m_family_detail_tos() {
		}
		public override string getMethodName() {
			return "family_detail";
		}
		public override string getClassName() {
			return "m_family_detail_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"}};
		}
	}
}
