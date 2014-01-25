namespace proto {
	public class m_fashion_info_toc : Message
	{
		public double role_id = 0;
		public int fashion_id = 0;
		public object[] fashion_list;
		public m_fashion_info_toc() {
		}
		public override string getMethodName() {
			return "fashion_info";
		}
		public override string getClassName() {
			return "m_fashion_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"fashion_id", "int", "null"},new string[] {"fashion_list", "array", "p_fashion"}};
		}
	}
}
