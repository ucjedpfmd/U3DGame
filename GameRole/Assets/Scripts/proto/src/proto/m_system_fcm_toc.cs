namespace proto {
	public class m_system_fcm_toc : Message
	{
		public string info = null;
		public int remain_time = 0;
		public int total_time = 0;
		public bool passed = false;
		public m_system_fcm_toc() {
		}
		public override string getMethodName() {
			return "system_fcm";
		}
		public override string getClassName() {
			return "m_system_fcm_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"info", "string", "null"},new string[] {"remain_time", "int", "null"},new string[] {"total_time", "int", "null"},new string[] {"passed", "bool", "null"}};
		}
	}
}
