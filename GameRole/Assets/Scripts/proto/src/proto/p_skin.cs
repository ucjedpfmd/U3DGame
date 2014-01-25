namespace proto {
	public class p_skin : Message
	{
		public int skinid = 0;
		public int hair_type = 1;
		public int hair_color = 0;
		public int weapon = 0;
		public int clothes = 0;
		public int mounts = 0;
		public int fashion = 0;
		public int wing = 0;
		public int wing_state = 0;
		public p_skin() {
		}
		public override string getClassName() {
			return "p_skin";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skinid", "int", "null"},new string[] {"hair_type", "int", "null"},new string[] {"hair_color", "int", "null"},new string[] {"weapon", "int", "null"},new string[] {"clothes", "int", "null"},new string[] {"mounts", "int", "null"},new string[] {"fashion", "int", "null"},new string[] {"wing", "int", "null"},new string[] {"wing_state", "int", "null"}};
		}
	}
}
