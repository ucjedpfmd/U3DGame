namespace proto {
	public class m_platform_qqgame_feed_tos : Message
	{
		public string summary = "";
		public string content = "";
		public m_platform_qqgame_feed_tos() {
		}
		public override string getMethodName() {
			return "platform_qqgame_feed";
		}
		public override string getClassName() {
			return "m_platform_qqgame_feed_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"summary", "string", "null"},new string[] {"content", "string", "null"}};
		}
	}
}
