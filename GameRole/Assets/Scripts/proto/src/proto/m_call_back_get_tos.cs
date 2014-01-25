namespace proto {
	public class m_call_back_get_tos : Message
	{
		public int id = 0;
		public m_call_back_get_tos() {
		}
		public override string getMethodName() {
			return "call_back_get";
		}
		public override string getClassName() {
			return "m_call_back_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"}};
		}
	}
}
