namespace proto {
	public class m_pet_deploy_info_toc : Message
	{
		public int err_code = 0;
		public object[] deploys;
		public object[] add_props;
		public m_pet_deploy_info_toc() {
		}
		public override string getMethodName() {
			return "pet_deploy_info";
		}
		public override string getClassName() {
			return "m_pet_deploy_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"deploys", "array", "double"},new string[] {"add_props", "array", "p_add_prop"}};
		}
	}
}
