namespace proto {
	public class p_family_mission_list : Message
	{
		public object[] list;
		public p_family_mission_list() {
		}
		public override string getClassName() {
			return "p_family_mission_list";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_family_friend_info"}};
		}
	}
}
