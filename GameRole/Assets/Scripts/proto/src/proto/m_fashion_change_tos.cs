namespace proto {
	public class m_fashion_change_tos : Message
	{
		public int fashion_id = 0;
		public m_fashion_change_tos() {
		}
		public override string getMethodName() {
			return "fashion_change";
		}
		public override string getClassName() {
			return "m_fashion_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fashion_id", "int", "null"}};
		}
	}
}
