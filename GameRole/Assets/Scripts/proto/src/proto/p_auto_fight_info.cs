namespace proto {
	public class p_auto_fight_info : Message
	{
		public string role_name = null;
		public string oppo_role_name = null;
		public int exp = 0;
		public int skill_exp = 0;
		public object[] rewards;
		public int result = 0;
		public double fight_id = 0;
		public int barrier = 0;
		public int next_barrier = 0;
		public p_auto_fight_info() {
		}
		public override string getClassName() {
			return "p_auto_fight_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_name", "string", "null"},new string[] {"oppo_role_name", "string", "null"},new string[] {"exp", "int", "null"},new string[] {"skill_exp", "int", "null"},new string[] {"rewards", "array", "p_key_value"},new string[] {"result", "int", "null"},new string[] {"fight_id", "double", "null"},new string[] {"barrier", "int", "null"},new string[] {"next_barrier", "int", "null"}};
		}
	}
}
