namespace proto {
	public class m_mission_do_toc : Message
	{
		public int err_code = 0;
		public object[] code_data;
		public int id = 0;
		public int current_status = 0;
		public int pre_status = 0;
		public int current_model_status = 0;
		public int pre_model_status = 0;
		public p_mission_reward_data reward_data = null;
		public m_mission_do_toc() {
		}
		public override string getMethodName() {
			return "mission_do";
		}
		public override string getClassName() {
			return "m_mission_do_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"code_data", "array", "int"},new string[] {"id", "int", "null"},new string[] {"current_status", "int", "null"},new string[] {"pre_status", "int", "null"},new string[] {"current_model_status", "int", "null"},new string[] {"pre_model_status", "int", "null"},new string[] {"reward_data", "p_mission_reward_data", "null"}};
		}
	}
}
