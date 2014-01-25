namespace proto {
	public class p_feed_spittor_info : Message
	{
		public double role_id = 0;
		public string rolename = null;
		public int time = 0;
		public p_feed_spittor_info() {
		}
		public override string getClassName() {
			return "p_feed_spittor_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"rolename", "string", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
