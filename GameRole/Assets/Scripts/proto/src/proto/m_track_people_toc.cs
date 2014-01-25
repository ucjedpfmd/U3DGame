namespace proto {
	public class m_track_people_toc : Message
	{
		public int err_code = 0;
		public double target_role_id = 0;
		public string role_name = null;
		public int map_id = 0;
		public int pos = 0;
		public m_track_people_toc() {
		}
		public override string getMethodName() {
			return "track_people";
		}
		public override string getClassName() {
			return "m_track_people_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"target_role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"}};
		}
	}
}
