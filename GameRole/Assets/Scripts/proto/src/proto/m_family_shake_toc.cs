namespace proto {
	public class m_family_shake_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int cost = 0;
		public int shake_times = 0;
		public int item_id = 0;
		public m_family_shake_toc() {
		}
		public override string getMethodName() {
			return "family_shake";
		}
		public override string getClassName() {
			return "m_family_shake_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"cost", "int", "null"},new string[] {"shake_times", "int", "null"},new string[] {"item_id", "int", "null"}};
		}
	}
}
