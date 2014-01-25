namespace proto {
	public class m_mission_do_tos : Message
	{
		public int id = 0;
		public int npc_id = 0;
		public object[] prop_choose;
		public m_mission_do_tos() {
		}
		public override string getMethodName() {
			return "mission_do";
		}
		public override string getClassName() {
			return "m_mission_do_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"npc_id", "int", "null"},new string[] {"prop_choose", "array", "int"}};
		}
	}
}
