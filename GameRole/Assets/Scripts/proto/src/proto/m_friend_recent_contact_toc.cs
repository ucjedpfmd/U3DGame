namespace proto {
	public class m_friend_recent_contact_toc : Message
	{
		public object[] recent_contact;
		public int tab = 0;
		public m_friend_recent_contact_toc() {
		}
		public override string getMethodName() {
			return "friend_recent_contact";
		}
		public override string getClassName() {
			return "m_friend_recent_contact_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"recent_contact", "array", "p_friend_info"},new string[] {"tab", "int", "null"}};
		}
	}
}
