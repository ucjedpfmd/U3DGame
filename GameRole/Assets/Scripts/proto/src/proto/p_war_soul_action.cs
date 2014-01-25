namespace proto {
	public class p_war_soul_action : Message
	{
		public int from_index = 0;
		public int to_index = 0;
		public int action = 0;
		public p_war_soul_action() {
		}
		public override string getClassName() {
			return "p_war_soul_action";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"from_index", "int", "null"},new string[] {"to_index", "int", "null"},new string[] {"action", "int", "null"}};
		}
	}
}
