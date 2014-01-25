namespace proto {
	public class m_stat_action_tos : Message
	{
		public int type = 0;
		public m_stat_action_tos() {
		}
		public override string getMethodName() {
			return "stat_action";
		}
		public override string getClassName() {
			return "m_stat_action_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
