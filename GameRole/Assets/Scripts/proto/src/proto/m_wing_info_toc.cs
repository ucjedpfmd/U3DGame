namespace proto {
	public class m_wing_info_toc : Message
	{
		public double role_id = 0;
		public int type_id = 0;
		public object[] wing_list;
		public m_wing_info_toc() {
		}
		public override string getMethodName() {
			return "wing_info";
		}
		public override string getClassName() {
			return "m_wing_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"type_id", "int", "null"},new string[] {"wing_list", "array", "p_wing"}};
		}
	}
}
