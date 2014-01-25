namespace proto {
	public class m_friend_feed_spittor_tos : Message
	{
		public double role_id = 0;
		public int tab = 0;
		public m_friend_feed_spittor_tos() {
		}
		public override string getMethodName() {
			return "friend_feed_spittor";
		}
		public override string getClassName() {
			return "m_friend_feed_spittor_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"tab", "int", "null"}};
		}
	}
}
