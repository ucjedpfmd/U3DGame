namespace proto {
	public class m_trap_enter_toc : Message
	{
		public object[] trap_list;
		public m_trap_enter_toc() {
		}
		public override string getMethodName() {
			return "trap_enter";
		}
		public override string getClassName() {
			return "m_trap_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"trap_list", "array", "p_map_trap"}};
		}
	}
}
