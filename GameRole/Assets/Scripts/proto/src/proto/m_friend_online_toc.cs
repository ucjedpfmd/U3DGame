namespace proto {
	public class m_friend_online_toc : Message
	{
		public double role_id = 0;
		public bool can_feed = true;
		public int tab = 0;
		public m_friend_online_toc() {
		}
		public override string getMethodName() {
			return "friend_online";
		}
		public override string getClassName() {
			return "m_friend_online_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"can_feed", "bool", "null"},new string[] {"tab", "int", "null"}};
		}
	}
}
