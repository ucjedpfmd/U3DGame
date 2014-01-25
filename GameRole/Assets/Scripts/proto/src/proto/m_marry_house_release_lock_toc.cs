namespace proto {
	public class m_marry_house_release_lock_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public m_marry_house_release_lock_toc() {
		}
		public override string getMethodName() {
			return "marry_house_release_lock";
		}
		public override string getClassName() {
			return "m_marry_house_release_lock_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
