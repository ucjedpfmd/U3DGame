namespace proto {
	public class m_system_hb_tos : Message
	{
		public int time = 0;
		public double server_time = 0;
		public m_system_hb_tos() {
		}
		public override string getMethodName() {
			return "system_hb";
		}
		public override string getClassName() {
			return "m_system_hb_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"time", "int", "null"},new string[] {"server_time", "double", "null"}};
		}
	}
}
