namespace proto {
	public class p_fp_role_last_rank : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int ranking = 0;
		public p_fp_role_last_rank() {
		}
		public override string getClassName() {
			return "p_fp_role_last_rank";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"ranking", "int", "null"}};
		}
	}
}
