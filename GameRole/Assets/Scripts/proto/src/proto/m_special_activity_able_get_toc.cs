namespace proto {
	public class m_special_activity_able_get_toc : Message
	{
		public int activity_key = 0;
		public m_special_activity_able_get_toc() {
		}
		public override string getMethodName() {
			return "special_activity_able_get";
		}
		public override string getClassName() {
			return "m_special_activity_able_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_key", "int", "null"}};
		}
	}
}
