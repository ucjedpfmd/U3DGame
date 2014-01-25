namespace proto {
	public class m_race_arrive_tos : Message
	{
		public int stage = 0;
		public m_race_arrive_tos() {
		}
		public override string getMethodName() {
			return "race_arrive";
		}
		public override string getClassName() {
			return "m_race_arrive_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"stage", "int", "null"}};
		}
	}
}
