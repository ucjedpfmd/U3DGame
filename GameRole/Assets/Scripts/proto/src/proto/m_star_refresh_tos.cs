namespace proto {
	public class m_star_refresh_tos : Message
	{
		public int mission_id = 0;
		public int star = 0;
		public bool is_one_key = false;
		public m_star_refresh_tos() {
		}
		public override string getMethodName() {
			return "star_refresh";
		}
		public override string getClassName() {
			return "m_star_refresh_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mission_id", "int", "null"},new string[] {"star", "int", "null"},new string[] {"is_one_key", "bool", "null"}};
		}
	}
}
