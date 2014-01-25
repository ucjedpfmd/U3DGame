namespace proto {
	public class m_family_water_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int water_times = 0;
		public int cost = 0;
		public int get_spirit = 0;
		public m_family_water_toc() {
		}
		public override string getMethodName() {
			return "family_water";
		}
		public override string getClassName() {
			return "m_family_water_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"water_times", "int", "null"},new string[] {"cost", "int", "null"},new string[] {"get_spirit", "int", "null"}};
		}
	}
}
