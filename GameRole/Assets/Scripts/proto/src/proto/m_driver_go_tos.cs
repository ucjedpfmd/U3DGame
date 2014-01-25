namespace proto {
	public class m_driver_go_tos : Message
	{
		public int id = 0;
		public int type = 1;
		public m_driver_go_tos() {
		}
		public override string getMethodName() {
			return "driver_go";
		}
		public override string getClassName() {
			return "m_driver_go_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type", "int", "null"}};
		}
	}
}
