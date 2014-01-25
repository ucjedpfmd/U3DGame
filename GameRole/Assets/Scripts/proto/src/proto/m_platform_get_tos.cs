namespace proto {
	public class m_platform_get_tos : Message
	{
		public int op_type = 0;
		public m_platform_get_tos() {
		}
		public override string getMethodName() {
			return "platform_get";
		}
		public override string getClassName() {
			return "m_platform_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
