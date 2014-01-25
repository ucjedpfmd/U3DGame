namespace proto {
	public class m_broadcast_laba_tos : Message
	{
		public string content = null;
		public int type_id = 0;
		public m_broadcast_laba_tos() {
		}
		public override string getMethodName() {
			return "broadcast_laba";
		}
		public override string getClassName() {
			return "m_broadcast_laba_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"content", "string", "null"},new string[] {"type_id", "int", "null"}};
		}
	}
}
