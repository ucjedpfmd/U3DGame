namespace proto {
	public class m_single_fb_chap_info_tos : Message
	{
		public int chap_id = 0;
		public m_single_fb_chap_info_tos() {
		}
		public override string getMethodName() {
			return "single_fb_chap_info";
		}
		public override string getClassName() {
			return "m_single_fb_chap_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"chap_id", "int", "null"}};
		}
	}
}
