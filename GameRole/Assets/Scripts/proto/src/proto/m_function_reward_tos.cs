namespace proto {
	public class m_function_reward_tos : Message
	{
		public int op_type = 0;
		public int func = 0;
		public m_function_reward_tos() {
		}
		public override string getMethodName() {
			return "function_reward";
		}
		public override string getClassName() {
			return "m_function_reward_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"func", "int", "null"}};
		}
	}
}
