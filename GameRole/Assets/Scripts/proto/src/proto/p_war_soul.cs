namespace proto {
	public class p_war_soul : Message
	{
		public int id = 0;
		public int type_id = 0;
		public int index = 0;
		public int quality = 0;
		public int inc_rate = 0;
		public int drop_rate = 0;
		public object[] soul_props;
		public p_war_soul() {
		}
		public override string getClassName() {
			return "p_war_soul";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"index", "int", "null"},new string[] {"quality", "int", "null"},new string[] {"inc_rate", "int", "null"},new string[] {"drop_rate", "int", "null"},new string[] {"soul_props", "array", "p_add_prop"}};
		}
	}
}
