namespace proto {
	public class m_friend_modify_tos : Message
	{
		public p_role_ext info = null;
		public m_friend_modify_tos() {
		}
		public override string getMethodName() {
			return "friend_modify";
		}
		public override string getClassName() {
			return "m_friend_modify_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"info", "p_role_ext", "null"}};
		}
	}
}
