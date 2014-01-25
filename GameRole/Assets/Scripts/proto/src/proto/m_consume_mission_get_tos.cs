namespace proto {
	public class m_consume_mission_get_tos : Message
	{
		public int type = 0;
		public int op_type = 0;
		public m_consume_mission_get_tos() {
		}
		public override string getMethodName() {
			return "consume_mission_get";
		}
		public override string getClassName() {
			return "m_consume_mission_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
