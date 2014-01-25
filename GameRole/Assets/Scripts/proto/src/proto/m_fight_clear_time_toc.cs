namespace proto {
	public class m_fight_clear_time_toc : Message
	{
		public int skill_id = 0;
		public m_fight_clear_time_toc() {
		}
		public override string getMethodName() {
			return "fight_clear_time";
		}
		public override string getClassName() {
			return "m_fight_clear_time_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skill_id", "int", "null"}};
		}
	}
}
