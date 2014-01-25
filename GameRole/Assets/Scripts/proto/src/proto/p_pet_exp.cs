namespace proto {
	public class p_pet_exp : Message
	{
		public double pet_id = 0;
		public string pet_name = null;
		public int exp = 0;
		public p_pet_exp() {
		}
		public override string getClassName() {
			return "p_pet_exp";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"pet_name", "string", "null"},new string[] {"exp", "int", "null"}};
		}
	}
}
