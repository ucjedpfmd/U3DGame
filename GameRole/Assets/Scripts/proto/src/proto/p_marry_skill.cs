namespace proto {
	public class p_marry_skill : Message
	{
		public int skill_id = 0;
		public int skill_level = 0;
		public p_marry_skill() {
		}
		public override string getClassName() {
			return "p_marry_skill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"},new string[] {"skill_level", "int", "null"}};
		}
	}
}
