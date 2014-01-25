namespace proto {
	public class m_race_get_tos : Message
	{
		public int type = 0;
		public int multiple = 0;
		public m_race_get_tos() {
		}
		public override string getMethodName() {
			return "race_get";
		}
		public override string getClassName() {
			return "m_race_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"multiple", "int", "null"}};
		}
	}
}
