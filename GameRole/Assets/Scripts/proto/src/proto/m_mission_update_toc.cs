namespace proto {
	public class m_mission_update_toc : Message
	{
		public object[] del_mission_list;
		public object[] update_mission_list;
		public m_mission_update_toc() {
		}
		public override string getMethodName() {
			return "mission_update";
		}
		public override string getClassName() {
			return "m_mission_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"del_mission_list", "array", "int"},new string[] {"update_mission_list", "array", "p_mission_info"}};
		}
	}
}
