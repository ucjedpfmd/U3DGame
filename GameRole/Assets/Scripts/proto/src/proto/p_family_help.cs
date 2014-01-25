namespace proto {
	public class p_family_help : Message
	{
		public object[] friends;
		public p_family_help() {
		}
		public override string getClassName() {
			return "p_family_help";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"friends", "array", "p_family_friend"}};
		}
	}
}
