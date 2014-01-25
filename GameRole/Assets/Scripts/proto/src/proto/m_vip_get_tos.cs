namespace proto {
	public class m_vip_get_tos : Message
	{
		public int type = 0;
		public m_vip_get_tos() {
		}
		public override string getMethodName() {
			return "vip_get";
		}
		public override string getClassName() {
			return "m_vip_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
