namespace proto {
	public class m_race_action_tos : Message
	{
		public int action_id = 0;
		public m_race_action_tos() {
		}
		public override string getMethodName() {
			return "race_action";
		}
		public override string getClassName() {
			return "m_race_action_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_id", "int", "null"}};
		}
	}
}
