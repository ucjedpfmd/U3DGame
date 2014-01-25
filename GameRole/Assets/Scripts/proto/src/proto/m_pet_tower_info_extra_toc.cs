namespace proto {
	public class m_pet_tower_info_extra_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] scores;
		public object[] specs;
		public object[] medals;
		public m_pet_tower_info_extra_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_info_extra";
		}
		public override string getClassName() {
			return "m_pet_tower_info_extra_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"scores", "array", "p_tower_score"},new string[] {"specs", "array", "p_tower_barrier"},new string[] {"medals", "array", "int"}};
		}
	}
}
