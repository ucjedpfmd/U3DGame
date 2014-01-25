namespace proto {
	public class p_pet_devote : Message
	{
		public double pet_id = 0;
		public object[] devote_props;
		public p_pet_devote() {
		}
		public override string getClassName() {
			return "p_pet_devote";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"devote_props", "array", "p_add_prop"}};
		}
	}
}
