namespace proto {
	public class m_family_merge_agree_tos : Message
	{
		public double family_id = 0;
		public m_family_merge_agree_tos() {
		}
		public override string getMethodName() {
			return "family_merge_agree";
		}
		public override string getClassName() {
			return "m_family_merge_agree_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"}};
		}
	}
}
