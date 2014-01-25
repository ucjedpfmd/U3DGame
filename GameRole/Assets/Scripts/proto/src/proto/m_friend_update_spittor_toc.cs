namespace proto {
	public class m_friend_update_spittor_toc : Message
	{
		public bool can_feed = true;
		public bool all_role = false;
		public double role_id = 0;
		public m_friend_update_spittor_toc() {
		}
		public override string getMethodName() {
			return "friend_update_spittor";
		}
		public override string getClassName() {
			return "m_friend_update_spittor_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"can_feed", "bool", "null"},new string[] {"all_role", "bool", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
