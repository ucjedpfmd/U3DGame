namespace proto {
	public class m_role_unbind_change_toc : Message
	{
		public bool succ = true;
		public m_role_unbind_change_toc() {
		}
		public override string getMethodName() {
			return "role_unbind_change";
		}
		public override string getClassName() {
			return "m_role_unbind_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"}};
		}
	}
}
