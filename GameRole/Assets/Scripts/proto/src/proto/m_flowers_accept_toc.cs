namespace proto {
	public class m_flowers_accept_toc : Message
	{
		public bool succ = true;
		public int id = 0;
		public double give_role_id = 0;
		public m_flowers_accept_toc() {
		}
		public override string getMethodName() {
			return "flowers_accept";
		}
		public override string getClassName() {
			return "m_flowers_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"id", "int", "null"},new string[] {"give_role_id", "double", "null"}};
		}
	}
}
