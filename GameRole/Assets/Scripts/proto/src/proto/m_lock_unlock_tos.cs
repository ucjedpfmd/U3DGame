namespace proto {
	public class m_lock_unlock_tos : Message
	{
		public string pwd = null;
		public m_lock_unlock_tos() {
		}
		public override string getMethodName() {
			return "lock_unlock";
		}
		public override string getClassName() {
			return "m_lock_unlock_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pwd", "string", "null"}};
		}
	}
}
