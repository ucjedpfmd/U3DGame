namespace proto {
	public class m_fight_attack_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public double src_id = 0;
		public int skillid = 0;
		public int src_pos = 0;
		public int src_type = 0;
		public object[] result;
		public int dir = 0;
		public int dest_pos = 0;
		public int target_type = 0;
		public double target_id = 0;
		public int trigger_action = 0;
		public m_fight_attack_toc() {
		}
		public override string getMethodName() {
			return "fight_attack";
		}
		public override string getClassName() {
			return "m_fight_attack_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"src_id", "double", "null"},new string[] {"skillid", "int", "null"},new string[] {"src_pos", "int", "null"},new string[] {"src_type", "int", "null"},new string[] {"result", "array", "p_attack_result"},new string[] {"dir", "int", "null"},new string[] {"dest_pos", "int", "null"},new string[] {"target_type", "int", "null"},new string[] {"target_id", "double", "null"},new string[] {"trigger_action", "int", "null"}};
		}
	}
}
