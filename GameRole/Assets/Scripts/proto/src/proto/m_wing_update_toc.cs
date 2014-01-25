namespace proto {
	public class m_wing_update_toc : Message
	{
		public p_wing wing = null;
		public m_wing_update_toc() {
		}
		public override string getMethodName() {
			return "wing_update";
		}
		public override string getClassName() {
			return "m_wing_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"wing", "p_wing", "null"}};
		}
	}
}
