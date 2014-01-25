namespace proto {
	public class p_role_pet_embattle : Message
	{
		public int max_num = 0;
		public object[] pet_embattles;
		public p_role_pet_embattle() {
		}
		public override string getClassName() {
			return "p_role_pet_embattle";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_embattles", "array", "p_pet_embattle"}};
		}
	}
}
