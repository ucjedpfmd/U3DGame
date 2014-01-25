namespace proto {
	public class m_friend_update_family_toc : Message
	{
		public double role_id = 0;
		public double family_id = 0;
		public string family_name = null;
		public int level = 0;
		public m_friend_update_family_toc() {
		}
		public override string getMethodName() {
			return "friend_update_family";
		}
		public override string getClassName() {
			return "m_friend_update_family_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"level", "int", "null"}};
		}
	}
}
