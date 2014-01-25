namespace proto {
	public class m_family_activity_toc : Message
	{
		public object[] type_id;
		public m_family_activity_toc() {
		}
		public override string getMethodName() {
			return "family_activity";
		}
		public override string getClassName() {
			return "m_family_activity_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "array", "int"}};
		}
	}
}
