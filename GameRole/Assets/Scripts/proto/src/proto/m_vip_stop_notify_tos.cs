namespace proto {
	public class m_vip_stop_notify_tos : Message
	{
		public int notify_type = 0;
		public m_vip_stop_notify_tos() {
		}
		public override string getMethodName() {
			return "vip_stop_notify";
		}
		public override string getClassName() {
			return "m_vip_stop_notify_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"notify_type", "int", "null"}};
		}
	}
}
