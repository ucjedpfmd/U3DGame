namespace proto {
	public class m_friend_accept_tos : Message
	{
		public int server = 0;
		public double role_id = 0;
		public m_friend_accept_tos() {
		}
		public override string getMethodName() {
			return "friend_accept";
		}
		public override string getClassName() {
			return "m_friend_accept_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"server", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
