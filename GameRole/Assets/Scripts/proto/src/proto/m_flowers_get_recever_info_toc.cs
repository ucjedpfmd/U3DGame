namespace proto {
	public class m_flowers_get_recever_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public m_flowers_get_recever_info_toc() {
		}
		public override string getMethodName() {
			return "flowers_get_recever_info";
		}
		public override string getClassName() {
			return "m_flowers_get_recever_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
