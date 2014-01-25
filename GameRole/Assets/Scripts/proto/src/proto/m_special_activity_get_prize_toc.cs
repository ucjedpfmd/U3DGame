namespace proto {
	public class m_special_activity_get_prize_toc : Message
	{
		public bool succ = true;
		public string reason = null;
		public m_special_activity_get_prize_toc() {
		}
		public override string getMethodName() {
			return "special_activity_get_prize";
		}
		public override string getClassName() {
			return "m_special_activity_get_prize_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
