namespace proto {
	public class p_team_match_info : Message
	{
		public int team_id = 0;
		public int role_num = 0;
		public int copy_per = 0;
		public double role_id = 0;
		public p_team_match_info() {
		}
		public override string getClassName() {
			return "p_team_match_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"team_id", "int", "null"},new string[] {"role_num", "int", "null"},new string[] {"copy_per", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
