namespace proto {
	public class m_friend_enemy_toc : Message
	{
		public p_friend_info enemy_info = null;
		public m_friend_enemy_toc() {
		}
		public override string getMethodName() {
			return "friend_enemy";
		}
		public override string getClassName() {
			return "m_friend_enemy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"enemy_info", "p_friend_info", "null"}};
		}
	}
}
