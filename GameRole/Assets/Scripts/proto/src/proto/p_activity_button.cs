namespace proto {
	public class p_activity_button : Message
	{
		public string button_str = null;
		public int link_id = 0;
		public p_activity_button() {
		}
		public override string getClassName() {
			return "p_activity_button";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"button_str", "string", "null"},new string[] {"link_id", "int", "null"}};
		}
	}
}
