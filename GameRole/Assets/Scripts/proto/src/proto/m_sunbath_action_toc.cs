namespace proto {
	public class m_sunbath_action_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public int action_id = 0;
		public double role_id = 0;
		public int role_pos = 0;
		public double target_id = 0;
		public int target_pos = 0;
		public int times = 0;
		public string role_name = "";
		public int state = 0;
		public m_sunbath_action_toc() {
		}
		public override string getMethodName() {
			return "sunbath_action";
		}
		public override string getClassName() {
			return "m_sunbath_action_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"action_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_pos", "int", "null"},new string[] {"target_id", "double", "null"},new string[] {"target_pos", "int", "null"},new string[] {"times", "int", "null"},new string[] {"role_name", "string", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
