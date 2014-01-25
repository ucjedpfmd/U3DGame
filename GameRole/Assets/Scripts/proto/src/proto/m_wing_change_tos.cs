namespace proto {
	public class m_wing_change_tos : Message
	{
		public int type_id = 0;
		public bool op_type = true;
		public m_wing_change_tos() {
		}
		public override string getMethodName() {
			return "wing_change";
		}
		public override string getClassName() {
			return "m_wing_change_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"op_type", "bool", "null"}};
		}
	}
}
