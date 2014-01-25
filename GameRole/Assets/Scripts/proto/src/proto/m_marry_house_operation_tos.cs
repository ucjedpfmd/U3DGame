namespace proto {
	public class m_marry_house_operation_tos : Message
	{
		public int op_type = 0;
		public int arg = 0;
		public string new_name = null;
		public m_marry_house_operation_tos() {
		}
		public override string getMethodName() {
			return "marry_house_operation";
		}
		public override string getClassName() {
			return "m_marry_house_operation_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"arg", "int", "null"},new string[] {"new_name", "string", "null"}};
		}
	}
}
