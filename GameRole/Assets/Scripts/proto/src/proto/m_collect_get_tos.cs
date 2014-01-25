namespace proto {
	public class m_collect_get_tos : Message
	{
		public int id = 0;
		public m_collect_get_tos() {
		}
		public override string getMethodName() {
			return "collect_get";
		}
		public override string getClassName() {
			return "m_collect_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
