namespace proto {
	public class m_activity_today_tos : Message
	{
		public int op_type = 1;
		public m_activity_today_tos() {
		}
		public override string getMethodName() {
			return "activity_today";
		}
		public override string getClassName() {
			return "m_activity_today_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
