namespace proto {
	public class p_ice_arrow : Message
	{
		public int arrow_id = 0;
		public int create_time = 0;
		public int arrow_speed = 0;
		public p_ice_arrow() {
		}
		public override string getClassName() {
			return "p_ice_arrow";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"arrow_id", "int", "null"},new string[] {"create_time", "int", "null"},new string[] {"arrow_speed", "int", "null"}};
		}
	}
}
