namespace proto {
	public class m_stat_info_tos : Message
	{
		public int type = 0;
		public m_stat_info_tos() {
		}
		public override string getMethodName() {
			return "stat_info";
		}
		public override string getClassName() {
			return "m_stat_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
