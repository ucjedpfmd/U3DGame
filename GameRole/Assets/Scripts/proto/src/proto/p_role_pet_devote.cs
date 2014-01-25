namespace proto {
	public class p_role_pet_devote : Message
	{
		public int max_num = 0;
		public object[] pet_devotes;
		public p_role_pet_devote() {
		}
		public override string getClassName() {
			return "p_role_pet_devote";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_devotes", "array", "p_pet_devote"}};
		}
	}
}
