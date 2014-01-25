namespace proto {
	public class m_marry_depot_move_tos : Message
	{
		public int op_type = 0;
		public int from_index = 0;
		public int to_index = 0;
		public m_marry_depot_move_tos() {
		}
		public override string getMethodName() {
			return "marry_depot_move";
		}
		public override string getClassName() {
			return "m_marry_depot_move_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"from_index", "int", "null"},new string[] {"to_index", "int", "null"}};
		}
	}
}
