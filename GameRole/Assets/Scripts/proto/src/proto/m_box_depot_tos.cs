namespace proto {
	public class m_box_depot_tos : Message
	{
		public int op_type = 0;
		public m_box_depot_tos() {
		}
		public override string getMethodName() {
			return "box_depot";
		}
		public override string getClassName() {
			return "m_box_depot_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
