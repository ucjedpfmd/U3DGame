namespace proto {
	public class m_friend_upgrade_toc : Message
	{
		public double role_id = 0;
		public int oldlevel = 0;
		public int newlevel = 0;
		public m_friend_upgrade_toc() {
		}
		public override string getMethodName() {
			return "friend_upgrade";
		}
		public override string getClassName() {
			return "m_friend_upgrade_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"oldlevel", "int", "null"},new string[] {"newlevel", "int", "null"}};
		}
	}
}
