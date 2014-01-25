namespace proto {
	public class m_collect_stop_tos : Message
	{
		public int id = 0;
		public m_collect_stop_tos() {
		}
		public override string getMethodName() {
			return "collect_stop";
		}
		public override string getClassName() {
			return "m_collect_stop_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
