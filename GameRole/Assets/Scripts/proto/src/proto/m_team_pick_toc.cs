namespace proto {
	public class m_team_pick_toc : Message
	{
		public int err_code = 0;
		public double leader_id = 0;
		public int pick_type = 1;
		public m_team_pick_toc() {
		}
		public override string getMethodName() {
			return "team_pick";
		}
		public override string getClassName() {
			return "m_team_pick_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"leader_id", "double", "null"},new string[] {"pick_type", "int", "null"}};
		}
	}
}
