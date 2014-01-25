namespace proto {
	public class m_flowers_accept_tos : Message
	{
		public int id = 0;
		public int reply_id = 0;
		public m_flowers_accept_tos() {
		}
		public override string getMethodName() {
			return "flowers_accept";
		}
		public override string getClassName() {
			return "m_flowers_accept_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"reply_id", "int", "null"}};
		}
	}
}
