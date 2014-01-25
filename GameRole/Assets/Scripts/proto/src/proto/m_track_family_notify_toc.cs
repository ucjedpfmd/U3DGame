namespace proto {
	public class m_track_family_notify_toc : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int map_id = 0;
		public int pos = 0;
		public string attack_family = null;
		public m_track_family_notify_toc() {
		}
		public override string getMethodName() {
			return "track_family_notify";
		}
		public override string getClassName() {
			return "m_track_family_notify_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"attack_family", "string", "null"}};
		}
	}
}
