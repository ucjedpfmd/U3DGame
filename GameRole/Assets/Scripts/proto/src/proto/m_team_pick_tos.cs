namespace proto {
	public class m_team_pick_tos : Message
	{
		public int pick_type = 1;
		public m_team_pick_tos() {
		}
		public override string getMethodName() {
			return "team_pick";
		}
		public override string getClassName() {
			return "m_team_pick_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pick_type", "int", "null"}};
		}
	}
}
