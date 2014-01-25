namespace proto {
	public class p_role_pet_skin : Message
	{
		public object[] pet_skins;
		public p_role_pet_skin() {
		}
		public override string getClassName() {
			return "p_role_pet_skin";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_skins", "array", "int"}};
		}
	}
}
