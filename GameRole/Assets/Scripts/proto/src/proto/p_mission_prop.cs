namespace proto {
	public class p_mission_prop : Message
	{
		public int prop_id = 0;
		public int prop_type = 0;
		public int prop_num = 0;
		public bool bind = true;
		public int color = 0;
		public int quality = 0;
		public p_mission_prop() {
		}
		public override string getClassName() {
			return "p_mission_prop";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"prop_id", "int", "null"},new string[] {"prop_type", "int", "null"},new string[] {"prop_num", "int", "null"},new string[] {"bind", "bool", "null"},new string[] {"color", "int", "null"},new string[] {"quality", "int", "null"}};
		}
	}
}
