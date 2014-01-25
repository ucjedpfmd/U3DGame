namespace proto {
	public class m_race_sign_up_toc : Message
	{
		public int err_code = 0;
		public m_race_sign_up_toc() {
		}
		public override string getMethodName() {
			return "race_sign_up";
		}
		public override string getClassName() {
			return "m_race_sign_up_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
