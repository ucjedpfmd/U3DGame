namespace proto {
	public class m_ice_giveup_toc : Message
	{
		public int err_code = 0;
		public int remain_times = 0;
		public m_ice_giveup_toc() {
		}
		public override string getMethodName() {
			return "ice_giveup";
		}
		public override string getClassName() {
			return "m_ice_giveup_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"remain_times", "int", "null"}};
		}
	}
}
