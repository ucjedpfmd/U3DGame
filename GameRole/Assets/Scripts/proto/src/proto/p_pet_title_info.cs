namespace proto {
	public class p_pet_title_info : Message
	{
		public object[] pet_titles;
		public p_pet_title_info() {
		}
		public override string getClassName() {
			return "p_pet_title_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_titles", "array", "p_pet_title"}};
		}
	}
}
