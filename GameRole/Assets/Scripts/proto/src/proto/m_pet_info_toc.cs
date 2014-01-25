namespace proto {
	public class m_pet_info_toc : Message
	{
		public int err_code = 0;
		public double target_role_id = 0;
		public object[] pet_infos;
		public object[] point_infos;
		public m_pet_info_toc() {
		}
		public override string getMethodName() {
			return "pet_info";
		}
		public override string getClassName() {
			return "m_pet_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"target_role_id", "double", "null"},new string[] {"pet_infos", "array", "p_pet"},new string[] {"point_infos", "array", "p_kv"}};
		}
	}
}
