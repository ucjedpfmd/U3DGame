namespace proto {
	public class m_anima_training_toc : Message
	{
		public int err_code = 0;
		public int grade = 0;
		public int level = 0;
		public int silver = 0;
		public int end_cool_time = 0;
		public int power = 0;
		public m_anima_training_toc() {
		}
		public override string getMethodName() {
			return "anima_training";
		}
		public override string getClassName() {
			return "m_anima_training_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"grade", "int", "null"},new string[] {"level", "int", "null"},new string[] {"silver", "int", "null"},new string[] {"end_cool_time", "int", "null"},new string[] {"power", "int", "null"}};
		}
	}
}
