namespace proto {
	public class m_chat_in_channel_tos : Message
	{
		public int channel = 0;
		public string msg = null;
		public int msg_type = 0;
		public m_chat_in_channel_tos() {
		}
		public override string getMethodName() {
			return "chat_in_channel";
		}
		public override string getClassName() {
			return "m_chat_in_channel_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"channel", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"msg_type", "int", "null"}};
		}
	}
}
