namespace proto {
	public class m_system_stat_tos : Message
	{
		public int type = 0;
		public int value = 0;
		public m_system_stat_tos() {
		}
		public override string getMethodName() {
			return "system_stat";
		}
		public override string getClassName() {
			return "m_system_stat_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
