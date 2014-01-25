namespace proto {
	public class p_recommend_member_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int level = 0;
		public int sex = 0;
		public int category = 0;
		public int vip_level = 0;
		public p_recommend_member_info() {
		}
		public override string getClassName() {
			return "p_recommend_member_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"vip_level", "int", "null"}};
		}
	}
}
