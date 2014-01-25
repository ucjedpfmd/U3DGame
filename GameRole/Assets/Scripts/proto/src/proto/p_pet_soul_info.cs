namespace proto {
	public class p_pet_soul_info : Message
	{
		public int max_num = 0;
		public object[] pet_souls;
		public p_pet_soul_info() {
		}
		public override string getClassName() {
			return "p_pet_soul_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_souls", "array", "p_pet_soul"}};
		}
	}
}
