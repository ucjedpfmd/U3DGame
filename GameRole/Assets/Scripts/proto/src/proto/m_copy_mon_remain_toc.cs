namespace proto {
	public class m_copy_mon_remain_toc : Message
	{
		public int mon_num = 0;
		public m_copy_mon_remain_toc() {
		}
		public override string getMethodName() {
			return "copy_mon_remain";
		}
		public override string getClassName() {
			return "m_copy_mon_remain_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mon_num", "int", "null"}};
		}
	}
}
