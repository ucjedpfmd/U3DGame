namespace proto {
	public class p_pet_title : Message
	{
		public int title_id = 0;
		public string title_name = null;
		public int title_type = 0;
		public double role_id = 0;
		public double pet_id = 0;
		public bool show_in_sence = true;
		public p_pet_title() {
		}
		public override string getClassName() {
			return "p_pet_title";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"title_id", "int", "null"},new string[] {"title_name", "string", "null"},new string[] {"title_type", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"pet_id", "double", "null"},new string[] {"show_in_sence", "bool", "null"}};
		}
	}
}
