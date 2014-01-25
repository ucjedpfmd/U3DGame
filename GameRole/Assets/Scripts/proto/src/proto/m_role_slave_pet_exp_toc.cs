namespace proto {
	public class m_role_slave_pet_exp_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public int pet_exp = 0;
		public m_role_slave_pet_exp_toc() {
		}
		public override string getMethodName() {
			return "role_slave_pet_exp";
		}
		public override string getClassName() {
			return "m_role_slave_pet_exp_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"pet_exp", "int", "null"}};
		}
	}
}
