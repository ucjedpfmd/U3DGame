namespace proto {
	public class m_marry_house_visit_notice_toc : Message
	{
		public int op_type = 0;
		public p_visit_role visit_role = null;
		public int cd_time = 0;
		public int on_roles = 0;
		public double owner_id1 = 0;
		public double owner_id2 = 0;
		public m_marry_house_visit_notice_toc() {
		}
		public override string getMethodName() {
			return "marry_house_visit_notice";
		}
		public override string getClassName() {
			return "m_marry_house_visit_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"visit_role", "p_visit_role", "null"},new string[] {"cd_time", "int", "null"},new string[] {"on_roles", "int", "null"},new string[] {"owner_id1", "double", "null"},new string[] {"owner_id2", "double", "null"}};
		}
	}
}
