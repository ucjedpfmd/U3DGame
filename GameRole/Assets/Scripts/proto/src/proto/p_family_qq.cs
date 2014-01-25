namespace proto {
	public class p_family_qq : Message
	{
		public bool bind = false;
		public int bind_times = 0;
		public int q_t_f = 0;
		public int f_t_q = 0;
		public string family_openid = null;
		public p_family_qq() {
		}
		public override string getClassName() {
			return "p_family_qq";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bind", "bool", "null"},new string[] {"bind_times", "int", "null"},new string[] {"q_t_f", "int", "null"},new string[] {"f_t_q", "int", "null"},new string[] {"family_openid", "string", "null"}};
		}
	}
}
