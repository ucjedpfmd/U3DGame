namespace proto {
	public class m_marry_furniture_operation_tos : Message
	{
		public int op_type = 0;
		public int id = 0;
		public int style = 0;
		public int item_id = 0;
		public int perfect_id = 0;
		public bool is_auto = true;
		public m_marry_furniture_operation_tos() {
		}
		public override string getMethodName() {
			return "marry_furniture_operation";
		}
		public override string getClassName() {
			return "m_marry_furniture_operation_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"id", "int", "null"},new string[] {"style", "int", "null"},new string[] {"item_id", "int", "null"},new string[] {"perfect_id", "int", "null"},new string[] {"is_auto", "bool", "null"}};
		}
	}
}
