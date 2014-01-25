namespace proto {
	public class p_role_skill : Message
	{
		public int skill_id = 0;
		public int cur_level = 0;
		public p_role_skill() {
		}
		public override string getClassName() {
			return "p_role_skill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"},new string[] {"cur_level", "int", "null"}};
		}
	}
}
