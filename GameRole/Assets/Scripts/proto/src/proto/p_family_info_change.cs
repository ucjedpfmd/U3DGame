namespace proto {
	public class p_family_info_change : Message
	{
		public int change_type = 0;
		public double role_id = 0;
		public int new_value = 0;
		public p_family_info_change() {
		}
		public override string getClassName() {
			return "p_family_info_change";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"change_type", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"new_value", "int", "null"}};
		}
	}
}
