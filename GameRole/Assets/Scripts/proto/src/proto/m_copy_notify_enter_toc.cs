namespace proto {
	public class m_copy_notify_enter_toc : Message
	{
		public int map_id = 0;
		public string lead_role_name = null;
		public m_copy_notify_enter_toc() {
		}
		public override string getMethodName() {
			return "copy_notify_enter";
		}
		public override string getClassName() {
			return "m_copy_notify_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"lead_role_name", "string", "null"}};
		}
	}
}
