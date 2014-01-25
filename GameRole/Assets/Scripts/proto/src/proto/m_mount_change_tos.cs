namespace proto {
	public class m_mount_change_tos : Message
	{
		public int type_id = 0;
		public m_mount_change_tos() {
		}
		public override string getMethodName() {
			return "mount_change";
		}
		public override string getClassName() {
			return "m_mount_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"}};
		}
	}
}
