namespace proto {
	public class p_pet_pearl : Message
	{
		public int type_id = 0;
		public int index = 0;
		public p_pet_pearl() {
		}
		public override string getClassName() {
			return "p_pet_pearl";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"index", "int", "null"}};
		}
	}
}
