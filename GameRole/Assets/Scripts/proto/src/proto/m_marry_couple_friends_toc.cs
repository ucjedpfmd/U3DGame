namespace proto {
	public class m_marry_couple_friends_toc : Message
	{
		public int err_code = 0;
		public object[] friends;
		public object[] houses;
		public int op_type = 0;
		public m_marry_couple_friends_toc() {
		}
		public override string getMethodName() {
			return "marry_couple_friends";
		}
		public override string getClassName() {
			return "m_marry_couple_friends_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"friends", "array", "p_recommend_member_info"},new string[] {"houses", "array", "p_couple_house"},new string[] {"op_type", "int", "null"}};
		}
	}
}
