namespace proto {
	public class m_function_reward_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public bool is_reward = true;
		public int func = 0;
		public m_function_reward_toc() {
		}
		public override string getMethodName() {
			return "function_reward";
		}
		public override string getClassName() {
			return "m_function_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"is_reward", "bool", "null"},new string[] {"func", "int", "null"}};
		}
	}
}
