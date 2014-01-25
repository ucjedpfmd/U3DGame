namespace proto {
	public class m_soul_power_info_toc : Message
	{
		public int remain_power = 0;
		public int add_hp = 0;
		public int level = 0;
		public m_soul_power_info_toc() {
		}
		public override string getMethodName() {
			return "soul_power_info";
		}
		public override string getClassName() {
			return "m_soul_power_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"remain_power", "int", "null"},new string[] {"add_hp", "int", "null"},new string[] {"level", "int", "null"}};
		}
	}
}
