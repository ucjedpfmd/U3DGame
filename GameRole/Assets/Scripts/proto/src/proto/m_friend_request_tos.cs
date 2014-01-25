namespace proto {
	public class m_friend_request_tos : Message
	{
		public object[] names;
		public double role_id = 0;
		public int server = 0;
		public m_friend_request_tos() {
		}
		public override string getMethodName() {
			return "friend_request";
		}
		public override string getClassName() {
			return "m_friend_request_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"names", "array", "string"},new string[] {"role_id", "double", "null"},new string[] {"server", "int", "null"}};
		}
	}
}
