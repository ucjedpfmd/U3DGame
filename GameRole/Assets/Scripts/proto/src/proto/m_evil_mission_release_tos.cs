namespace proto {
	public class m_evil_mission_release_tos : Message
	{
		public int color_id = 0;
		public int op_type = 0;
		public bool auto_buy = true;
		public m_evil_mission_release_tos() {
		}
		public override string getMethodName() {
			return "evil_mission_release";
		}
		public override string getClassName() {
			return "m_evil_mission_release_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"color_id", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
