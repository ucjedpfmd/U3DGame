namespace proto {
	public class p_house_pet : Message
	{
		public int level = 0;
		public object[] extra;
		public p_house_pet() {
		}
		public override string getClassName() {
			return "p_house_pet";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"level", "int", "null"},new string[] {"extra", "array", "p_key_value"}};
		}
	}
}
