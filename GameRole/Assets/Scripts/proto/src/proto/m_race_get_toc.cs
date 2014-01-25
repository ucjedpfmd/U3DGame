namespace proto {
	public class m_race_get_toc : Message
	{
		public int err_code = 0;
		public int type = 0;
		public int multiple = 0;
		public m_race_get_toc() {
		}
		public override string getMethodName() {
			return "race_get";
		}
		public override string getClassName() {
			return "m_race_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type", "int", "null"},new string[] {"multiple", "int", "null"}};
		}
	}
}
