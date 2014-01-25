namespace proto {
	public class m_marry_feast_list_toc : Message
	{
		public object[] lists;
		public m_marry_feast_list_toc() {
		}
		public override string getMethodName() {
			return "marry_feast_list";
		}
		public override string getClassName() {
			return "m_marry_feast_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"lists", "array", "p_role_eat_time"}};
		}
	}
}
