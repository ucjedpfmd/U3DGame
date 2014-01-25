namespace proto {
	public class m_achievement_info_toc : Message
	{
		public int err_code = 0;
		public object[] lists;
		public int ranking = -1;
		public m_achievement_info_toc() {
		}
		public override string getMethodName() {
			return "achievement_info";
		}
		public override string getClassName() {
			return "m_achievement_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"lists", "array", "p_achieve_info"},new string[] {"ranking", "int", "null"}};
		}
	}
}
