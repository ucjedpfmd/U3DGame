namespace proto {
	public class m_marry_jewe_operation_tos : Message
	{
		public int op_type = 0;
		public int id = 0;
		public m_marry_jewe_operation_tos() {
		}
		public override string getMethodName() {
			return "marry_jewe_operation";
		}
		public override string getClassName() {
			return "m_marry_jewe_operation_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"id", "int", "null"}};
		}
	}
}
