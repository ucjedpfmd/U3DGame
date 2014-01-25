namespace proto {
	public class m_friend_list_tos : Message
	{
		public int tab = 0;
		public m_friend_list_tos() {
		}
		public override string getMethodName() {
			return "friend_list";
		}
		public override string getClassName() {
			return "m_friend_list_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"tab", "int", "null"}};
		}
	}
}
