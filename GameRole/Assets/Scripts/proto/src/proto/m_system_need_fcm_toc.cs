namespace proto {
	public class m_system_need_fcm_toc : Message
	{
		public int remain_time = 0;
		public m_system_need_fcm_toc() {
		}
		public override string getMethodName() {
			return "system_need_fcm";
		}
		public override string getClassName() {
			return "m_system_need_fcm_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"remain_time", "int", "null"}};
		}
	}
}
