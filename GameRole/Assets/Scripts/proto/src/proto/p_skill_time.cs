namespace proto {
	public class p_skill_time : Message
	{
		public int skill_id = 0;
		public int last_use_time = 0;
		public p_skill_time() {
		}
		public override string getClassName() {
			return "p_skill_time";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"},new string[] {"last_use_time", "int", "null"}};
		}
	}
}
