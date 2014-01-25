namespace proto {
	public class m_mount_step_up_tos : Message
	{
		public int type_id = 0;
		public int num = 0;
		public bool auto_buy = true;
		public m_mount_step_up_tos() {
		}
		public override string getMethodName() {
			return "mount_step_up";
		}
		public override string getClassName() {
			return "m_mount_step_up_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
