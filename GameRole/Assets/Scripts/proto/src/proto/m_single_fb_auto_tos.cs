namespace proto {
	public class m_single_fb_auto_tos : Message
	{
		public int op_type = 0;
		public int auto_start = 0;
		public int auto_end = 0;
		public m_single_fb_auto_tos() {
		}
		public override string getMethodName() {
			return "single_fb_auto";
		}
		public override string getClassName() {
			return "m_single_fb_auto_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"auto_start", "int", "null"},new string[] {"auto_end", "int", "null"}};
		}
	}
}
