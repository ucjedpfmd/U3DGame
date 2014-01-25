namespace proto {
	public class m_mission_cancel_toc : Message
	{
		public int err_code = 0;
		public object[] code_data;
		public int id = 0;
		public int current_status = 0;
		public int current_model_status = 0;
		public int pre_model_status = 0;
		public m_mission_cancel_toc() {
		}
		public override string getMethodName() {
			return "mission_cancel";
		}
		public override string getClassName() {
			return "m_mission_cancel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"code_data", "array", "int"},new string[] {"id", "int", "null"},new string[] {"current_status", "int", "null"},new string[] {"current_model_status", "int", "null"},new string[] {"pre_model_status", "int", "null"}};
		}
	}
}
