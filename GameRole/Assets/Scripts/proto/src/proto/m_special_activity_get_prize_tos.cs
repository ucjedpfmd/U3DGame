namespace proto {
	public class m_special_activity_get_prize_tos : Message
	{
		public int activity_key = 0;
		public int condition_id = 0;
		public m_special_activity_get_prize_tos() {
		}
		public override string getMethodName() {
			return "special_activity_get_prize";
		}
		public override string getClassName() {
			return "m_special_activity_get_prize_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_key", "int", "null"},new string[] {"condition_id", "int", "null"}};
		}
	}
}
