namespace proto {
	public class m_sunbath_change_state_toc : Message
	{
		public double role_id = 0;
		public bool return_self = true;
		public int state = 0;
		public m_sunbath_change_state_toc() {
		}
		public override string getMethodName() {
			return "sunbath_change_state";
		}
		public override string getClassName() {
			return "m_sunbath_change_state_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"return_self", "bool", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
