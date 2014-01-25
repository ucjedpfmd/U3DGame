namespace proto {
	public class p_flowers_give_info1 : Message
	{
		public p_flowers_give_info info = null;
		public string flower_content = "";
		public p_flowers_give_info1() {
		}
		public override string getClassName() {
			return "p_flowers_give_info1";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"info", "p_flowers_give_info", "null"},new string[] {"flower_content", "string", "null"}};
		}
	}
}
