namespace proto {
	public class m_cut_soul_summon_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int skill_id = 0;
		public int skill_lv = 0;
		public m_cut_soul_summon_toc() {
		}
		public override string getMethodName() {
			return "cut_soul_summon";
		}
		public override string getClassName() {
			return "m_cut_soul_summon_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"skill_id", "int", "null"},new string[] {"skill_lv", "int", "null"}};
		}
	}
}
