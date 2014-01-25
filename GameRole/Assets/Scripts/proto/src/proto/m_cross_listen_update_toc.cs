namespace proto {
	public class m_cross_listen_update_toc : Message
	{
		public int miss_id = 0;
		public object[] listen;
		public m_cross_listen_update_toc() {
		}
		public override string getMethodName() {
			return "cross_listen_update";
		}
		public override string getClassName() {
			return "m_cross_listen_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"miss_id", "int", "null"},new string[] {"listen", "array", "p_cross_listen"}};
		}
	}
}
