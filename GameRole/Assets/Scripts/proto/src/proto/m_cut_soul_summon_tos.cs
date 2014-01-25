namespace proto {
	public class m_cut_soul_summon_tos : Message
	{
		public int op_type = 0;
		public int skill_id = 0;
		public m_cut_soul_summon_tos() {
		}
		public override string getMethodName() {
			return "cut_soul_summon";
		}
		public override string getClassName() {
			return "m_cut_soul_summon_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"skill_id", "int", "null"}};
		}
	}
}
