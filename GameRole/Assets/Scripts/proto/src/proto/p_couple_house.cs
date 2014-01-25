namespace proto {
	public class p_couple_house : Message
	{
		public double role_id = 0;
		public string house_name = null;
		public int luxury = 0;
		public bool is_online = true;
		public p_couple_house() {
		}
		public override string getClassName() {
			return "p_couple_house";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"house_name", "string", "null"},new string[] {"luxury", "int", "null"},new string[] {"is_online", "bool", "null"}};
		}
	}
}
