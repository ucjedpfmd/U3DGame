namespace proto {
	public class p_qq_show : Message
	{
		public double role_id = 0;
		public string qq_show = null;
		public p_qq_show() {
		}
		public override string getClassName() {
			return "p_qq_show";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"qq_show", "string", "null"}};
		}
	}
}
