namespace proto {
	public class m_track_people_tos : Message
	{
		public int goods_id = 0;
		public string role_name = null;
		public m_track_people_tos() {
		}
		public override string getMethodName() {
			return "track_people";
		}
		public override string getClassName() {
			return "m_track_people_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
