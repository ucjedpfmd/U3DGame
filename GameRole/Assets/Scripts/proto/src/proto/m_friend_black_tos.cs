namespace proto {
	public class m_friend_black_tos : Message
	{
		public string name = null;
		public double role_id = 0;
		public int server = 0;
		public m_friend_black_tos() {
		}
		public override string getMethodName() {
			return "friend_black";
		}
		public override string getClassName() {
			return "m_friend_black_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"name", "string", "null"},new string[] {"role_id", "double", "null"},new string[] {"server", "int", "null"}};
		}
	}
}
