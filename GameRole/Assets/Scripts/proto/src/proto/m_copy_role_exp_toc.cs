namespace proto {
	public class m_copy_role_exp_toc : Message
	{
		public int level = 0;
		public double exp = 0;
		public m_copy_role_exp_toc() {
		}
		public override string getMethodName() {
			return "copy_role_exp";
		}
		public override string getClassName() {
			return "m_copy_role_exp_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"exp", "double", "null"}};
		}
	}
}
