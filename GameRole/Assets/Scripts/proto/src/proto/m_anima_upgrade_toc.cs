namespace proto {
	public class m_anima_upgrade_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int grade = 0;
		public int level = 0;
		public int num = 0;
		public m_anima_upgrade_toc() {
		}
		public override string getMethodName() {
			return "anima_upgrade";
		}
		public override string getClassName() {
			return "m_anima_upgrade_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"grade", "int", "null"},new string[] {"level", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
