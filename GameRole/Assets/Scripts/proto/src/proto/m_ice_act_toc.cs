namespace proto {
	public class m_ice_act_toc : Message
	{
		public int err_code = 0;
		public int role_speed = 0;
		public int double_hit = 0;
		public int score = 0;
		public m_ice_act_toc() {
		}
		public override string getMethodName() {
			return "ice_act";
		}
		public override string getClassName() {
			return "m_ice_act_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_speed", "int", "null"},new string[] {"double_hit", "int", "null"},new string[] {"score", "int", "null"}};
		}
	}
}
