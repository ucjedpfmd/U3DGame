namespace proto {
	public class m_lock_compel_unlock_tos : Message
	{
		public int give_up = 0;
		public m_lock_compel_unlock_tos() {
		}
		public override string getMethodName() {
			return "lock_compel_unlock";
		}
		public override string getClassName() {
			return "m_lock_compel_unlock_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"give_up", "int", "null"}};
		}
	}
}
