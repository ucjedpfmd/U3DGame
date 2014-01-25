namespace proto {
	public class p_role_pet_bag : Message
	{
		public int max_num = 0;
		public int max_training_num = 0;
		public object[] pet_briefs;
		public p_role_pet_bag() {
		}
		public override string getClassName() {
			return "p_role_pet_bag";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"max_training_num", "int", "null"},new string[] {"pet_briefs", "array", "p_pet_brief"}};
		}
	}
}
