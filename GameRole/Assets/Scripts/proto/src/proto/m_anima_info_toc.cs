namespace proto {
	public class m_anima_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public int grade = 0;
		public int level = 0;
		public int end_cool_time = 0;
		public int power = 0;
		public m_anima_info_toc() {
		}
		public override string getMethodName() {
			return "anima_info";
		}
		public override string getClassName() {
			return "m_anima_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"grade", "int", "null"},new string[] {"level", "int", "null"},new string[] {"end_cool_time", "int", "null"},new string[] {"power", "int", "null"}};
		}
	}
}
