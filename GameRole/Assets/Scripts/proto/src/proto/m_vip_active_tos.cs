namespace proto {
	public class m_vip_active_tos : Message
	{
		public int type = 0;
		public int active_type = 0;
		public m_vip_active_tos() {
		}
		public override string getMethodName() {
			return "vip_active";
		}
		public override string getClassName() {
			return "m_vip_active_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"active_type", "int", "null"}};
		}
	}
}
