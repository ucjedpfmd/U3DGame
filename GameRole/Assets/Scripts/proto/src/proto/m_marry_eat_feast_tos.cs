namespace proto {
	public class m_marry_eat_feast_tos : Message
	{
		public int table = 0;
		public int eat_type = 0;
		public m_marry_eat_feast_tos() {
		}
		public override string getMethodName() {
			return "marry_eat_feast";
		}
		public override string getClassName() {
			return "m_marry_eat_feast_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"table", "int", "null"},new string[] {"eat_type", "int", "null"}};
		}
	}
}
