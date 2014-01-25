namespace proto {
	public class m_family_mission_ask_toc : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public bool is_friend = true;
		public int mission_id = 0;
		public int color = 0;
		public m_family_mission_ask_toc() {
		}
		public override string getMethodName() {
			return "family_mission_ask";
		}
		public override string getClassName() {
			return "m_family_mission_ask_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"is_friend", "bool", "null"},new string[] {"mission_id", "int", "null"},new string[] {"color", "int", "null"}};
		}
	}
}
