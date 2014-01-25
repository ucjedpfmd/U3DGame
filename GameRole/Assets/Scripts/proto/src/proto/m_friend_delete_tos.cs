namespace proto {
	public class m_friend_delete_tos : Message
	{
		public object[] role_ids;
		public int type = 0;
		public int tab = 0;
		public m_friend_delete_tos() {
		}
		public override string getMethodName() {
			return "friend_delete";
		}
		public override string getClassName() {
			return "m_friend_delete_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_ids", "array", "double"},new string[] {"type", "int", "null"},new string[] {"tab", "int", "null"}};
		}
	}
}
