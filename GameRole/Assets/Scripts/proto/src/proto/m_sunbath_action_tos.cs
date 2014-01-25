namespace proto {
	public class m_sunbath_action_tos : Message
	{
		public int action_id = 0;
		public double target_id = 0;
		public m_sunbath_action_tos() {
		}
		public override string getMethodName() {
			return "sunbath_action";
		}
		public override string getClassName() {
			return "m_sunbath_action_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_id", "int", "null"},new string[] {"target_id", "double", "null"}};
		}
	}
}
