namespace proto {
	public class m_race_collect_tos : Message
	{
		public int sunny = 0;
		public int action_id = 0;
		public m_race_collect_tos() {
		}
		public override string getMethodName() {
			return "race_collect";
		}
		public override string getClassName() {
			return "m_race_collect_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"sunny", "int", "null"},new string[] {"action_id", "int", "null"}};
		}
	}
}
