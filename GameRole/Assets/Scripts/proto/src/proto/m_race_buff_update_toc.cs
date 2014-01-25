namespace proto {
	public class m_race_buff_update_toc : Message
	{
		public p_key_value buff = null;
		public m_race_buff_update_toc() {
		}
		public override string getMethodName() {
			return "race_buff_update";
		}
		public override string getClassName() {
			return "m_race_buff_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"buff", "p_key_value", "null"}};
		}
	}
}
