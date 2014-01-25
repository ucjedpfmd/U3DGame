namespace proto {
	public class m_role_fly_toc : Message
	{
		public bool succ = true;
		public int error_code = 0;
		public double role_id = 0;
		public bool fly = true;
		public m_role_fly_toc() {
		}
		public override string getMethodName() {
			return "role_fly";
		}
		public override string getClassName() {
			return "m_role_fly_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"error_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"fly", "bool", "null"}};
		}
	}
}
