namespace proto {
	public class m_race_action_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public int action_id = 0;
		public int num = 0;
		public m_race_action_toc() {
		}
		public override string getMethodName() {
			return "race_action";
		}
		public override string getClassName() {
			return "m_race_action_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"action_id", "int", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
