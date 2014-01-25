namespace proto {
	public class m_mount_up_down_tos : Message
	{
		public int status = 0;
		public m_mount_up_down_tos() {
		}
		public override string getMethodName() {
			return "mount_up_down";
		}
		public override string getClassName() {
			return "m_mount_up_down_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"status", "int", "null"}};
		}
	}
}
