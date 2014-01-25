namespace proto {
	public class m_mount_reinf_tos : Message
	{
		public int type = 0;
		public m_mount_reinf_tos() {
		}
		public override string getMethodName() {
			return "mount_reinf";
		}
		public override string getClassName() {
			return "m_mount_reinf_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
