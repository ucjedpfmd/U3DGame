namespace proto {
	public class m_wing_change_toc : Message
	{
		public int err_code = 0;
		public int type_id = 0;
		public m_wing_change_toc() {
		}
		public override string getMethodName() {
			return "wing_change";
		}
		public override string getClassName() {
			return "m_wing_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type_id", "int", "null"}};
		}
	}
}
