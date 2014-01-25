namespace proto {
	public class p_back_reward : Message
	{
		public int id = 0;
		public int type_id = 0;
		public int num = 0;
		public int state = 0;
		public p_back_reward() {
		}
		public override string getClassName() {
			return "p_back_reward";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
