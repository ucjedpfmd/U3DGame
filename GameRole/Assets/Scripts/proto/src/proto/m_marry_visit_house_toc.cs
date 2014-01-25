namespace proto {
	public class m_marry_visit_house_toc : Message
	{
		public int err_code = 0;
		public p_visit_role visit_role = null;
		public int time = 0;
		public int op_type = 0;
		public m_marry_visit_house_toc() {
		}
		public override string getMethodName() {
			return "marry_visit_house";
		}
		public override string getClassName() {
			return "m_marry_visit_house_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"visit_role", "p_visit_role", "null"},new string[] {"time", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
